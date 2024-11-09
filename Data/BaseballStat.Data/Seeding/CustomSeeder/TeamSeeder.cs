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
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730383347/Mlb%20Logos/boston_red_sox_logo_primary_dark_20091090_b5tf6z.png",
                    Owner = "Fenway Sports Group",
                    Stadium = "Fenway Park",
                },
                new Team
                {
                    Name = "New York Yankees",
                    City = "New York",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730651300/Mlb%20Logos/new_york_yankees_logo_primary_19685115_z6ku3j.png",
                    Owner = "Yankee Global Enterprises",
                    Stadium = "Yankee Stadium",
                },
                new Team
                {
                    Name = "Tampa Bay Rays",
                    City = "Tampa Bay",
                    FoundedYear = "1998",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730651217/Mlb%20Logos/tampa_bay_rays_logo_primary_20196768_nmaji3.png",
                    Owner = "Stu Sternberg",
                    Stadium = "Tropicana Field",
                },
                new Team
                {
                    Name = "Toronto Blue Jays",
                    City = "Toronto",
                    FoundedYear = "1977",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730651391/Mlb%20Logos/7222_toronto_blue_jays-alternate-2020_dqt0la.png",
                    Owner = "Rogers Communications",
                    Stadium = "Rogers Centre",
                },
                new Team
                {
                    Name = "Baltimore Orioles",
                    City = "Baltimore",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730383257/Mlb%20Logos/qchcppqognl4rqhzpi0m.png",
                    Owner = "Peter Angelos",
                    Stadium = "Oriole Park at Camden Yards",
                },
                new Team
                {
                    Name = "Chicago White Sox",
                    City = "Chicago",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730652040/Mlb%20Logos/chicago_white_sox_logo_primary_19911413_jnhyc8.png",
                    Owner = "Jerry Reinsdorf",
                    Stadium = "Guaranteed Rate Field",
                },
                new Team
                {
                    Name = "Cleveland Guardians",
                    City = "Cleveland",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730652088/Mlb%20Logos/cleveland_guardians_logo_primary_20227577_urdobo.png",
                    Owner = "Larry Dolan",
                    Stadium = "Progressive Field",
                },
                new Team
                {
                    Name = "Detroit Tigers",
                    City = "Detroit",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730372065/Mlb%20Logos/tigers_dsumrk.jpg",
                    Owner = "Christopher Ilitch",
                    Stadium = "Comerica Park",
                },
                new Team
                {
                    Name = "Kansas City Royals",
                    City = "Kansas City",
                    FoundedYear = "1969",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730652161/Mlb%20Logos/kansas_city_royals_logo_primary_20198736_xw5ens.png",
                    Owner = "John Sherman",
                    Stadium = "Kauffman Stadium",
                },
                new Team
                {
                    Name = "Minnesota Twins",
                    City = "Minneapolis",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730653029/Mlb%20Logos/minnesota_twins_logo_primary_2023_sportslogosnet-3953_qohjwf.png",
                    Owner = "Jim Pohlad",
                    Stadium = "Target Field",
                },
                new Team
                {
                    Name = "Houston Astros",
                    City = "Houston",
                    FoundedYear = "1962",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730360368/Mlb%20Logos/117_ny4mnr.svg",
                    Owner = "Jim Crane",
                    Stadium = "Minute Maid Park",
                },
                new Team
                {
                    Name = "Los Angeles Angels",
                    City = "Los Angeles",
                    FoundedYear = "1961",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730653093/Mlb%20Logos/4389_los_angeles_angels-primary-2016_ktf8z1.png",
                    Owner = "Arte Moreno",
                    Stadium = "Angel Stadium",
                },
                new Team
                {
                    Name = "Oakland Athletics",
                    City = "Oakland",
                    FoundedYear = "1901",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730653331/Mlb%20Logos/6xk2lpc36146pbg2kydf13e50_ktwszh.png",
                    Owner = "John Fisher",
                    Stadium = "RingCentral Coliseum",
                },
                new Team
                {
                    Name = "Seattle Mariners",
                    City = "Seattle",
                    FoundedYear = "1977",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730653372/Mlb%20Logos/seattle_mariners_logo_primary_19933809_dto71o.png",
                    Owner = "Nintendo of America",
                    Stadium = "T-Mobile Park",
                },
                new Team
                {
                    Name = "Texas Rangers",
                    City = "Arlington",
                    FoundedYear = "1961",
                    LeagueId = 1,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730372065/Mlb%20Logos/MLB-Logos-16-1200x750_se8vcs.png",
                    Owner = "Ray Davis",
                    Stadium = "Globe Life Field",
                },
                new Team
                {
                    Name = "Atlanta Braves",
                    City = "Atlanta",
                    FoundedYear = "1871",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730653463/Mlb%20Logos/3kgwjp6heowkeg3w8zoow9ggy_g7yevq.png",
                    Owner = "Liberty Media",
                    Stadium = "Truist Park",
                },
                new Team
                {
                    Name = "Miami Marlins",
                    City = "Miami",
                    FoundedYear = "1993",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730653877/Mlb%20Logos/miami_marlins_logo_primary_20194007_yycbsf.png",
                    Owner = "Bruce Sherman",
                    Stadium = "LoanDepot Park",
                },
                new Team
                {
                    Name = "New York Mets",
                    City = "New York",
                    FoundedYear = "1962",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730653506/Mlb%20Logos/m01gfgeorgvbfw15fy04alujm_fjams9.png",
                    Owner = "Steven Cohen",
                    Stadium = "Citi Field",
                },
                new Team
                {
                    Name = "Philadelpia Phillies",
                    City = "Philadelphia",
                    FoundedYear = "1883",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730372067/Mlb%20Logos/mlb-Philadelphia-Phillies-Logo-300x300_fy34ut.png",
                    Owner = "John Middleton",
                    Stadium = "Citizens Bank Park",
                },
                new Team
                {
                    Name = "Washington Nationals",
                    City = "Washington",
                    FoundedYear = "1969",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730653555/Mlb%20Logos/washington_nationals_logo_primary_dark_20114466_tzg4if.png",
                    Owner = "Mark Lerner",
                    Stadium = "Nationals Park",
                },
                new Team
                {
                    Name = "Chicago Cubs",
                    City = "Chicago",
                    FoundedYear = "1876",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730360368/Mlb%20Logos/112_k4nxuu.svg",
                    Owner = "Ricketts Family",
                    Stadium = "Wrigley Field",
                },
                new Team
                {
                    Name = "Cincinnati Reds",
                    City = "Cincinnati",
                    FoundedYear = "1881",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730653601/Mlb%20Logos/cincinnati_reds_logo_primary_20133208_wescov.png",
                    Owner = "Bob Castellini",
                    Stadium = "Great American Ball Park",
                },
                new Team
                {
                    Name = "Milwaukee Brewers",
                    City = "Milwaukee",
                    FoundedYear = "1969",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730653640/Mlb%20Logos/6474_milwaukee_brewers-primary-2020_hs9rnl.png",
                    Owner = "Mark Attanasio",
                    Stadium = "American Family Field",
                },
                new Team
                {
                    Name = "Pittsburgh Pirates",
                    City = "Pittsburgh",
                    FoundedYear = "1882",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730653690/Mlb%20Logos/1250_pittsburgh_pirates-primary-2014_xje48r.png",
                    Owner = "Robert Nutting",
                    Stadium = "PNC Park",
                },
                new Team
                {
                    Name = "St. Louis Cardinals",
                    City = "St. Louis",
                    FoundedYear = "1882",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730653730/Mlb%20Logos/3zhma0aeq17tktge1huh7yok5_awvaad.png",
                    Owner = "William DeWitt Jr.",
                    Stadium = "Busch Stadium",
                },
                new Team
                {
                    Name = "Arizona Diamondbacks",
                    City = "Phoenix",
                    FoundedYear = "1998",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1723383941/Mlb%20Logos/arizona_diamondbacks_logo_primary_20123733_cvsh76.png",
                    Owner = "Ken Kendrick",
                    Stadium = "Chase Field",
                },
                new Team
                {
                    Name = "Colorado Rockies",
                    City = "Denver",
                    FoundedYear = "1993",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730372067/Mlb%20Logos/ej4v6a8q5w5gegtf7ilqbhoz7_original_erjebr.gif",
                    Owner = "Monfort Brothers",
                    Stadium = "Coors Field",
                },
                new Team
                {
                    Name = "Los Angeles Dodgers",
                    City = "Los Angeles",
                    FoundedYear = "1883",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730360369/Mlb%20Logos/LA_Dodgers_MLB_Baseball_Large_8-in_Logo_Magnet_-_Dragon_Sports_1__57990.1667032494_ui4tod.jpg",
                    Owner = "Guggenheim Baseball Management",
                    Stadium = "Dodger Stadium",
                },
                new Team
                {
                    Name = "San Diego Padres",
                    City = "San Diego",
                    FoundedYear = "1969",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730653807/Mlb%20Logos/7517_san_diego_padres-primary-2020_lw4zx1.png",
                    Owner = "Ron Fowler",
                    Stadium = "Petco Park",
                },
                new Team
                {
                    Name = "San Francisco Giants",
                    City = "San Francisco",
                    FoundedYear = "1883",
                    LeagueId = 2,
                    LogoUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730372066/Mlb%20Logos/san-francisco-giants-logo_iqfwst.png",
                    Owner = "Charles B. Johnson",
                    Stadium = "Oracle Park",
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
