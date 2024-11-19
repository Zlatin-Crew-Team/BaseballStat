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
        private readonly IRepository<LeagueStatistic> leagueStatistics;

        public LeagueStatisticService(IRepository<LeagueStatistic> leagueStatistics)
        {
            this.leagueStatistics = leagueStatistics;
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

        public async Task<T> GetLeagueStatisticByIdAsync<T>(int id)
        {
            var leagueStatistic = await this.leagueStatistics
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefaultAsync();
            return leagueStatistic;
        }
    }
}
