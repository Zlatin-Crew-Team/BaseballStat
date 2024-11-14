namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    public class TeamStatisticSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.TeamStatistics.Any())
            {
                return;
            }

            var teamStatistics = new TeamStatistic[]
            {
                new TeamStatistic
                {
                  TeamId = 1,
                  Games = 19218,
                  Wins = 9955,
                  Losses = 9263,
                  Titles = 9,
                },

                new TeamStatistic
                {
                  TeamId = 2,
                  Games = 19622,
                  Wins = 10778,
                  Losses = 8148,
                  Titles = 27,
                },
                new TeamStatistic
                {
                  TeamId = 3,
                  Games = 4270,
                  Wins = 2091,
                  Losses = 2079,
                  Titles = 0,
                },
                new TeamStatistic
                {
                  TeamId = 4,
                  Games = 7549,
                  Wins = 3761,
                  Losses = 3788,
                  Titles = 2,
                },
                new TeamStatistic
                {
                  TeamId = 5,
                  Games = 19204,
                  Wins = 9120,
                  Losses = 10084,
                  Titles = 3,
                },
                new TeamStatistic
                {
                  TeamId = 6,
                  Games = 19206,
                  Wins = 9594,
                  Losses = 9612,
                  Titles = 3,
                },
                new TeamStatistic
                {
                  TeamId = 7,
                  Games = 19221,
                  Wins = 9852,
                  Losses = 9369,
                  Titles = 2,
                },
                new TeamStatistic
                {
                  TeamId = 8,
                  Games = 19223,
                  Wins = 9676,
                  Losses = 9567,
                  Titles = 4,
                },
                new TeamStatistic
                {
                  TeamId = 9,
                  Games = 8831,
                  Wins = 4208,
                  Losses = 4623,
                  Titles = 2,
                },
                new TeamStatistic
                {
                  TeamId = 10,
                  Games = 19214,
                  Wins = 9259,
                  Losses = 9955,
                  Titles = 3,
                },
                new TeamStatistic
                {
                  TeamId = 11,
                  Games = 9974,
                  Wins = 5009,
                  Losses = 4965,
                  Titles = 2,
                },
                new TeamStatistic
                {
                  TeamId = 12,
                  Games = 10136,
                  Wins = 5021,
                  Losses = 5115,
                  Titles = 1,
                },
                new TeamStatistic
                {
                  TeamId = 13,
                  Games = 19174,
                  Wins = 9329,
                  Losses = 9859,
                  Titles = 9,
                },
                new TeamStatistic
                {
                  TeamId = 14,
                  Games = 7549,
                  Wins = 3599,
                  Losses = 3950,
                  Titles = 0,
                },
                new TeamStatistic
                {
                  TeamId = 15,
                  Games = 10120,
                  Wins = 4818,
                  Losses = 5302,
                  Titles = 1,
                },
                new TeamStatistic
                {
                  TeamId = 16,
                  Games = 22063,
                  Wins = 11114,
                  Losses = 10949,
                  Titles = 4,
                },
                new TeamStatistic
                {
                  TeamId = 17,
                  Games = 5012,
                  Wins = 2303,
                  Losses = 2709,
                  Titles = 2,
                },
                new TeamStatistic
                {
                  TeamId = 18,
                  Games = 9964,
                  Wins = 4816,
                  Losses = 5148,
                  Titles = 2,
                },
                new TeamStatistic
                {
                  TeamId = 19,
                  Games = 21533,
                  Wins = 10207,
                  Losses = 11326,
                  Titles = 2,
                },
                new TeamStatistic
                {
                  TeamId = 20,
                  Games = 8834,
                  Wins = 4265,
                  Losses = 4569,
                  Titles = 1,
                },
                new TeamStatistic
                {
                  TeamId = 21,
                  Games = 22093,
                  Wins = 11327,
                  Losses = 10767,
                  Titles = 3,
                },
                new TeamStatistic
                {
                  TeamId = 22,
                  Games = 21710,
                  Wins = 10934,
                  Losses = 10766,
                  Titles = 5,
                },
                new TeamStatistic
                {
                  TeamId = 23,
                  Games = 8838,
                  Wins = 4308,
                  Losses = 4530,
                  Titles = 0,
                },
                new TeamStatistic
                {
                  TeamId = 24,
                  Games = 21658,
                  Wins = 10839,
                  Losses = 10819,
                  Titles = 5,
                },
                new TeamStatistic
                {
                  TeamId = 25,
                  Games = 21687,
                  Wins = 11285,
                  Losses = 10402,
                  Titles = 11,
                },
                new TeamStatistic
                 {
                    TeamId = 26,
                    Games = 4272,
                    Wins = 2087,
                    Losses = 2185,
                    Titles = 1,
                 },
                new TeamStatistic
                {
                  TeamId = 27,
                  Games = 5020,
                  Wins = 2321,
                  Losses = 2699,
                  Titles = 0,
                },
                new TeamStatistic
                {
                  TeamId = 28,
                  Games = 21520,
                  Wins = 11432,
                  Losses = 10068,
                  Titles = 8,
                },
                new TeamStatistic
                {
                  TeamId = 29,
                  Games = 8844,
                  Wins = 4127,
                  Losses = 4717,
                  Titles = 0,
                },
                new TeamStatistic
                {
                  TeamId = 30,
                  Games = 21560,
                  Wins = 11541,
                  Losses = 10019,
                  Titles = 8,
                },
            };

            await dbContext.TeamStatistics.AddRangeAsync(teamStatistics);
            await dbContext.SaveChangesAsync();
        }
    }
}
