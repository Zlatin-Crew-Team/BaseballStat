namespace BaseballStat.Common
{
    using System;

    public static class GlobalConstants
    {
        public const string SystemName = "BaseballStat";

        public const string AdministratorRoleName = "Administrator";

        public const string UserRoleName = "User";

        public const string CloudName = "baseballstat";

        public static class AccountsSeeding
        {
            public const string Password = "16051979";

            public const string AdminEmail = "adminZlati@admin.com";

            public const string UserEmail = "user@user.com";
        }

        public static class DataValidations
        {
            public const int NameMinLength = 2;

            public const int NameMaxLength = 40;

            public const int DescriptionMinLength = 5;

            public const int DescriptionMaxLength = 100;

            public const int FirstNameMinLength = 2;

            public const int FirstNameMaxLength = 20;

            public const int LastNameMinLength = 2;

            public const int LastNameMaxLength = 20;

            public const int CityMinLength = 2;

            public const int CityMaxLength = 20;

            public const int YearOfBirthMinValue = 1880;

            public const int YearOfBirthMaxValue = 2005;

            public const int FoundedYearMinValue = 1880;

            public const int FoundedYearMaxValue = 2020;
        }

        public static class PlayerStatistic
        {
            public const int GamesMinValue = 0;

            public const int GamesMaxValue = 4000;

            public const int AtBatsMinValue = 0;

            public const int AtBatsMaxValue = 20000;

            public const int RunsMinValue = 0;

            public const int RunsMaxValue = 4000;

            public const int HitsMinValue = 0;

            public const int HitsMaxValue = 4280;

            public const int DoublesMinValue = 0;

            public const int DoublesMaxValue = 1800;

            public const int TriplesMinValue = 0;

            public const int TriplesMaxValue = 700;

            public const int HomeRunsMinValue = 0;

            public const int HomeRunsMaxValue = 800;
        }

        public static class LeagueStatistic
        {
            public const int GamesMinValue = 0;

            public const int GamesMaxValue = 400000;

            public const int WinsMinValue = 0;

            public const int WinsMaxValue = 300000;

            public const int LossesMinValue = 0;

            public const int LossesMaxValue = 400000;

            public const int TitlesMinValue = 0;

            public const int TitlesMaxValue = 150;

            public const int LeagueIdMinValue = 1;

            public const int LeagueIdMaxValue = 2;
        }

        public static class Positions
        {
            public const string FirstBase = "1B";
            public const string SecondBase = "2B";
            public const string ThirdBase = "3B";
            public const string ShortStop = "SS";
            public const string RightField = "RF";
            public const string CenterField = "CF";
            public const string LeftField = "LF";
            public const string Catcher = "C";
            public const string StartingPitcher = "SP";
            public const string ReliefPitcher = "RP";
        }

        public static class Bats
        {
            public const string Left = "L";
            public const string Right = "R";
            public const string TwoHanded = "S";
        }

        public static class Throws
        {
            public const string Left = "L";
            public const string Right = "R";
            public const string TwoHanded = "T";
        }

        public static class TeamIds
        {
            public const int MinValue = 1;
            public const int MaxValue = 30;
        }

        public static class TeamStatistic
        {
            public const int GamesMinValue = 0;

            public const int GamesMaxValue = 25000;

            public const int WinsMinValue = 1000;

            public const int WinsMaxValue = 1300;

            public const int LossesMinValue = 1000;

            public const int LossesMaxValue = 1300;

            public const int TitlesMinValue = 0;

            public const int TitlesMaxValue = 40;
        }

        public static class Team
        {
            public const int TeamNameMaxLength = 50;
            public const int TeamNameMinLength = 2;

            public const int CityMaxLength = 50;
            public const int CityMinLength = 2;

            public const int StadiumMaxLength = 100;
            public const int StadiumMinLength = 2;

            public const int FoundedYearMinValue = 1900;
            public const int FoundedYearMaxValue = 2000;

            public const int OwnerMaxLength = 50;
            public const int OwnerMinLength = 2;

            public const int LeagueIdMinValue = 1;
            public const int LeagueIdMaxValue = 2;
        }

        public static class Award
        {
            public const int DescriptionMaxLength = 200;
            public const int DescriptionMinLength = 5;

            public const int YearMinValue = 1900;
            public const int YearMaxValue = 2024;

            public const int WinnerMaxLength = 50;
            public const int WinnerMinLength = 2;

            public const int AwardTypeIdMinValue = 1;
            public const int AwardTypeIdMaxValue = 3;

            public const int LeagueIdMinValue = 1;
            public const int LeagueIdMaxValue = 2;

            public const int TeamIdMinValue = 1;
            public const int TeamIdMaxValue = 30;
        }

        public static class ErrorMesages
        {
            public const string Name = "Name must be between 2 and 40 characters.";

            public const string Description = "Description must be between 5 and 100 characters.";

            public const string Image = "Please select a JPG, JPEG or PNG image smaller than 1MB.";

            public const string Games = "Games must be between 0 and 4000.";

            public const string AtBats = "At Bats must be between 0 and 20000.";

            public const string Runs = "Runs must be between 0 and 4000.";

            public const string Hits = "Hits must be between 0 and 4280.";

            public const string Doubles = "Doubles must be between 0 and 1800.";

            public const string Triples = "Triples must be between 0 and 700.";

            public const string HomeRuns = "Home Runs must be between 0 and 800.";

            public const string FoundedYear = "Founded year must be between 1880 and 2020.";

            public const string YearOfBirth = "Year of birth must be between 1880 and 2005.";

            public const string City = "City must be between 2 and 20 characters.";

            public const string FirstName = "First name must be between 2 and 20 characters.";

            public const string LastName = "Last name must be between 2 and 20 characters.";

            public const string TeamName = "Team name must be between 2 and 40 characters.";

            public const string TeamGames = "Games must be between 0 and 25000.";

            public const string TeamWins = "Wins must be between 1000 and 1300.";

            public const string TeamLosses = "Losses must be between 1000 and 1300.";

            public const string TeamTitles = "Titles must be between 0 and 40.";

            public const string Position = "Invalid position.";

            public const string Bats = "Invalid bats value.";

            public const string Throws = "Invalid throws value.";

            public const string TeamId = "Invalid team id.";

            public const string PlayerId = "Invalid player id.";

            public const string PlayerStatisticId = "Invalid player statistic id.";

            public const string TeamStatisticId = "Invalid team statistic id.";

            public const string PlayerStatistic = "Invalid player statistic.";

            public const string TeamStatistic = "Invalid team statistic.";

            public const string LeagueStatistic = "Invalid league statistic.";

            public const string LeagueId = "Invalid league id.";

            public const string GamesRangeErrorMessage = "Games must be between 0 and 400000.";
            public const string WinsRangeErrorMessage = "Wins must be between 0 and 300000.";
            public const string LossesRangeErrorMessage = "Losses must be between 0 and 400000.";

            public const string TitlesRangeErrorMessage = "Titles must be between 0 and 150.";
        }

        public static class Images
        {
            public const string Index = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731519246/Players/background-with-baseball-aqua-color_1040322-10408_f4c8gv.jpg";

            public const string CoverBackground = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732728348/Mlb%20Logos/stadium-5460564_640_w5re32.jpg";
            public const string CloudinaryMissing = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731657890/baseballstat/cloudinary_veibtu_r4ks73.png";
            public const string Error404 = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1731674761/baseballstat/robot-is-smashing-404-error-message-with-a-baseball-bat-2AXN739_esj4pz.jpg";
            public const string AdminBackground = "https://res.cloudinary.com/dsbprqxc5/image/upload/v1732357924/Mlb%20Logos/baseball-ball-in-a-grass-of-baseball-arena-stadium_dzql46.webp";
        }

        public static class SeededDataCounts
        {
            public const int LeaguesCount = 2;

            public const int TeamsCount = 30;

            public const int PlayersCount = 61;

            public const int PlayerStatisticsCount = 61;

            public const int TeamStatisticsCount = 30;

            public const int LeagueStatisticsCount = 2;

            public const int Categories = 3;
        }
    }
}
