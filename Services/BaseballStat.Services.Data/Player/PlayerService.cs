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
        private DbSet<Player> players;

        public PlayerService(IDeletableEntityRepository<Player> playersRepository)
        {
            this.playersRepository = playersRepository;
        }

        public PlayerService(DbSet<Player> players)
        {
            this.players = players;
        }

        public async Task<int> AddPlayerAsync(string firstName, string lastName, string position, string bats, string throws, int yearOfBirth, int teamId, string imageUrl)
        {
            var player = new Player
            {
                FirstName = firstName,
                LastName = lastName,
                Position = position,
                Bats = bats,
                Throws = throws,
                YearOfBirth = yearOfBirth,
                TeamId = teamId,
                ImageUrl = imageUrl,
            };

            await this.playersRepository.AddAsync(player);
            await this.playersRepository.SaveChangesAsync();

            return player.Id; // Връщаме идентификатора на новия играч
        }

        public async Task DeletePlayerAsync(int id)
        {
            var player = this.playersRepository
                .All()
                .FirstOrDefault(x => x.Id == id);

            if (player == null || player.IsProtected) // Проверка дали е защитен
            {
                throw new InvalidOperationException("Cannot delete this player.");
            }

            this.playersRepository.Delete(player);
            await this.playersRepository.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await this.playersRepository
         .AllAsNoTracking()
         .AnyAsync(x => x.Id == id);
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

        public async Task<T> GetByIdAsync<T>(int id)
        {
            var player = await this.playersRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefaultAsync();

            if (player == null)
            {
                throw new InvalidOperationException("Player not found.");
            }

            return player;
        }
    }
}
