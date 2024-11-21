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

        public async Task AddAsync(string name, string city, string foundedYear, string logoUrl, string owner, string stadium, int leagueId)
        {
            await this.teamsRepository.AddAsync(new Team
            {
                Name = name,
                City = city,
                FoundedYear = foundedYear.ToString(), // Convert int to string
                LogoUrl = logoUrl,
                Owner = owner,
                Stadium = stadium,
                LeagueId = leagueId, // Corrected property assignment
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

        public async Task UpdateTeamAsync(int id, string name, string city, int foundedYear, string logoUrl, string owner, string stadium)
        {
            var team = await this.teamsRepository.All().FirstOrDefaultAsync(x => x.Id == id);
            if (team != null)
            {
                team.Name = name;
                team.City = city;
                team.FoundedYear = foundedYear.ToString(); // Convert int to string
                team.LogoUrl = logoUrl;
                team.Owner = owner;
                team.Stadium = stadium;

                this.teamsRepository.Update(team);
                await this.teamsRepository.SaveChangesAsync();
            }
        }

        public Task UpdateTeamAsync(int id, string name, string city, string foundedYear, string logoUrl, string owner, string stadium)
        {
            throw new NotImplementedException();
        }
    }
}
