namespace BaseballStat.Services.Data.Tests.UseInMemoryDataBase
{
    using System;
    using System.Threading.Tasks;

    using BaseballStat.Data;

    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Repositories;
    using BaseballStat.Services.Data.AllTimeGreat;
    using BaseballStat.Services.Data.Award;
    using BaseballStat.Services.Data.League;
    using BaseballStat.Services.Data.LeagueStatistic;
    using BaseballStat.Services.Data.Player;
    using BaseballStat.Services.Data.PlayerStattistic;
    using BaseballStat.Services.Data.Records;
    using BaseballStat.Services.Data.Teams;
    using BaseballStat.Services.Data.TeamStatistic;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Nest;

    public class BaseServiceTests : IAsyncDisposable
    {
        protected BaseServiceTests()
        {
            var services = this.SetServices();

            this.ServiceProvider = services.BuildServiceProvider();
            this.DbContext = this.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        }

        protected IServiceProvider ServiceProvider { get; }

        protected ApplicationDbContext DbContext { get; }

        public async ValueTask DisposeAsync()
        {
            if (this.DbContext != null)
            {
                await this.DbContext.Database.EnsureDeletedAsync();
                await this.DbContext.DisposeAsync();
            }

            if (this.ServiceProvider is IAsyncDisposable asyncDisposable)
            {
                await asyncDisposable.DisposeAsync();
            }
        }

        private ServiceCollection SetServices()
        {
            var services = new ServiceCollection();

            // Configure in-memory database for EF Core
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseInMemoryDatabase(Guid.NewGuid().ToString());
            });

            // Register repositories
            services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            // Register application services
            services.AddTransient<IPlayerService, PlayerService>();
            services.AddTransient<IAwardService, AwardService>();
            services.AddTransient<IPlayerStatisticService, PlayerStatisticService>();
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<ITeamStatisticService, TeamStatisticService>();
            services.AddTransient<ILeagueService, LeagueService>();
            services.AddTransient<ILeagueStatisticService, LeagueStatisticService>();
            services.AddTransient<IRecordService, RecordService>();
            services.AddTransient<IAllTimeGreatService, AllTimeGreatService>();

            return services;
        }
    }
}
