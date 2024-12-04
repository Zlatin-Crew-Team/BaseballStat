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
        private readonly IDeletableEntityRepository<TeamStatistic> teamsStatistics;

        public TeamStatisticService(IDeletableEntityRepository<TeamStatistic> teamStatistics)
        {
            this.teamsStatistics = teamStatistics;
        }

        public Task<int> AddTeamStatisticAsync(int teamId, int games, int wins, int losses, int titles)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteTeamStatisticAsync(int id)
        {
            var teamStatistic = await this.teamsStatistics
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this.teamsStatistics.Delete(teamStatistic);
            await this.teamsStatistics.SaveChangesAsync();
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

        public async Task<T> GetTeamStatisticByIdAsync<T>(int id)
        {
            var teamStatistic = await this.teamsStatistics
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefaultAsync();
            return teamStatistic;
        }
    }
}
