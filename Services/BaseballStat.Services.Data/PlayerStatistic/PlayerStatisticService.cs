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

        public async Task AddPlayerStatistic(PlayerStatisticInputModel playerStatisticInputModel, string imageUrl)
        {
            // Добавяне на статистика
            var playerStatistic = new PlayerStatistic
            {
                PlayerId = playerStatisticInputModel.PlayerId,
                Games = playerStatisticInputModel.Games,
                AtBats = playerStatisticInputModel.AtBats,
                Runs = playerStatisticInputModel.Runs,
                Hits = playerStatisticInputModel.Hits,
                Doubles = playerStatisticInputModel.Doubles,
                Triples = playerStatisticInputModel.Triples,
                HomeRuns = playerStatisticInputModel.HomeRuns,
                ImageUrl = imageUrl,
            };

            await this.playersStatistics.AddAsync(playerStatistic);
            await this.playersStatistics.SaveChangesAsync();
        }

        public async Task DeletePlayerStatistic(int id)
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
            // Започваме с IQueryable<PlayerStatistic>, върнато от playersStatistics
            var query = this.playersStatistics
                .All() // Връща IQueryable<PlayerStatistic>
                .OrderBy(x => x.Id); // Сортиране по Id

            // Ограничаваме резултатите, ако count има стойност
            if (count.HasValue)
            {
                query = (IOrderedQueryable<PlayerStatistic>)query.Take(count.Value);
            }

            // Използваме .To<T>() за мапване към желания тип T (напр. PlayerStatisticViewModel)
            return await query.To<T>().ToListAsync();
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
