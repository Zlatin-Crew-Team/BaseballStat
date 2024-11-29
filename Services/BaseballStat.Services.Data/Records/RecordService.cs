namespace BaseballStat.Services.Data.Records
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class RecordService : IRecordService
    {
        private readonly IDeletableEntityRepository<Record> recordsRepository;

        public RecordService(IDeletableEntityRepository<Record> recordsRepository)
        {
            this.recordsRepository = recordsRepository;
        }

        public async Task<IEnumerable<T>> GetAllRecordsAsync<T>(int? count = null)
        {
            IQueryable<Record> query = this.recordsRepository
                .All()
                .OrderBy(x => x.Id);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return await query.To<T>().ToListAsync();
        }

        public Task<T> GetRecordByIdAsync<T>(int id)
        {
            var record = this.recordsRepository
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefaultAsync();
            return record;
        }
    }
}
