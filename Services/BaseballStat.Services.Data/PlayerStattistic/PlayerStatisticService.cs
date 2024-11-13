namespace BaseballStat.Services.Data.PlayerStattistic
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
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;

    public class PlayerStatisticService : IPlayerStatisticService
    {
        private readonly IDeletableEntityRepository<PlayerStatistic> playersStatistics;

        public PlayerStatisticService(IDeletableEntityRepository<PlayerStatistic> playersStatistics)
        {
            this.playersStatistics = playersStatistics;
        }

        public async Task DeletePlayerStatisticAsync(int id)
        {
            var playerStatistic = await this.playersStatistics
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this.playersStatistics.Delete(playerStatistic);
            await this.playersStatistics.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllPlayerStatisticsAsync<T>(int? count = null)
        {
            IQueryable<PlayerStatisticViewModel> query = (IQueryable<PlayerStatisticViewModel>)this.playersStatistics
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
            var playerStatistic = await this.playersStatistics
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefaultAsync();
            return playerStatistic;
        }

        public async Task<T> GetPlayerStatisticByIdAsync<T>(int id)
        {
            var playerStatistic = await this.playersStatistics
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefaultAsync();
            return playerStatistic;
        }
    }
}
