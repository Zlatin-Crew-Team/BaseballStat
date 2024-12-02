namespace BaseballStat.Services.Data.Award
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Models;
    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;
    using BaseballStat.Web.ViewModels.Award;
    using Microsoft.EntityFrameworkCore;

    public class AwardService : IAwardService
    {
        private readonly IDeletableEntityRepository<Award> awardRepository;

        public AwardService(IDeletableEntityRepository<Award> awardRepository)
        {
            this.awardRepository = awardRepository;
        }

        public async Task AddAwardAsync(AwardInputModel awardInputModel, string imageUrl)
        {
            await this.awardRepository.AddAsync(new Award
            {
                Description = awardInputModel.Description,
                Year = awardInputModel.Year,
                Winner = awardInputModel.Winner,
                ImageUrl = imageUrl,
                AwardTypeId = int.Parse(awardInputModel.AwardTypeId), // Fix: Convert string to int
                CategoryId = int.Parse(awardInputModel.CategoryId), // Fix: Convert string to int
                TeamId = int.Parse(awardInputModel.TeamId), // Fix: Convert string to int
                LeagueId = int.Parse(awardInputModel.LeagueId), // Fix: Convert string to int
            });

            await this.awardRepository.SaveChangesAsync();
        }

        public async Task DeleteAwardAsync(int id)
        {
            var awards = this.awardRepository
                .All()
                .FirstOrDefault(x => x.Id == id);
            this.awardRepository.Delete(awards);
            await this.awardRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAwardAsync<T>(int? count = null)
        {
            IQueryable<Award> query = this.awardRepository
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
            var award = this.awardRepository
                .All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefaultAsync();
            return await award;
        }
    }
}
