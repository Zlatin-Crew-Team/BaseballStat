namespace BaseballStat.Data.Seeding.CustomSeeder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    public class PlayerSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Players.Any())
            {
                return;
            }

            var players = new Player[]
            {
                new Player
                {
                    FirstName = "Rafael",
                    LastName = "Devers",
                    ImageUrl = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1730223380/images/800px-Rafael_Devers_lhxkxm.jpg",
                    Position = "3B",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1996,
                    TeamId = 3,
                },
                new Player
                {
                    FirstName = "Kenley",
                    LastName = "Jansen",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "RP",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1987,
                    TeamId = 3,
                },
                new Player()
                {
                    FirstName = "Aaron",
                    LastName = "Judge",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "RF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1992,
                    TeamId = 4,
                },
                new Player()
                {
                    FirstName = "Gerrit",
                    LastName = "Cole",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SP",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1990,
                    TeamId = 4,
                },
                new Player
                {
                    FirstName = "Randy",
                    LastName = "Arozarena",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "LF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1995,
                    TeamId = 5,
                },
                new Player
                {
                    FirstName = "Wander",
                    LastName = "Franco",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SS",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 2001,
                    TeamId = 5,
                },
                new Player
                {
                     FirstName = "Vladimir",
                     LastName = "Guerrero Jr.",
                     ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                     Position = "1B",
                     Bats = "R",
                     Throws = "R",
                     YearOfBirth = 1999,
                     TeamId = 6,
                },
                new Player
                {
                    FirstName = "Bo",
                    LastName = "Bichette",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SS",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1998,
                    TeamId = 6,
                },
                new Player
                {
                    FirstName = "Cedric",
                    LastName = "Mullins",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "CF",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 7,
                },
                new Player
                {
                    FirstName = "Gunnar",
                    LastName = "Henderson",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SS",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 2001,
                    TeamId = 7,
                },
                new Player
                {
                    FirstName = "Eloy",
                    LastName = "Jimenez",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "LF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1996,
                    TeamId = 8,
                },
                new Player
                {
                    FirstName = "Luis",
                    LastName = "Robert",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "CF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1997,
                    TeamId = 8,
                },
                new Player
                {
                    FirstName = "Jose",
                    LastName = "Ramirez",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "3B",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1992,
                    TeamId = 9,
                },
                new Player
                {
                    FirstName = "Shane",
                    LastName = "Bieber",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SP",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1995,
                    TeamId = 9,
                },
                new Player
                {
                    FirstName = "Tarick",
                    LastName = "Scoball",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SP",
                    Bats = "L",
                    Throws = "L",
                    YearOfBirth = 1997,
                    TeamId = 10,
                },
                new Player
                {
                    FirstName = "Riley",
                    LastName = "Greene",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "RF",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 2000,
                    TeamId = 10,
                },
                new Player
                {
                    FirstName = "Salvador",
                    LastName = "Perez",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "C",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1990,
                    TeamId = 10,
                },
                new Player
                {
                    FirstName = "Bobby",
                    LastName = "Witt Jr.",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SS",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 2000,
                    TeamId = 11,
                },
                new Player
                {
                    FirstName = "Carlos",
                    LastName = "Correa",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SS",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 11,
                },
                new Player
                {
                    FirstName = "Lance",
                    LastName = "McCullers Jr.",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SP",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 12,
                },
                new Player
                {
                    FirstName = "Hose",
                    LastName = "Altuve",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "2B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1990,
                    TeamId = 12,
                },
                new Player
                {
                    FirstName = "Yordan",
                    LastName = "Alvarez",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "DH",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1997,
                    TeamId = 13,
                },
                new Player
                {
                    FirstName = "Mike",
                    LastName = "Trout",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "CF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1991,
                    TeamId = 13,
                },
                new Player
                {
                    FirstName = "Anthony",
                    LastName = "Rendon",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "3B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1990,
                    TeamId = 14,
                },
                new Player
                {
                    FirstName = "Miguel",
                    LastName = "Andujar",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "3B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1995,
                    TeamId = 14,
                },
                new Player
                {
                    FirstName = "Brent",
                    LastName = "Rooker",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "LF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 15,
                },
                new Player
                {
                    FirstName = "Mitch",
                    LastName = "Garver",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "C",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1990,
                    TeamId = 15,
                },
                new Player
                {
                    FirstName = "Jorge",
                    LastName = "Polanco",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SS",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 14,
                },
                new Player
                {
                    FirstName = "Corey",
                    LastName = "Seager",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SS",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 16,
                },
                new Player
                {
                    FirstName = "Adolis",
                    LastName = "Garcia",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "CF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 16,
                },
                new Player
                {
                    FirstName = "Ronald",
                    LastName = "Acuna Jr.",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "CF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1997,
                    TeamId = 17,
                },
                new Player
                {
                    FirstName = "Ozzie",
                    LastName = "Albies",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "2B",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1997,
                    TeamId = 17,
                },
                new Player
                {
                    FirstName = "Josh",
                    LastName = "Bell",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "1B",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1992,
                    TeamId = 18,
                },
                new Player
                {
                    FirstName = "Jesus",
                    LastName = "Luzardo",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SP",
                    Bats = "L",
                    Throws = "L",
                    YearOfBirth = 1997,
                    TeamId = 18,
                },
                new Player
                {
                    FirstName = "Pete",
                    LastName = "Alonso",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "1B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 19,
                },
                new Player
                {
                    FirstName = "Jacob",
                    LastName = "deGrom",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SP",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1988,
                    TeamId = 19,
                },
                new Player
                {
                    FirstName = "Trea",
                    LastName = "Turner",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SS",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 32,
                },
                new Player
                {
                    FirstName = "Bryce",
                    LastName = "Harper",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "RF",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1992,
                    TeamId = 32,
                },
                new Player
                {
                    FirstName = "Joey",
                    LastName = "Gallo",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "RF",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 21,
                },
                new Player
                {
                    FirstName = "Jesse",
                    LastName = "Winker",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "LF",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 21,
                },
                new Player
                {
                    FirstName = "Cody",
                    LastName = "Bellinger",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "CF",
                    Bats = "L",
                    Throws = "L",
                    YearOfBirth = 1995,
                    TeamId = 22,
                },
                new Player
                {
                    FirstName = "Ian",
                    LastName = "Happ",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "CF",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 22,
                },
                new Player
                {
                    FirstName = "Elly",
                    LastName = "De La Cruz",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "RF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1996,
                    TeamId = 23,
                },
                new Player
                {
                    FirstName = "Jonathan",
                    LastName = "India",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "2B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1996,
                    TeamId = 23,
                },
                new Player
                {
                    FirstName = "Cristian",
                    LastName = "Yelich",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "LF",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1991,
                    TeamId = 24,
                },
                new Player
                {
                    FirstName = "Brandon",
                    LastName = "Woodruff",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SP",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 24,
                },
                new Player
                {
                    FirstName = "Paul",
                    LastName = "Skenes",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SP",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 2002,
                    TeamId = 25,
                },
                new Player
                {
                    FirstName = "Ke'Bryan",
                    LastName = "Hayes",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "3B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1997,
                    TeamId = 25,
                },
                new Player
                {
                    FirstName = "Nolan",
                    LastName = "Arenado",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "3B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1991,
                    TeamId = 26,
                },
                new Player
                {
                    FirstName = "Paul",
                    LastName = "Goldschmidt",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "1B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1987,
                    TeamId = 26,
                },
                new Player
                {
                    FirstName = "Zack",
                    LastName = "Galen",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SP",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1995,
                    TeamId = 27,
                },
                new Player
                {
                    FirstName = "Ketel",
                    LastName = "Marte",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "2B",
                    Bats = "S",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 27,
                },
                new Player
                {
                    FirstName = "Ryan",
                    LastName = "McMahon",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "2B",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 28,
                },
                new Player
                {
                    FirstName = "Charlie",
                    LastName = "Blackmon",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "RF",
                    Bats = "L",
                    Throws = "L",
                    YearOfBirth = 1986,
                    TeamId = 28,
                },
                new Player
                {
                    FirstName = "Mookie",
                    LastName = "Betts",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "RF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1992,
                    TeamId = 29,
                },
                new Player
                {
                    FirstName = "Clayton",
                    LastName = "Kershaw",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SP",
                    Bats = "L",
                    Throws = "L",
                    YearOfBirth = 1988,
                    TeamId = 29,
                },
                new Player
                {
                    FirstName = "Shohei",
                    LastName = "Ohtani",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "DH",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1994,
                    TeamId = 29,
                },
                new Player
                {
                    FirstName = "Fernando",
                    LastName = "Tatis Jr.",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "SS",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1999,
                    TeamId = 30,
                },
                new Player
                {
                    FirstName = "Manny",
                    LastName = "Machado",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "3B",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1992,
                    TeamId = 30,
                },
                new Player
                {
                    FirstName = "Jorge",
                    LastName = "Soler",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "RF",
                    Bats = "R",
                    Throws = "R",
                    YearOfBirth = 1992,
                    TeamId = 31,
                },
                new Player
                {
                    FirstName = "Michael",
                    LastName = "Conforto",
                    ImageUrl = "https://www.mlb.com/assets/images/1/1/8/303688118/cuts/180x180/cut.jpg",
                    Position = "RF",
                    Bats = "L",
                    Throws = "R",
                    YearOfBirth = 1993,
                    TeamId = 31,
                },
            };
            foreach (var player in players)
            {
                await dbContext.AddAsync(player);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
