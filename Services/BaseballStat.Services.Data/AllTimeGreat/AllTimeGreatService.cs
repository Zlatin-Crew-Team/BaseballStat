namespace BaseballStat.Services.Data.AllTimeGreat
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class AllTimeGreatService : IAllTimeGreatService
    {
        private readonly IDeletableEntity<AllTimeGreat> allTimeGreatRepository;

        public AllTimeGreatService(IDeletableEntity<AllTimeGreat> allTimeGreatRepository)
        {
            this.allTimeGreatRepository = allTimeGreatRepository;
        }

        public async Task AddAllTimeGreat(int id, string name, string bio, string imageUrl, int categoryId)
        {
            await this.allTimeGreatRepository.AddAsync(new AllTimeGreat
            {
                Name = name,
                Bio = bio,
                ImageUrl = imageUrl,
                CategoryId = id,
            });
            await this.allTimeGreatRepository.SaveChangesAsync();
        }

        public async Task DeleteAllTimeGreatAsync(int id)
        {
            var allTimeGreat =
                this.allTimeGreatRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefault();
            this.allTimeGreatRepository.Delete(allTimeGreat);
            await this.allTimeGreatRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllTimeGreatAsync<T>(int? count = null)
        {
            IQueryable<AllTimeGreat> query = this.allTimeGreatRepository
               .All()
               .OrderBy(x => x.Id);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return await query.To<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync<T>(int id)
        {
            var allTimeGreat = this.allTimeGreatRepository
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefaultAsync();
            return await allTimeGreat;
        }
    }
}
