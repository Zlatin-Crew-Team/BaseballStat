namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    public class TeamSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Teams.Any())
            {
                return;
            }

            var teams = new Team[]
            {
                new Team
                {
                    Name = "Boston Red Sox",
                    City = "Boston",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/8/88/Boston_Red_Sox.svg/1200px-Boston_Red_Sox.svg.png",
                    Owner = "Fenway Sports Group",
                    Stadium = "Fenway Park",
                },
                new Team
                {
                    Name = "New York Yankees",
                    City = "New York",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/2/25/New_York_Yankees_logo.svg/1200px-New_York_Yankees_logo.svg.png",
                    Owner = "Yankee Global Enterprises",
                    Stadium = "Yankee Stadium",
                },
                new Team
                {
                    Name = "Tampa Bay Rays",
                    City = "Tampa Bay",
                    FoundedYear = "1998",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/Tampa_Bay_Rays.svg/1200px-Tampa_Bay_Rays.svg.png",
                    Owner = "Stu Sternberg",
                    Stadium = "Tropicana Field",
                },
                new Team
                {
                    Name = "Toronto Blue Jays",
                    City = "Toronto",
                    FoundedYear = "1977",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/b/ba/Toronto_Blue_Jays_logo.svg/1200px-Toronto_Blue_Jays_logo.svg.png",
                    Owner = "Rogers Communications",
                    Stadium = "Rogers Centre",
                },
                new Team
                {
                    Name = "Baltimore Orioles",
                    City = "Baltimore",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/0/00/Baltimore_Orioles_logo.svg/1200px-Baltimore_Orioles_logo.svg.png",
                    Owner = "Peter Angelos",
                    Stadium = "Oriole Park at Camden Yards",
                },
                new Team
                {
                    Name = "Chicago White Sox",
                    City = "Chicago",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c1/Chicago_White_Sox.svg/1200px-Chicago_White_Sox.svg.png",
                    Owner = "Jerry Reinsdorf",
                    Stadium = "Guaranteed Rate Field",
                },
                new Team
                {
                    Name = "Cleveland Guardians",
                    City = "Cleveland",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1f/Cleveland_Guardians_logo.svg/1200px-Cleveland_Guardians_logo.svg.png",
                    Owner = "Larry Dolan",
                    Stadium = "Progressive Field",
                },
                new Team
                {
                    Name = "Detroit Tigers",
                    City = "Detroit",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/b/b4/Detroit_Tigers_logo.svg/1200px-Detroit_Tigers_logo.svg.png",
                    Owner = "Christopher Ilitch",
                    Stadium = "Comerica Park",
                },
                new Team
                {
                    Name = "Kansas City Royals",
                    City = "Kansas City",
                    FoundedYear = "1969",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/7/74/Kansas_City_Royals_logo.svg/1200px-Kansas_City_Royals_logo.svg.png",
                    Owner = "John Sherman",
                    Stadium = "Kauffman Stadium",
                },
                new Team
                {
                    Name = "Minnesota Twins",
                    City = "Minneapolis",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8e/Minnesota_Twins_logo.svg/1200px-Minnesota_Twins_logo.svg.png",
                    Owner = "Jim Pohlad",
                    Stadium = "Target Field",
                },
                new Team
                {
                    Name = "Houston Astros",
                    City = "Houston",
                    FoundedYear = "1962",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/6b/Houston_Astros.svg/1200px-Houston_Astros.svg.png",
                    Owner = "Jim Crane",
                    Stadium = "Minute Maid Park",
                },
                new Team
                {
                    Name = "Los Angeles Angels",
                    City = "Los Angeles",
                    FoundedYear = "1961",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8b/Los_Angeles_Angels.svg/1200px-Los_Angeles_Angels.svg.png",
                    Owner = "Arte Moreno",
                    Stadium = "Angel Stadium",
                },
                new Team
                {
                    Name = "Oakland Athletics",
                    City = "Oakland",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a3/Oakland_Athletics_logo.svg/1200px-Oakland_Athletics_logo.svg.png",
                    Owner = "John Fisher",
                    Stadium = "RingCentral Coliseum",
                },
                new Team
                {
                    Name = "Seattle Mariners",
                    City = "Seattle",
                    FoundedYear = "1977",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/b/b0/Seattle_Mariners_logo.svg/1200px-Seattle_Mariners_logo.svg.png",
                    Owner = "Nintendo of America",
                    Stadium = "T-Mobile Park",
                },
                new Team
                {
                    Name = "Texas Rangers",
                    City = "Arlington",
                    FoundedYear = "1961",
                    LeagueId = 1,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/4/41/Texas_Rangers.svg/1200px-Texas_Rangers.svg.png",
                    Owner = "Ray Davis",
                    Stadium = "Globe Life Field",
                },
                new Team
                {
                    Name = "Atlanta Braves",
                    City = "Atlanta",
                    FoundedYear = "1871",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/2/24/Atlanta_Braves.svg/1200px-Atlanta_Braves.svg.png",
                    Owner = "Liberty Media",
                    Stadium = "Truist Park",
                },
                new Team
                {
                    Name = "Miami Marlins",
                    City = "Miami",
                    FoundedYear = "1993",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/f/f3/Miami_Marlins_logo.svg/1200px-Miami_Marlins_logo.svg.png",
                    Owner = "Bruce Sherman",
                    Stadium = "LoanDepot Park",
                },
                new Team
                {
                    Name = "New York Mets",
                    City = "New York",
                    FoundedYear = "1962",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/7/7b/New_York_Mets.svg/1200px-New_York_Mets.svg.png",
                    Owner = "Steven Cohen",
                    Stadium = "Citi Field",
                },
                new Team
                {
                    Name = "Washington Nationals",
                    City = "Washington",
                    FoundedYear = "1969",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/Washington_Nationals_logo.svg/1200px-Washington_Nationals_logo.svg.png",
                    Owner = "Mark Lerner",
                    Stadium = "Nationals Park",
                },
                new Team
                {
                    Name = "Chicago Cubs",
                    City = "Chicago",
                    FoundedYear = "1876",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/8/80/Chicago_Cubs_logo.svg/1200px-Chicago_Cubs_logo.svg.png",
                    Owner = "Ricketts Family",
                    Stadium = "Wrigley Field",
                },
                new Team
                {
                    Name = "Cincinnati Reds",
                    City = "Cincinnati",
                    FoundedYear = "1881",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/0/01/Cincinnati_Reds_Logo.svg/1200px-Cincinnati_Reds_Logo.svg.png",
                    Owner = "Bob Castellini",
                    Stadium = "Great American Ball Park",
                },
                new Team
                {
                    Name = "Milwaukee Brewers",
                    City = "Milwaukee",
                    FoundedYear = "1969",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1c/Milwaukee_Brewers_logo.svg/1200px-Milwaukee_Brewers_logo.svg.png",
                    Owner = "Mark Attanasio",
                    Stadium = "American Family Field",
                },
                new Team
                {
                    Name = "Pittsburgh Pirates",
                    City = "Pittsburgh",
                    FoundedYear = "1882",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8e/Pittsburgh_Pirates_logo_2014.svg/1200px-Pittsburgh_Pirates_logo_2014.svg.png",
                    Owner = "Robert Nutting",
                    Stadium = "PNC Park",
                },
                new Team
                {
                    Name = "St. Louis Cardinals",
                    City = "St. Louis",
                    FoundedYear = "1882",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9d/St._Louis_Cardinals_logo.svg/1200px-St._Louis_Cardinals_logo.svg.png",
                    Owner = "William DeWitt Jr.",
                    Stadium = "Busch Stadium",
                },
                new Team
                {
                    Name = "Arizona Diamondbacks",
                    City = "Phoenix",
                    FoundedYear = "1998",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/4/47/Arizona_Diamondbacks_logo.svg/1200px-Arizona_Diamondbacks_logo.svg.png",
                    Owner = "Ken Kendrick",
                    Stadium = "Chase Field",
                },
                new Team
                {
                    Name = "Colorado Rockies",
                    City = "Denver",
                    FoundedYear = "1993",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/4/41/Colorado_Rockies_logo.svg/1200px-Colorado_Rockies_logo.svg.png",
                    Owner = "Monfort Brothers",
                    Stadium = "Coors Field",
                },
                new Team
                {
                    Name = "Los Angeles Dodgers",
                    City = "Los Angeles",
                    FoundedYear = "1883",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/0/0f/Los_Angeles_Dodgers_logo.svg/1200px-Los_Angeles_Dodgers_logo.svg.png",
                    Owner = "Guggenheim Baseball Management",
                    Stadium = "Dodger Stadium",
                },
                new Team
                {
                    Name = "San Diego Padres",
                    City = "San Diego",
                    FoundedYear = "1969",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/e/e5/San_Diego_Padres_logo.svg/1200px-San_Diego_Padres_logo.svg.png",
                    Owner = "Ron Fowler",
                    Stadium = "Petco Park",
                },
                new Team
                {
                    Name = "San Francisco Giants",
                    City = "San Francisco",
                    FoundedYear = "1883",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/60/San_Francisco_Giants_logo.svg/1200px-San_Francisco_Giants_logo.svg.png",
                    Owner = "Charles B. Johnson",
                    Stadium = "Oracle Park",
                },
                new Team
                {
                    Name = "Philadelpia Phillies",
                    City = "Philadelphia",
                    FoundedYear = "1883",
                    LeagueId = 2,
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9d/Philadelphia_Phillies.svg/1200px-Philadelphia_Phillies.svg.png",
                    Owner = "John Middleton",
                    Stadium = "Citizens Bank Park",
                },
            };
            foreach (var team in teams)
            {
                await dbContext.AddAsync(team);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
