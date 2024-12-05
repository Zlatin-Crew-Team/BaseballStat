namespace BaseballStat.Services.Data.LeagueStatistic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class LeagueStatisticService : ILeagueStatisticService
    {
        private readonly IDeletableEntity<LeagueStatistic> leagueStatistics;

        public LeagueStatisticService(IDeletableEntity<LeagueStatistic> leagueStatistics)
        {
            this.leagueStatistics = leagueStatistics;
        }

        public async Task AddLeagueStatisticAsync(int leagueId, int games, int wins, int losses, int titles)
        {
            var leagueStatistic = new LeagueStatistic
            {
                LeagueId = leagueId,
                Games = games,
                Wins = wins,
                Losses = losses,
                Titles = titles,
            };
            await this.leagueStatistics.AddAsync(leagueStatistic);
            await this.leagueStatistics.SaveChangesAsync();
        }

        public Task DeleteLeagueStatisticAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync<T>(int id)
        {
            var leagueStatistic = await this.leagueStatistics
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefaultAsync();
            return leagueStatistic;
        }

        public async Task<IEnumerable<T>> GetAllLeagueStatisticsAsync<T>(int? count = null)
        {
            IQueryable<LeagueStatistic> query = this.leagueStatistics
                .All()
                .OrderBy(x => x.Id);
            if (count.HasValue)
            {
                query = (IOrderedQueryable<LeagueStatistic>)query.Take(count.Value);
            }

            return await query.To<T>().ToListAsync();
        }
    }
}
