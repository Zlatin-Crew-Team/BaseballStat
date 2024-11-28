namespace BaseballStat.Services.Data.Award
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAwardService
    {
        Task<IEnumerable<T>> GetAllAwardAsync<T>(int? count = null);

        Task<T> GetByIdAsync<T>(int id);
    }
}
