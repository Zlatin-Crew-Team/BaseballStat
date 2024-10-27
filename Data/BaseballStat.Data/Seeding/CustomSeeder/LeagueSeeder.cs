namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    public class LeagueSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Leagues.Any())
            {
                return;
            }

            var leagues = new League[]
            {
                new League
                {
                    Name = "American League",

                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/5/54/American_League_logo.svg/800px-  American_League_logo.svg.png",
                },
                new League
                {
                    Name = "National League",

                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTdN8IBk91qrItuyZFGy7nGGCk9BP1HJNR-zg&s",
                },
            };
            foreach (var league in leagues)
            {
                await dbContext.AddAsync(league);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
