namespace BaseballStat.Services.Data.AllTimeGreat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAllTimeGreatService
    {
        Task<IEnumerable<T>> GetAllTimeGreatAsync<T>(int? count = null);

        Task<T> GetByIdAsync<T>(int id);

        Task AddAllTimeGreat(int id, string name, string bio, string imageUrl, int categoryId);

        Task DeleteAllTimeGreatAsync(int id);
    }
}
