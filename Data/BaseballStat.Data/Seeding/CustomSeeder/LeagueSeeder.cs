namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    public class LeagueSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Leagues.Any())
            {
                return;
            }

            var leagues = new League[]
            {
                new League
                {
                    Name = "American League",

                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730651874/Mlb%20Logos/_american_league_logo_primary_20193833_f1swqu.png",
                },
                new League
                {
                    Name = "National League",

                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730651980/Mlb%20Logos/9184__national_league-primary-2019_nkmoil.png",
                },
            };
            foreach (var league in leagues)
            {
                await dbContext.AddAsync(league);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
