namespace BaseballStat.Services.Data.TeamStatistic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ITeamStatisticService
    {
        Task DeleteTeamStatisticAsync(int id);

        Task<T> GetTeamStatisticByIdAsync<T>(int id);

        Task<IEnumerable<T>> GetAllTeamStatisticsAsync<T>(int? count = null);

        Task AddTeamStatisticAsync(int teamId, int games, int wins, int losses, int titles);
    }
}
