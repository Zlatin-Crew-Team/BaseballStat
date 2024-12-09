using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using BaseballStat.Data.Common.Repositories;
using BaseballStat.Data.Models;
using BaseballStat.Services.Data.Records;
using BaseballStat.Services.Mapping;
using Moq;
using Xunit;

using Record = BaseballStat.Data.Models.Record;

public class RecordServiceTests
{
    private readonly Mock<IDeletableEntityRepository<Record>> recordsRepositoryMock;
    private readonly RecordService recordService;

    public RecordServiceTests()
    {
        this.recordsRepositoryMock = new Mock<IDeletableEntityRepository<Record>>();

        // Configure AutoMapper
        var configuration = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Record, TestRecordViewModel>();
        });
        var mapper = configuration.CreateMapper();

        this.recordService = new RecordService(this.recordsRepositoryMock.Object, mapper);
    }

    [Fact]
    public async Task AddRecord_ShouldAddRecordToRepository()
    {
        // Arrange
        var holder = "John Doe";
        var description = "Most home runs";
        var imageUrl = "https://example.com/image.jpg";
        var categoryId = 1;
        var recordTypeId = 2;

        this.recordsRepositoryMock
            .Setup(r => r.AddAsync(It.IsAny<Record>()))
            .Returns(Task.CompletedTask); // Ensure mock setup for AddAsync

        // Act
        await this.recordService.AddRecord(2, holder, description, imageUrl, categoryId, recordTypeId);

        // Assert
        this.recordsRepositoryMock.Verify(
            r => r.AddAsync(It.Is<Record>(record =>
                record.Holder == holder &&
                record.Description == description &&
                record.ImageUrl == imageUrl &&
                record.CategoryId == categoryId &&
                record.RecordTypeId == recordTypeId)),
            Times.Once);
        this.recordsRepositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
    }

    [Fact]
    public async Task DeleteRecordAsync_ShouldDeleteRecordFromRepository()
    {
        // Arrange
        var recordId = 1;
        var record = new Record { Id = recordId };

        this.recordsRepositoryMock
            .Setup(r => r.AllAsNoTracking())
            .Returns(new List<Record> { record }.AsQueryable());

        this.recordsRepositoryMock
            .Setup(r => r.Delete(It.IsAny<Record>())); // Mock Delete

        // Act
        await this.recordService.DeleteRecordAsync(recordId);

        // Assert
        this.recordsRepositoryMock.Verify(r => r.Delete(It.Is<Record>(x => x.Id == recordId)), Times.Once);
        this.recordsRepositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
    }

    /*
    TODO: Task<IEnumerable<T>> GetAllRecordsAsync<T>(int? count = null);

    TODO: Task<T> GetRecordByIdAsync<T>(int id);
    */

    private class TestRecordViewModel
    {
        public int Id { get; set; }

        public string Holder { get; set; }
    }
}
