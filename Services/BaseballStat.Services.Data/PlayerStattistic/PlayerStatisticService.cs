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
        private readonly IDeletableEntityRepository<BaseballStat.Data.Models.PlayerStatisticViewModel> playersStatistics;

        public PlayerStatisticService(IDeletableEntityRepository<BaseballStat.Data.Models.PlayerStatisticViewModel> playersStatistics)
        {
            this.playersStatistics = playersStatistics;
        }

        public async Task AddPlayerStatisticAsync(Web.ViewModels.PlayerStatistic.PlayerStatisticViewModel playerStatisticViewModel)
        {
            var playerStatistic = new BaseballStat.Data.Models.PlayerStatisticViewModel
            {
                PlayerId = playerStatisticViewModel.PlayerId,
                Games = playerStatisticViewModel.Games,
                AtBats = playerStatisticViewModel.AtBats,
                Runs = playerStatisticViewModel.Runs,
                Hits = playerStatisticViewModel.Hits,
                Doubles = playerStatisticViewModel.Doubles,
                Triples = playerStatisticViewModel.Triples,
                HomeRuns = playerStatisticViewModel.HomeRuns,
                ImageUrl = playerStatisticViewModel.ImageUrl,
            };
            await this.playersStatistics.AddAsync(playerStatistic);
            await this.playersStatistics.SaveChangesAsync();
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
            IQueryable<BaseballStat.Data.Models.PlayerStatisticViewModel> query = this.playersStatistics
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
    }
}
