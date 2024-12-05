namespace BaseballStat.Services.Data.League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ILeagueService
    {
        Task<T> GetByIdAsync<T>(int id);

        Task<IEnumerable<T>> GetAllLeaguesAsync<T>(int? count = null);

        Task<int> AddAsync(string name, string imageUrl);

        Task DeleteAsync(int id);

        Task<bool> ExistsAsync(int id);
    }
}
