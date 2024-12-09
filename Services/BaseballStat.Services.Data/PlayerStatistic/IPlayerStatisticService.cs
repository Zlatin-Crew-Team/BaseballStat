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
        Task<IEnumerable<T>> GetAllPlayerStatisticsAsync<T>(int? count = null);

        Task<T> GetPlayerStatisticByIdAsync<T>(int id);

        Task DeletePlayerStatistic(int id);

        Task AddPlayerStatistic(PlayerStatisticInputModel playerStatisticInputModel, string imageUrl);
    }
}
