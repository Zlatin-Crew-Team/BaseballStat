namespace BaseballStat.Services.Data.Tests.UseInMempryDataBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Data.TeamStatistic;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Xunit;

    public class TeamStatisticServiceTests
    {
        private readonly Mock<IDeletableEntityRepository<TeamStatistic>> mockRepo;
        private readonly TeamStatisticService service;

        public TeamStatisticServiceTests()
        {
            this.mockRepo = new Mock<IDeletableEntityRepository<TeamStatistic>>();
            this.service = new TeamStatisticService(this.mockRepo.Object);
        }

        [Fact]
        public async Task AddTeamStatisticAsync_ShouldAddTeamStatistic()
        {
            // Arrange
            var teamStatistic = new TeamStatistic
            {
                TeamId = 1,
                Games = 100,
                Wins = 60,
                Losses = 40,
                Titles = 2,
            };

            // Act
            await this.service.AddTeamStatisticAsync(teamStatistic.TeamId, teamStatistic.Games, teamStatistic.Wins, teamStatistic.Losses, teamStatistic.Titles);

            // Assert
            this.mockRepo.Verify(r => r.AddAsync(It.IsAny<TeamStatistic>()), Times.Once);
            this.mockRepo.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task DeleteTeamStatisticAsync_ShouldDeleteTeamStatistic()
        {
            // Arrange
            var teamStatistic = new TeamStatistic { Id = 1 };
            this.mockRepo.Setup(r => r.All()).Returns(new List<TeamStatistic> { teamStatistic }.AsQueryable());

            // Act
            await this.service.DeleteTeamStatisticAsync(teamStatistic.Id);

            // Assert
            this.mockRepo.Verify(r => r.Delete(It.IsAny<TeamStatistic>()), Times.Once);
            this.mockRepo.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        /*
         TODO:  Task<T> GetTeamStatisticByIdAsync<T>(int id);

         TODO:  Task<IEnumerable<T>> GetAllTeamStatisticsAsync<T>(int? count = null);
        */
    }
}
