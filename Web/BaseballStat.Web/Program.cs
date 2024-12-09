namespace BaseballStat.Web
{
    using System;
    using System.Reflection;

    using BaseballStat.Common;

    using BaseballStat.Data;
    using BaseballStat.Data.Common;
    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Data.Repositories;
    using BaseballStat.Data.Seeding;
    using BaseballStat.Services.Cloudinary;
    using BaseballStat.Services.Data.AllTimeGreat;
    using BaseballStat.Services.Data.Award;
    using BaseballStat.Services.Data.Categories;
    using BaseballStat.Services.Data.League;
    using BaseballStat.Services.Data.LeagueStatistic;
    using BaseballStat.Services.Data.Player;
    using BaseballStat.Services.Data.PlayerStattistic;
    using BaseballStat.Services.Data.Records;
    using BaseballStat.Services.Data.Setting;
    using BaseballStat.Services.Data.Teams;
    using BaseballStat.Services.Data.TeamStatistic;
    using BaseballStat.Services.Mapping;
    using BaseballStat.Services.Messaging;
    using BaseballStat.Web.ViewModels;
    using CloudinaryDotNet;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder.Services, builder.Configuration);
            var app = builder.Build();
            Configure(app);
            app.Run();
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<ApplicationUser>(IdentityOptionsProvider.GetIdentityOptions)
                .AddRoles<ApplicationRole>().AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<CookiePolicyOptions>(
                options =>
                {
                    options.CheckConsentNeeded = context => true;
                    options.MinimumSameSitePolicy = SameSiteMode.None;
                });

            services.AddControllersWithViews(
                options =>
                {
                    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                }).AddRazorRuntimeCompilation();
            services.AddRazorPages();
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddSingleton(configuration);

            // Data repositories
            services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
            services.AddScoped(typeof(IDeletableEntity<>), typeof(EfRepository<>));
            services.AddScoped<IDbQueryRunner, DbQueryRunner>();

            // Cloudinary Setup
            Cloudinary cloudinary = new Cloudinary(new Account(
                 configuration["Cloudinary:CloudName"],
                 configuration["Cloudinary:ApiKey"],
                 configuration["Cloudinary:ApiSecret"]));
            services.AddSingleton(cloudinary);

            // Application services
            services.AddTransient<IEmailSender, NullMessageSender>();
            services.AddTransient<ISettingsService, SettingsService>();
            services.AddTransient<ICloudinaryService, CloudinaryService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            services.AddTransient<IPlayerService, PlayerService>();
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<ILeagueService, LeagueService>();
            services.AddTransient<IPlayerStatisticService, PlayerStatisticService>();
            services.AddTransient<ITeamStatisticService, TeamStatisticService>();
            services.AddTransient<ILeagueStatisticService, LeagueStatisticService>();
            services.AddTransient<IAwardService, AwardService>();
            services.AddTransient<IAllTimeGreatService, AllTimeGreatService>();
            services.AddTransient<IRecordService, RecordService>();

            // Add AutoMapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        private static void Configure(WebApplication app)
        {
            // Seed data on application startup
            using (var serviceScope = app.Services.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                dbContext.Database.Migrate();
                new ApplicationDbContextSeeder().SeedAsync(dbContext, serviceScope.ServiceProvider).GetAwaiter().GetResult();
            }

            AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).GetTypeInfo().Assembly);

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePagesWithReExecute("/Home/Error/{0}");
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseStatusCodePagesWithReExecute("/Home/Error/{0}");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute("areaRoute", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();
        }
    }
}
