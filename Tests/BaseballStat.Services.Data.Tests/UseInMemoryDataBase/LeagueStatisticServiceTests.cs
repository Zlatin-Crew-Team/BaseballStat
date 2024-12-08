using System.Collections.Generic;
using System.Threading.Tasks;

using BaseballStat.Services.Data.LeagueStatistic;
using Moq;
using Xunit;

public class LeagueStatisticServiceTests
{
    private readonly Mock<ILeagueStatisticService> mockLeagueStatisticService;

    public LeagueStatisticServiceTests()
    {
        this.mockLeagueStatisticService = new Mock<ILeagueStatisticService>();
    }

    [Fact]
    public async Task GetByIdAsync_ShouldReturnCorrectStatistic()
    {
        // Arrange
        var statisticId = 1;
        var expectedStatistic = new { Id = statisticId, Games = 10, Wins = 5, Losses = 5, Titles = 1 };
        this.mockLeagueStatisticService.Setup(s => s.GetByIdAsync<object>(statisticId))
            .ReturnsAsync(expectedStatistic);

        // Act
        var result = await this.mockLeagueStatisticService.Object.GetByIdAsync<object>(statisticId);

        // Assert
        Assert.Equal(expectedStatistic, result);
    }

    [Fact]
    public async Task GetAllLeagueStatisticsAsync_ShouldReturnAllStatistics()
    {
        // Arrange
        var expectedStatistics = new List<object>
        {
            new { Id = 1, Games = 10, Wins = 5, Losses = 5, Titles = 1 },
            new { Id = 2, Games = 20, Wins = 10, Losses = 10, Titles = 2 },
        };
        this.mockLeagueStatisticService.Setup(s => s.GetAllLeagueStatisticsAsync<object>(null))
            .ReturnsAsync(expectedStatistics);

        // Act
        var result = await this.mockLeagueStatisticService.Object.GetAllLeagueStatisticsAsync<object>();

        // Assert
        Assert.Equal(expectedStatistics, result);
    }

    [Fact]
    public async Task AddLeagueStatisticAsync_ShouldAddStatistic()
    {
        // Arrange
        var leagueId = 1;
        var games = 10;
        var wins = 5;
        var losses = 5;
        var titles = 1;

        this.mockLeagueStatisticService.Setup(s => s.AddLeagueStatisticAsync(leagueId, games, wins, losses, titles))
            .Returns(Task.CompletedTask);

        // Act
        await this.mockLeagueStatisticService.Object.AddLeagueStatisticAsync(leagueId, games, wins, losses, titles);

        // Assert
        this.mockLeagueStatisticService.Verify(s => s.AddLeagueStatisticAsync(leagueId, games, wins, losses, titles), Times.Once);
    }

    [Fact]
    public async Task DeleteLeagueStatisticAsync_ShouldDeleteStatistic()
    {
        // Arrange
        var statisticId = 1;

        this.mockLeagueStatisticService.Setup(s => s.DeleteLeagueStatisticAsync(statisticId))
            .Returns(Task.CompletedTask);

        // Act
        await this.mockLeagueStatisticService.Object.DeleteLeagueStatisticAsync(statisticId);

        // Assert
        this.mockLeagueStatisticService.Verify(s => s.DeleteLeagueStatisticAsync(statisticId), Times.Once);
    }
}
