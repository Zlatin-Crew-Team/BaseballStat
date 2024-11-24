namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class AwardTypeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.AwardTypes.Any())
            {
                return;
            }

            var awardTypes = new AwardType[]
            {
                new AwardType
                {
                    Name = "MVP",
                },
                new AwardType
                {
                    Name = "Cy Young",
                },
                new AwardType
                {
                    Name = "ROY",
                },
            };

            foreach (var awardType in awardTypes)
            {
                await dbContext.AwardTypes.AddAsync(awardType);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
