namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    public class AwardSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Awards.Any())
            {
                return;
            }

            var awards = new Award[]
            {
                new Award
                {
                    Description = "Most Valuable Player",

                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732450272/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-al-mvp-award-won-by-mookie-betts-of-the-boston-red-sox_nr7drf.jpg",
                    Year = 2018,
                    Winner = "Mookie Betts",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 1,
                    TeamId = 1,
                },
                new Award
                {
                    Description = "Most Valuable Player",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452405/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-mvp-award-won-by-christian-yelich-of-the-milwaukee_hnvmt5.jpg",
                    Year = 2018,
                    Winner = "Christian Yelich",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 2,
                    TeamId = 23,
                },
                new Award
                {
                    Description = "Most Valuable Player",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732450272/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-al-mvp-award-won-by-mookie-betts-of-the-boston-red-sox_nr7drf.jpg",
                    Year = 2019,
                    Winner = "Mike Trout",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 1,
                    TeamId = 12,
                },
                new Award
                {
                    Description = "Most Valuable Player",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452405/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-mvp-award-won-by-christian-yelich-of-the-milwaukee_hnvmt5.jpg",
                    Year = 2019,
                    Winner = "Cody Bellinger",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 2,
                    TeamId = 21,
                },
                new Award
                {
                    Description = "Most Valuable Player",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732450272/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-al-mvp-award-won-by-mookie-betts-of-the-boston-red-sox_nr7drf.jpg",
                    Year = 2020,
                    Winner = "Jose Abreu",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 1,
                    TeamId = 6,
                },
                new Award
                {
                    Description = "Most Valuable Player",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452405/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-mvp-award-won-by-christian-yelich-of-the-milwaukee_hnvmt5.jpg",
                    Year = 2020,
                    Winner = "Freddie Freeman",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 2,
                    TeamId = 16,
                },
                new Award
                {
                    Description = "Most Valuable Player",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732450272/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-al-mvp-award-won-by-mookie-betts-of-the-boston-red-sox_nr7drf.jpg",
                    Year = 2021,
                    Winner = "Shohei Ohtani",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 1,
                    TeamId = 12,
                },
                new Award
                {
                    Description = "Most Valuable Player",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452405/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-mvp-award-won-by-christian-yelich-of-the-milwaukee_hnvmt5.jpg",
                    Year = 2021,
                    Winner = "Bryce Harper",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 2,
                    TeamId = 19,
                },
                new Award
                {
                    Description = "Most Valuable Player",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732450272/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-al-mvp-award-won-by-mookie-betts-of-the-boston-red-sox_nr7drf.jpg",
                    Year = 2022,
                    Winner = "Aaron Judge",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 1,
                    TeamId = 2,
                },
                new Award
                {
                    Description = "Most Valuable Player",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452405/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-mvp-award-won-by-christian-yelich-of-the-milwaukee_hnvmt5.jpg",
                    Year = 2022,
                    Winner = "Paul Goldschmidt",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 2,
                    TeamId = 25,
                },
                new Award
                {
                    Description = "Most Valuable Player",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732450272/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-al-mvp-award-won-by-mookie-betts-of-the-boston-red-sox_nr7drf.jpg",
                    Year = 2023,
                    Winner = "Shohei Ohtani",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 1,
                    TeamId = 12,
                },
                new Award
                {
                    Description = "Most Valuable Player",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452405/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-mvp-award-won-by-christian-yelich-of-the-milwaukee_hnvmt5.jpg",
                    Year = 2023,
                    Winner = "Ronald Acuna.Jr",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 2,
                    TeamId = 16,
                },
                new Award
                {
                    Description = "Most Valuable Player",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732450272/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-al-mvp-award-won-by-mookie-betts-of-the-boston-red-sox_nr7drf.jpg",
                    Year = 2024,
                    Winner = "Aaron Judge",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 1,
                    TeamId = 2,
                },
                new Award
                {
                    Description = "Most Valuable Player",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452405/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-mvp-award-won-by-christian-yelich-of-the-milwaukee_hnvmt5.jpg",
                    Year = 2024,
                    Winner = "Shohei Ohtani",
                    AwardTypeId = 1,
                    CategoryId = 1,
                    LeagueId = 2,
                    TeamId = 28,
                },
                new Award
                {
                    Description = "Cy Young Award",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452574/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-cy-young-award-won-by-jacob-degrom-of-the-new-york_gps6ed.jpg",
                    Year = 2021,
                    Winner = "Robbie Ray",
                    AwardTypeId = 2,
                    CategoryId = 1,
                    LeagueId = 1,
                    TeamId = 4,
                },
                new Award
                {
                    Description = "Cy Young Award",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452574/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-cy-young-award-won-by-jacob-degrom-of-the-new-york_gps6ed.jpg",
                    Year = 2021,
                    Winner = "Corbin Burnes",
                    AwardTypeId = 2,
                    CategoryId = 1,
                    LeagueId = 2,
                    TeamId = 23,
                },
                new Award
                {
                    Description = "Cy Young Award",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452574/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-cy-young-award-won-by-jacob-degrom-of-the-new-york_gps6ed.jpg",
                    Year = 2022,
                    Winner = "Justin Verlander",
                    AwardTypeId = 2,
                    CategoryId = 1,
                    LeagueId = 1,
                    TeamId = 11,
                },
                new Award
                {
                    Description = "Cy Young Award",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452574/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-cy-young-award-won-by-jacob-degrom-of-the-new-york_gps6ed.jpg",
                    Year = 2022,
                    Winner = "Sandy Alkantra",
                    AwardTypeId = 2,
                    CategoryId = 1,
                    LeagueId = 2,
                    TeamId = 17,
                },
                new Award
                {
                    Description = "Cy Young Award",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452574/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-cy-young-award-won-by-jacob-degrom-of-the-new-york_gps6ed.jpg",
                    Year = 2023,
                    Winner = "Gerrit Cole",
                    AwardTypeId = 2,
                    CategoryId = 1,
                    LeagueId = 1,
                    TeamId = 2,
                },
                new Award
                {
                    Description = "Cy Young Award",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452574/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-cy-young-award-won-by-jacob-degrom-of-the-new-york_gps6ed.jpg",
                    Year = 2023,
                    Winner = "Blake Snell",
                    AwardTypeId = 2,
                    CategoryId = 1,
                    LeagueId = 2,
                    TeamId = 29,
                },
                new Award
                {
                    Description = "Cy Young Award",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452574/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-cy-young-award-won-by-jacob-degrom-of-the-new-york_gps6ed.jpg",
                    Year = 2024,
                    Winner = "Tarik Skubal",
                    AwardTypeId = 2,
                    CategoryId = 1,
                    LeagueId = 1,
                    TeamId = 8,
                },
                new Award
                {
                    Description = "Cy Young Award",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732452574/Mlb%20Logos/new-york-ny-a-detail-shot-of-the-2018-nl-cy-young-award-won-by-jacob-degrom-of-the-new-york_gps6ed.jpg",
                    Year = 2024,
                    Winner = "Chris Sale",
                    AwardTypeId = 2,
                    CategoryId = 1,
                    LeagueId = 2,
                    TeamId = 216,
                },
                new Award
                {
                    Description = "Rookie of the Year",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732453119/Mlb%20Logos/atlantas-michael-harris-is-presented-the-jackie-robinson-award-for-rookie-of-the-year-prior_nkol5y.jpg",
                    Year = 2023,
                    Winner = "Gunnar Henderson",
                    AwardTypeId = 3,
                    CategoryId = 1,
                    LeagueId = 1,
                    TeamId = 5,
                },
                new Award
                                {
                    Description = "Rookie of the Year",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732453119/Mlb%20Logos/atlantas-michael-harris-is-presented-the-jackie-robinson-award-for-rookie-of-the-year-prior_nkol5y.jpg",
                    Year = 2023,
                    Winner = "Corbin Carrol",
                    AwardTypeId = 3,
                    CategoryId = 1,
                    LeagueId = 2,
                    TeamId = 26,
                                },
                new Award
                {
                    Description = "Rookie of the Year",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732453119/Mlb%20Logos/atlantas-michael-harris-is-presented-the-jackie-robinson-award-for-rookie-of-the-year-prior_nkol5y.jpg",
                    Year = 2024,
                    Winner = "Luis Gill",
                    AwardTypeId = 3,
                    CategoryId = 1,
                    LeagueId = 1,
                    TeamId = 2,
                },
                new Award
                {
                    Description = "Rookie of the Year",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732453119/Mlb%20Logos/atlantas-michael-harris-is-presented-the-jackie-robinson-award-for-rookie-of-the-year-prior_nkol5y.jpg",
                    Year = 2024,
                    Winner = "Paul Skenes",
                    AwardTypeId = 3,
                    CategoryId = 1,
                    LeagueId = 2,
                    TeamId = 24,
                },
            };
            foreach (var award in awards)
            {
                await dbContext.Awards.AddAsync(award);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
