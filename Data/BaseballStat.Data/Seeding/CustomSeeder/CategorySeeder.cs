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
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3c/Emblem-award-star-gold.svg/1200px-Emblem-award-star-gold.svg.png",
                    },
                    new Category
                    {
                        Name = "All Time Greats",
                        Description = "Players who have made a lasting impact on the game.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3c/Emblem-award-star-gold.svg/1200px-Emblem-award-star-gold.svg.png",
                    },
                    new Category
                    {
                        Name = "Records",
                        Description = "Records set by players and teams.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3c/Emblem-award-star-gold.svg/1200px-Emblem-award-star-gold.svg.png",
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
