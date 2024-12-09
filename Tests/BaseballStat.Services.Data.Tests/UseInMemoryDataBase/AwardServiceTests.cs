namespace BaseballStat.Services.Data.Tests.UseInMempryDataBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Data.Award;
    using BaseballStat.Web.ViewModels.Award;
    using Moq;
    using Xunit;

    public class AwardServiceTests
    {
        [Fact]
        public async Task DeleteAwardAsync_ShouldDeleteAward()
        {
            // Arrange
            var mockRepo = new Mock<IDeletableEntityRepository<Award>>();
            var service = new AwardService(mockRepo.Object);
            var award = new Award { Id = 1 };
            mockRepo.Setup(r => r.All()).Returns(new List<Award> { award }.AsQueryable());

            // Act
            await service.DeleteAwardAsync(1);

            // Assert
            mockRepo.Verify(r => r.Delete(It.IsAny<Award>()), Times.Once);
            mockRepo.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task GetAllAwardAsync_ShouldReturnAllAwards()
        {
            // Arrange
            var mockRepo = new Mock<IDeletableEntityRepository<Award>>();
            var service = new AwardService(mockRepo.Object);
            var awards = new List<Award>
    {
        new Award
        {
            Id = 1,
            Description = "Most Valuable Player",
            Year = 2018,
            Winner = "Mookie Betts",
            ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732450272/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-al-mvp-award-won-by-mookie-betts-of-the-boston-red-sox_nr7drf.jpg",
            AwardTypeId = 1,
            CategoryId = 1,
            LeagueId = 1,
            TeamId = 1,
            CreatedOn = new DateTime(2024, 11, 25),
        },
        new Award
        {
            Id = 2,
            Description = "Best Rookie",
            Year = 2020,
            Winner = "Juan Soto",
            ImageUrl = "https://example.com/image2.jpg",
            AwardTypeId = 2,
            CategoryId = 2,
            LeagueId = 2,
            TeamId = 2,
            CreatedOn = new DateTime(2024, 11, 26),
        },
    };
            mockRepo.Setup(r => r.AllAsNoTracking()).Returns(awards.AsQueryable());

            // Act
            var result = await service.GetAllAwardAsync<Award>();

            // Assert
            Assert.Equal(2, result.Count());

            // Additional assertions for data correctness
            var firstAward = result.First();
            Assert.Equal(1, firstAward.Id);
            Assert.Equal("Most Valuable Player", firstAward.Description);
            Assert.Equal("Mookie Betts", firstAward.Winner);
        }

       /*  ToDO: Task<IEnumerable<T>> GetAllTimeGreatAsync<T>(int? count = null);

           TODO: Task<T> GetByIdAsync<T>(int id);
       */
    }
}
