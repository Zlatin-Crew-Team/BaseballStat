namespace BaseballStat.Services.Data.PlayerStattistic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Web.ViewModels.PlayerStatistic;

    public interface IPlayerStatisticService
    {
        Task<T> GetByIdAsync<T>(int id);

        Task<IEnumerable<T>> GetAllPlayerStatisticsAsync<T>(int? count = null);

        Task AddPlayerStatisticAsync(PlayerStatisticViewModel playerStatisticViewModel);

        Task DeletePlayerStatisticAsync(int id);
    }
}
