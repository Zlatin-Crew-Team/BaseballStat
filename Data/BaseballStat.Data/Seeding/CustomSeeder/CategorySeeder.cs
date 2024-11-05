namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    public class CategorySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new Category[]
                {
                    new Category
                    {
                        Name = "Awards",
                        Description = "Awards given to players and teams for outstanding performance.",
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730372127/baseballstat/mlb-awards-graphic-2021-5fd2945649422_socbq3.jpg",
                    },
                    new Category
                    {
                        Name = "All Time Greats",
                        Description = "Players who have made a lasting impact on the game.",
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1721116710/restricted_i2di77.jpg",
                    },
                    new Category
                    {
                        Name = "Records",
                        Description = "Records set by players and teams.",
                        ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730372126/baseballstat/6ebc-10-23-ImagesGoldenGlove_vy7rqr.png",
                    },
                };
            foreach (var category in categories)
            {
                await dbContext.AddAsync(category);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
