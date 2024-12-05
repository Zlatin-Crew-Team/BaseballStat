namespace BaseballStat.Services.Data.LeagueStatistic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ILeagueStatisticService
    {
        Task<T> GetByIdAsync<T>(int id);

        Task<IEnumerable<T>> GetAllLeagueStatisticsAsync<T>(int? count = null);

        Task AddLeagueStatisticAsync(int leagueId, int games, int wins, int losses, int titles);

        Task DeleteLeagueStatisticAsync(int id);
    }
}
