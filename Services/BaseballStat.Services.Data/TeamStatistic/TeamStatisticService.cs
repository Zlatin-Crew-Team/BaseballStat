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

        public async Task AddTeamStatisticAsync(int teamId, int games, int wins, int losses, int titles)
        {
            var teamStatistic = new TeamStatistic
            {
                TeamId = teamId,
                Games = games,
                Wins = wins,
                Losses = losses,
                Titles = titles,
            };
            await this.teamsStatistics.AddAsync(teamStatistic);
            await this.teamsStatistics.SaveChangesAsync();
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

        public async Task<IEnumerable<T>> GetAllTeamStatisticsAsync<T>(int? count = null)
        {
            IQueryable<TeamStatistic> query = this.teamsStatistics
                .All()
                .OrderBy(x => x.Id);
            if (count.HasValue)
            {
                query = (IOrderedQueryable<TeamStatistic>)query.Take(count.Value);
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
    }
}
