namespace BaseballStat.Services.Data.TeamStatistic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;
    using BaseballStat.Web.ViewModels.PlayerStatistic;
    using BaseballStat.Web.ViewModels.TeamStatistic;
    using Microsoft.EntityFrameworkCore;

    public class TeamStatisticService : ITeamStatisticService
    {
        private readonly IRepository<TeamStatistic> teamsStatistics;

        public TeamStatisticService(IRepository<TeamStatistic> teamStatistics)
        {
            this.teamsStatistics = teamStatistics;
        }

        public Task DeleteTeamStatisticAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllTeamStatisticsAsync<T>(int? count = null)
        {
            IQueryable<TeamStatisticViewModel> query = (IQueryable<TeamStatisticViewModel>)this.teamsStatistics
              .All()
              .OrderBy(x => x.Id);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return await query.To<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync<T>(int id)
        {
            var teamStatistic = await this.teamsStatistics
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefaultAsync();
            return teamStatistic;
        }

        public Task<T> GetTeamStatisticByIdAsync<T>(int id)
        {
            throw new NotImplementedException();
        }
    }
}
