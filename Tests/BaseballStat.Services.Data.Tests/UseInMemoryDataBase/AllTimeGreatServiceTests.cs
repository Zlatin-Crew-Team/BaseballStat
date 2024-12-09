namespace BaseballStat.Services.Data.Tests.UseInMemoryDataBase
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Data.AllTimeGreat;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Xunit;

    public class AllTimeGreatServiceTests
    {
        private readonly Mock<IDeletableEntity<AllTimeGreat>> mockRepo;
        private readonly AllTimeGreatService service;

        public AllTimeGreatServiceTests()
        {
            this.mockRepo = new Mock<IDeletableEntity<AllTimeGreat>>();
            this.service = new AllTimeGreatService(this.mockRepo.Object);
        }

        [Fact]
        public async Task AddAllTimeGreat_ShouldAddAllTimeGreat()
        {
            // Arrange
            var allTimeGreat = new AllTimeGreat
            {
                Id = 1,
                Name = "Babe Ruth",
                Bio = "Legendary baseball player",
                ImageUrl = "http://example.com/babe.jpg",
                CategoryId = 2,
            };

            // Act
            await this.service.AddAllTimeGreat(allTimeGreat.Id, allTimeGreat.Name, allTimeGreat.Bio, allTimeGreat.ImageUrl, allTimeGreat.CategoryId);

            // Assert
            this.mockRepo.Verify(r => r.AddAsync(It.Is<AllTimeGreat>(g => g.Name == allTimeGreat.Name && g.Bio == allTimeGreat.Bio && g.ImageUrl == allTimeGreat.ImageUrl && g.CategoryId == allTimeGreat.CategoryId)), Times.Once);
            this.mockRepo.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task DeleteAllTimeGreat_ShouldDeleteAllTimeGreat()
        {
            // Arrange
            var allTimeGreat = new AllTimeGreat { Id = 1, Name = "Babe Ruth" };
            this.mockRepo.Setup(r => r.AllAsNoTracking()).Returns(new List<AllTimeGreat> { allTimeGreat }.AsQueryable());

            // Act
            await this.service.DeleteAllTimeGreat(allTimeGreat.Id);

            // Assert
            this.mockRepo.Verify(r => r.Delete(It.Is<AllTimeGreat>(g => g.Id == allTimeGreat.Id)), Times.Once);
            this.mockRepo.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        /*
          ToDO: Task<IEnumerable<T>> GetAllTimeGreatAsync<T>(int? count = null);

          TODO:  Task<T> GetByIdAsync<T>(int id);
        */
    }
}
