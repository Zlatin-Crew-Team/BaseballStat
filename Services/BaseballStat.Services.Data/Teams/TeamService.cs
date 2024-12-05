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

        public async Task<int> AddAsync(string name, string city, string foundedYear, string logoUrl, string owner, string stadium, int leagueId)
        {
            var team = new Team
            {
                Name = name,
                City = city,
                FoundedYear = foundedYear.ToString(), // Convert int to string
                LogoUrl = logoUrl,
                Owner = owner,
                Stadium = stadium,
                LeagueId = leagueId, // Corrected property assignment
            };
            await this.teamsRepository.AddAsync(team);
            await this.teamsRepository.SaveChangesAsync();

            return team.Id;
        }

        public async Task DeleteTeamAsync(int id)
        {
            var team =
                this.teamsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefault();
            if (team == null || team.IsProtectedTeam)
            {
                throw new InvalidOperationException("Cannot delete this team.");
            }

            this.teamsRepository.Delete(team);
            await this.teamsRepository.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await this.teamsRepository
         .AllAsNoTracking()
         .AnyAsync(x => x.Id == id);
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
                .FirstOrDefaultAsync();

            if (team == null)
            {
                throw new InvalidOperationException("Team not found.");
            }

            return await team;
        }
    }
}
