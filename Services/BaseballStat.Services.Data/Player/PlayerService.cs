namespace BaseballStat.Services.Data.Player
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class PlayerService : IPlayerService
    {
        private readonly IDeletableEntityRepository<Player> playersRepository;

        public PlayerService(IDeletableEntityRepository<Player> playersRepository)
        {
            this.playersRepository = playersRepository;
        }

        public async Task AddPlayerAsync(string firstName, string lastName, string position, string bats, string throws, int yearOfBirth, int teamId, string imageUrl)
        {
            await this.playersRepository.AddAsync(new Player
            {
                FirstName = firstName,
                LastName = lastName,
                Position = position,
                Bats = bats,
                Throws = throws,
                YearOfBirth = yearOfBirth,
                TeamId = teamId,
                ImageUrl = imageUrl,
            });
            await this.playersRepository.SaveChangesAsync();
        }

        public async Task DeletePlayerAsync(int id)
        {
            var player =
                this.playersRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefault();
            this.playersRepository.Delete(player);
            await this.playersRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllPlayersAsync<T>(int? count = null)
        {
            IQueryable<Player> query = this.playersRepository
                .All()
                .OrderBy(x => x.Id);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return await query.To<T>().ToListAsync();
        }

        public Task<T> GetByIdAsync<T>(int id)
        {
            var player = this.playersRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
            return Task.FromResult(player);
        }

        public Task GetPlayerStatisticByIdAsync(int id)
        {
            var player = this.playersRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefault();
            return Task.CompletedTask;
        }
    }
}
