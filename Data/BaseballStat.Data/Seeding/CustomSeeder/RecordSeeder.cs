namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    using static System.Net.WebRequestMethods;

    public class RecordSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Records.Any())
            {
                return;
            }

            var records = new Record[]
            {
                new Record
                {
                   Holder = "Barry Bonds",
                   Description = "Barry Bonds is the all-time leader in home runs with 762.",
                   RecordTypeId = 1,
                   ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732878689/ypuzu75o9r5a1_dvnm6e.jpg",
                   CategoryId = 3,
                },
                new Record
                {
                    Holder = "Pete Rose",
                    Description = "Pete Rose is the all-time leader in hits with 4,256.",
                    RecordTypeId = 2,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732457158/Players/cincinnati-outfielder-pete-rose-of-the-cincinnati-reds-salutes-the-crowd-after-surpassing-ty_fcuisc.jpg",
                    CategoryId = 3,
                },
                new Record
                {
                    Holder = "Hank Aaron",
                    Description = "Hank Aaron is the all-time leader in RBI with 2,297.",
                    RecordTypeId = 3,
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732457198/Players/this-is-a-waist-up-portrait-of-hank-aaron-of-the-atlanta-braves-baseball-team-in-uniform_mjyh9k.jpg",
                    CategoryId = 3,
                },
            };
            foreach (var record in records)
            {
                await dbContext.Records.AddAsync(record);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
