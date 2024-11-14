namespace BaseballStat.Services.Data.TeamStatistic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ITeamStatisticService
    {
        Task<IEnumerable<T>> GetAllTeamStatisticsAsync<T>(int? count = null);

        Task<T> GetTeamStatisticByIdAsync<T>(int id);

        Task DeleteTeamStatisticAsync(int id);

        Task<T> GetByIdAsync<T>(int id);
    }
}
