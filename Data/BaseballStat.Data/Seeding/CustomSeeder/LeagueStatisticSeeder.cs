namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    public class LeagueStatisticSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.LeagueStatistics.Any())
            {
                return;
            }

            var leagueStatistic = new LeagueStatistic[]
            {
                new LeagueStatistic
                {
                    LeagueId = 1,
                    Games = 121585,
                    Wins = 61025,
                    Losses = 60560,
                    Titles = 76,
                },

                new LeagueStatistic
                {
                   LeagueId = 2,
                   Games = 123456,
                   Wins = 62256,
                   Losses = 6120,
                   Titles = 56,
                },
            };
            foreach (var league in leagueStatistic)
            {
                await dbContext.AddAsync(league);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
