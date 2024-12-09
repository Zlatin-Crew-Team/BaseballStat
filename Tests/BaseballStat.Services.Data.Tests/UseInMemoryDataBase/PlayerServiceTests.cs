namespace BaseballStat.Services.Data.Tests.UseInMemoryDataBase
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;
    using BaseballStat.Services.Data.Player;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class PlayerServiceTests : BaseServiceTests
    {
        private readonly IPlayerService playerService;

        public PlayerServiceTests()
        {
            this.playerService = this.ServiceProvider.GetRequiredService<IPlayerService>();
        }

        [Fact]
        public async Task AddPlayerAsync_ShouldAddPlayer()
        {
            // Act
            var playerId = await this.playerService.AddPlayerAsync(
                "John", "Doe", "P", "R", "R", 1990, 1, "imageUrl");

            var player = await this.DbContext.Players.FindAsync(playerId);

            // Assert
            Assert.NotNull(player);
            Assert.Equal("John", player.FirstName);
            Assert.Equal("Doe", player.LastName);
        }

        [Fact]
        public async Task DeletePlayerAsync_ShouldDeletePlayer()
        {
            // Arrange
            var player = new Player
            {
                FirstName = "John",
                LastName = "Doe",
                Position = "P",
                Bats = "R",
                Throws = "R",
                YearOfBirth = 1990,
                TeamId = 1,
                ImageUrl = "imageUrl",
                IsProtected = false,
            };

            await this.DbContext.Players.AddAsync(player);
            await this.DbContext.SaveChangesAsync();

            // Act
            await this.playerService.DeletePlayerAsync(player.Id);

            // Assert
            var deletedPlayer = await this.DbContext.Players
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync(x => x.Id == player.Id);

            Assert.Null(deletedPlayer);
        }

        [Fact]
        public async Task ExistsAsync_ShouldReturnTrueIfPlayerExists()
        {
            // Arrange
            var player = new Player
            {
                FirstName = "Jane",
                LastName = "Smith",
                Position = "C",
                Bats = "L",
                Throws = "L",
                YearOfBirth = 1988,
                TeamId = 2,
                ImageUrl = "imageUrl",
            };

            await this.DbContext.Players.AddAsync(player);
            await this.DbContext.SaveChangesAsync();

            // Act
            var exists = await this.playerService.ExistsAsync(player.Id);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public async Task ExistsAsync_ShouldReturnFalseIfPlayerDoesNotExist()
        {
            // Act
            var exists = await this.playerService.ExistsAsync(999);

            // Assert
            Assert.False(exists);
        }

        /*
          TODO: Task<IEnumerable<T>> GetAllPlayersAsync<T>(int? count = null);

          TODO: Task<T> GetByIdAsync<T>(int id);
        */
    }
}
