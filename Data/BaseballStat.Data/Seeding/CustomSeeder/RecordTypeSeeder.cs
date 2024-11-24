namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    public class RecordTypeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.RecordTypes.Any())
            {
                return;
            }

            var recordTypes = new RecordType[]
            {
                new RecordType
                {
                    Name = "HomeRuns",
                },
                new RecordType
                {
                    Name = "Hits",
                },
                new RecordType
                {
                    Name = "RBI",
                },
            };

            foreach (var recordType in recordTypes)
            {
                await dbContext.RecordTypes.AddAsync(recordType);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
