namespace BaseballStat.Services.Data.Tests.UseInMemoryDataBase
{
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;
    using BaseballStat.Services.Data.Player;
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
            };

            await this.DbContext.Players.AddAsync(player);
            await this.DbContext.SaveChangesAsync();

            // Act
            await this.playerService.DeletePlayerAsync(player.Id);

            var deletedPlayer = await this.DbContext.Players.FindAsync(player.Id);

            // Assert
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

        [Fact]
        public async Task GetAllPlayersAsync_ShouldReturnAllPlayers()
        {
            // Arrange
            var player1 = new Player
            {
                FirstName = "John",
                LastName = "Doe",
                Position = "P",
                Bats = "R",
                Throws = "R",
                YearOfBirth = 1990,
                TeamId = 1,
                ImageUrl = "imageUrl",
            };

            var player2 = new Player
            {
                FirstName = "Jane",
                LastName = "Doe",
                Position = "C",
                Bats = "L",
                Throws = "L",
                YearOfBirth = 1992,
                TeamId = 2,
                ImageUrl = "imageUrl",
            };

            await this.DbContext.Players.AddRangeAsync(player1, player2);
            await this.DbContext.SaveChangesAsync();

            // Act
            var players = await this.playerService.GetAllPlayersAsync<Player>();

            // Assert
            Assert.Equal(2, players.Count());
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnPlayer()
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
            };

            await this.DbContext.Players.AddAsync(player);
            await this.DbContext.SaveChangesAsync();

            // Act
            var retrievedPlayer = await this.playerService.GetByIdAsync<Player>(player.Id);

            // Assert
            Assert.NotNull(retrievedPlayer);
            Assert.Equal(player.FirstName, retrievedPlayer.FirstName);
            Assert.Equal(player.LastName, retrievedPlayer.LastName);
        }
    }
}
