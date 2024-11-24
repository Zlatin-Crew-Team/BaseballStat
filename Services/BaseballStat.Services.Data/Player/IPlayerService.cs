namespace BaseballStat.Services.Data.Player
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Web.ViewModels.Player;

    public interface IPlayerService
    {
        Task<IEnumerable<T>> GetAllPlayersAsync<T>(int? count = null);

        Task<T> GetByIdAsync<T>(int id);

        Task AddPlayerAsync(string firstName, string lastName, string position, string bats, string throws, int yearOfBirth, int teamId, string imageUrl);

        Task DeletePlayerAsync(int id);
    }
}
