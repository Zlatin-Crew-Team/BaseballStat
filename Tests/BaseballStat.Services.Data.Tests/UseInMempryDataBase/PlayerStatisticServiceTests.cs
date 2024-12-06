namespace BaseballStat.Services.Data.Tests.UseInMemoryDataBase
{
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;
    using BaseballStat.Services.Data.PlayerStattistic;
    using BaseballStat.Web.ViewModels.PlayerStatistic;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class PlayerStatisticServiceTests : BaseServiceTests
    {
        private readonly IPlayerStatisticService playerStatisticService;

        public PlayerStatisticServiceTests()
        {
            this.playerStatisticService = this.ServiceProvider.GetRequiredService<IPlayerStatisticService>();
        }

        [Fact]
        public async Task AddPlayerStatistic_ShouldAddStatistic()
        {
            // Arrange
            var inputModel = new PlayerStatisticInputModel
            {
                PlayerId = 1,
                Games = 100,
                AtBats = 300,
                Runs = 50,
                Hits = 120,
                Doubles = 30,
                Triples = 5,
                HomeRuns = 10,
            };

            var imageUrl = "https://example.com/image.jpg";

            // Act
            await this.playerStatisticService.AddPlayerStatistic(inputModel, imageUrl);

            var playerStatistic = await this.DbContext.PlayerStatistics.FirstOrDefaultAsync();

            // Assert
            Assert.NotNull(playerStatistic);
            Assert.Equal(inputModel.PlayerId, playerStatistic.PlayerId);
            Assert.Equal(inputModel.Games, playerStatistic.Games);
            Assert.Equal(imageUrl, playerStatistic.ImageUrl);
        }

        [Fact]
        public async Task DeletePlayerStatistic_ShouldDeleteStatistic()
        {
            // Arrange
            var statistic = new PlayerStatistic
            {
                PlayerId = 1,
                Games = 100,
                AtBats = 300,
                Runs = 50,
                Hits = 120,
                Doubles = 30,
                Triples = 5,
                HomeRuns = 10,
                ImageUrl = "https://example.com/image.jpg",
            };

            await this.DbContext.PlayerStatistics.AddAsync(statistic);
            await this.DbContext.SaveChangesAsync();

            // Act
            await this.playerStatisticService.DeletePlayerStatistic(statistic.Id);

            var deletedStatistic = await this.DbContext.PlayerStatistics.FindAsync(statistic.Id);

            // Assert
            Assert.Null(deletedStatistic);
        }

        [Fact]
        public async Task GetAllPlayerStatisticsAsync_ShouldReturnAllStatistics()
        {
            // Arrange
            var statistic1 = new PlayerStatistic
            {
                PlayerId = 1,
                Games = 100,
                AtBats = 300,
                Runs = 50,
                Hits = 120,
                Doubles = 30,
                Triples = 5,
                HomeRuns = 10,
                ImageUrl = "https://example.com/image1.jpg",
            };

            var statistic2 = new PlayerStatistic
            {
                PlayerId = 2,
                Games = 150,
                AtBats = 400,
                Runs = 60,
                Hits = 140,
                Doubles = 40,
                Triples = 6,
                HomeRuns = 20,
                ImageUrl = "https://example.com/image2.jpg",
            };

            await this.DbContext.PlayerStatistics.AddRangeAsync(statistic1, statistic2);
            await this.DbContext.SaveChangesAsync();

            // Act
            var statistics = await this.playerStatisticService.GetAllPlayerStatisticsAsync<PlayerStatistic>();

            // Assert
            Assert.Equal(2, statistics.Count());
        }

        [Fact]
        public async Task GetPlayerStatisticByIdAsync_ShouldReturnCorrectStatistic()
        {
            // Arrange
            var statistic = new PlayerStatistic
            {
                PlayerId = 1,
                Games = 100,
                AtBats = 300,
                Runs = 50,
                Hits = 120,
                Doubles = 30,
                Triples = 5,
                HomeRuns = 10,
                ImageUrl = "https://example.com/image.jpg",
            };

            await this.DbContext.PlayerStatistics.AddAsync(statistic);
            await this.DbContext.SaveChangesAsync();

            // Act
            var retrievedStatistic = await this.playerStatisticService.GetPlayerStatisticByIdAsync<PlayerStatistic>(statistic.Id);

            // Assert
            Assert.NotNull(retrievedStatistic);
            Assert.Equal(statistic.PlayerId, retrievedStatistic.PlayerId);
            Assert.Equal(statistic.Games, retrievedStatistic.Games);
        }
    }
}