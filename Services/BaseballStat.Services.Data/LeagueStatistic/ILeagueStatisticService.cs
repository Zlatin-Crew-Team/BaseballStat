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

        Task<T> GetLeagueStatisticByIdAsync<T>(int id);
    }
}
