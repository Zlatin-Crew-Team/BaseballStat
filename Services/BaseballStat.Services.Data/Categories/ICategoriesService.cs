namespace BaseballStat.Services.Data.Categories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICategoriesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);

        Task<T> GetByIdAsync<T>(int id);

        Task AddAsync(string name, string description, string imageUrl);

        Task DeleteAsync(int id);
    }
}
