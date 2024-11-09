namespace BaseballStat.Services.Data.Teams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class TeamService : ITeamService
    {
        private readonly IDeletableEntityRepository<Team> teamsRepository;

        public TeamService(IDeletableEntityRepository<Team> teamsRepository)
        {
            this.teamsRepository = teamsRepository;
        }

        public async Task AddAsync(string name, string city, string foudededYear, string logoUrl, string owner, string stadium)
        {
            await this.teamsRepository.AddAsync(new Team
            {
                Name = name,
                City = city,
                FoundedYear = foudededYear,
                LogoUrl = logoUrl,
                Owner = owner,
                Stadium = stadium,
            });
            await this.teamsRepository.SaveChangesAsync();
        }

        public async Task DeleteTeamAsync(int id)
        {
            var team =
                this.teamsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefault();
            this.teamsRepository.Delete(team);
            await this.teamsRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllTeamsAsync<T>(int? count = null)
        {
            IQueryable<Team> query = this.teamsRepository
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
            var team = this.teamsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
            return await Task.FromResult(team);
        }
    }
}
