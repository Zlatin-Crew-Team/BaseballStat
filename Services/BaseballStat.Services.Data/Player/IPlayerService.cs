namespace BaseballStat.Services.Data.Player
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPlayerService
    {
        Task<IEnumerable<T>> GetAllPlayersAsync<T>();

        Task<T> GetByIdAsync<T>(int id);

        Task AddPlayerAsync(string firstname, string lastname, string position);

        Task DeletePlayerAsync(int id);
    }
}
