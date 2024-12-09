namespace BaseballStat.Services.Data.Tests.UseInMempryDataBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Data.Teams;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Xunit;

    public class TeamServiceTests
    {
        private readonly Mock<IDeletableEntityRepository<Team>> teamsRepositoryMock;
        private readonly TeamService teamService;

        public TeamServiceTests()
        {
            this.teamsRepositoryMock = new Mock<IDeletableEntityRepository<Team>>();
            this.teamService = new TeamService(this.teamsRepositoryMock.Object);
        }

        [Fact]
        public async Task AddAsync_ShouldAddTeam()
        {
            // Arrange
            var team = new Team
            {
                Id = 1,
                Name = "Team A",
                City = "City A",
                FoundedYear = "2000",
                LogoUrl = "http://logo.url",
                Owner = "Owner A",
                Stadium = "Stadium A",
                LeagueId = 1,
            };

            this.teamsRepositoryMock.Setup(r => r.AddAsync(It.IsAny<Team>())).Returns(Task.CompletedTask);
            this.teamsRepositoryMock.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1);

            // Act
            var result = await this.teamService.AddAsync(team.Name, team.City, team.FoundedYear, team.LogoUrl, team.Owner, team.Stadium, team.LeagueId);

            // Assert
            Assert.Equal(team.Id, result);
            this.teamsRepositoryMock.Verify(r => r.AddAsync(It.IsAny<Team>()), Times.Once);
            this.teamsRepositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task DeleteTeamAsync_ShouldDeleteTeam()
        {
            // Arrange
            var team = new Team
            {
                Id = 1,
                IsProtectedTeam = false,
            };

            this.teamsRepositoryMock.Setup(r => r.AllAsNoTracking()).Returns(new List<Team> { team }.AsQueryable());
            this.teamsRepositoryMock.Setup(r => r.Delete(It.IsAny<Team>()));
            this.teamsRepositoryMock.Setup(r => r.SaveChangesAsync()).ReturnsAsync(1);

            // Act
            await this.teamService.DeleteTeamAsync(team.Id);

            // Assert
            this.teamsRepositoryMock.Verify(r => r.Delete(It.IsAny<Team>()), Times.Once);
            this.teamsRepositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Fact]
        public async Task DeleteTeamAsync_ShouldThrowException_WhenTeamIsProtected()
        {
            // Arrange
            var team = new Team
            {
                Id = 1,
                IsProtectedTeam = true,
            };

            this.teamsRepositoryMock.Setup(r => r.AllAsNoTracking()).Returns(new List<Team> { team }.AsQueryable());

            // Act & Assert
            await Assert.ThrowsAsync<InvalidOperationException>(() => this.teamService.DeleteTeamAsync(team.Id));
        }

        [Fact]
        public async Task ExistsAsync_ShouldReturnTrue_WhenTeamExists()
        {
            // Arrange
            var team = new Team
            {
                Id = 1,
            };

            this.teamsRepositoryMock.Setup(r => r.AllAsNoTracking()).Returns(new List<Team> { team }.AsQueryable());

            // Act
            var result = await this.teamService.ExistsAsync(team.Id);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task ExistsAsync_ShouldReturnFalse_WhenTeamDoesNotExist()
        {
            // Arrange
            this.teamsRepositoryMock.Setup(r => r.AllAsNoTracking()).Returns(new List<Team>().AsQueryable());

            // Act
            var result = await this.teamService.ExistsAsync(1);

            // Assert
            Assert.False(result);
        }

        /*
         TODO : Task<IEnumerable<T>> GetAllTeamsAsync<T>(int? count = null);

        TODO:   Task<T> GetByIdAsync<T>(int id);
        */
    }
}
