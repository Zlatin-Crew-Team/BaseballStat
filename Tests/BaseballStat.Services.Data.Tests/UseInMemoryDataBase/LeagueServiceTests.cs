namespace BaseballStat.Services.Data.Tests.UseInMemoryDataBase
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Data.League;
    using Moq;
    using Xunit;

    public class LeagueServiceTests
    {
        private readonly Mock<IDeletableEntity<League>> mockRepo;
        private readonly LeagueService leagueService;

        public LeagueServiceTests()
        {
            this.mockRepo = new Mock<IDeletableEntity<League>>();
            this.leagueService = new LeagueService(this.mockRepo.Object);
        }

        [Fact]
        public async Task AddAsync_ShouldAddLeague()
        {
            // Arrange
            var name = "Test League";
            var imageUrl = "http://test.com/image.jpg";

            // Act
            var result = await this.leagueService.AddAsync(name, imageUrl);

            // Assert
            this.mockRepo.Verify(x => x.AddAsync(It.Is<League>(l => l.Name == name && l.ImageUrl == imageUrl)), Times.Once);
            this.mockRepo.Verify(x => x.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task DeleteAsync_ShouldDeleteLeague()
        {
            // Arrange
            var league = new League { Id = 1 };
            this.mockRepo.Setup(x => x.All()).Returns(new List<League> { league }.AsQueryable());

            // Act
            await this.leagueService.DeleteAsync(1);

            // Assert
            this.mockRepo.Verify(x => x.Delete(It.Is<League>(l => l.Id == 1)), Times.Once);
            this.mockRepo.Verify(x => x.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task ExistsAsync_ShouldReturnTrueIfExists()
        {
            // Arrange
            var league = new League { Id = 1 };
            this.mockRepo.Setup(x => x.AllAsNoTracking())
                .Returns(new List<League> { league }.AsQueryable());

            // Act
            var result = await this.leagueService.ExistsAsync(1);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task ExistsAsync_ShouldReturnFalseIfNotExists()
        {
            // Arrange
            this.mockRepo.Setup(x => x.AllAsNoTracking())
                .Returns(new List<League>().AsQueryable());

            // Act
            var result = await this.leagueService.ExistsAsync(1);

            // Assert
            Assert.False(result);
        }

        /*  TODO: Task<T> GetByIdAsync<T>(int id);

          TODO: Task<IEnumerable<T>> GetAllLeaguesAsync<T>(int? count = null);
        */
    }
}
