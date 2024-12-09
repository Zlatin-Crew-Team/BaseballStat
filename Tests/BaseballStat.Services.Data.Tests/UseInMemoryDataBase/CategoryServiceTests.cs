namespace BaseballStat.Services.Data.Tests.UseInMempryDataBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Data.Categories;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Xunit;

    public class CategoryServiceTests
    {
        [Fact]
        public async Task AddAsync_ShouldAddCategory()
        {
            // Arrange
            var mockRepo = new Mock<IDeletableEntityRepository<Category>>();
            var service = new CategoriesService(mockRepo.Object);

            // Act
            await service.AddAsync("Test Category", "Test Description", "TestImageUrl");

            // Assert
            mockRepo.Verify(r => r.AddAsync(It.IsAny<Category>()), Times.Once);
            mockRepo.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task DeleteAsync_ShouldDeleteCategory()
        {
            // Arrange
            var category = new Category { Id = 1, Name = "Test Category" };
            var mockRepo = new Mock<IDeletableEntityRepository<Category>>();
            mockRepo.Setup(r => r.AllAsNoTracking()).Returns(new List<Category> { category }.AsQueryable());
            var service = new CategoriesService(mockRepo.Object);

            // Act
            await service.DeleteAsync(1);

            // Assert
            mockRepo.Verify(r => r.Delete(It.IsAny<Category>()), Times.Once);
            mockRepo.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        /*
          TODO: Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);

          TODO:  Task<T> GetByIdAsync<T>(int id);
        */
    }
}
