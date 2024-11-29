namespace BaseballStat.Services.Data.Records
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IRecordService
    {
        Task<IEnumerable<T>> GetAllRecordsAsync<T>(int? count = null);

        Task<T> GetRecordByIdAsync<T>(int id);
    }
}
