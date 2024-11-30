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

        public async Task AddRecord(int id, string holder, string description, string imageUrl, int categoryId, int recordTypeId)
        {
            await this.recordsRepository.AddAsync(new Record
                {
                    Holder = holder,
                    Description = description,
                    ImageUrl = imageUrl,
                    CategoryId = id,
                    RecordTypeId = id,
                });
            await this.recordsRepository.SaveChangesAsync();
        }

        public async Task DeleteRecordAsync(int id)
        {
            var record =
                this.recordsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefault();
            this.recordsRepository.Delete(record);
            await this.recordsRepository.SaveChangesAsync();
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
