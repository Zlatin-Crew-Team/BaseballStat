namespace BaseballStat.Services.Data.Teams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ITeamService
    {
        Task<IEnumerable<T>> GetAllTeamsAsync<T>(int? count = null);

        Task<T> GetByIdAsync<T>(int id);

        Task AddAsync(string name, string city, string foudededYear, string logoUrl, string owner, string stadium);

        Task DeleteTeamAsync(int id);
    }
}
