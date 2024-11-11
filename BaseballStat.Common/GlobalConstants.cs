namespace BaseballStat.Common
{
    using System.ComponentModel;

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
        }

        public static class Images
        {
            public const string Index = "https://res.cloudinary.com/dsbprqxc5/image/upload/t_mlb/v1730372127/baseballstat/mbevkq8octhz8xngctot_erekd9.jpg";

            public const string CoverBackground = "https://res.cloudinary.com/dsbprqxc5/image/upload/c_crop,w_1900,h_1200/v1730636786/kqpmsiks5sfn6fojbdrh_ofvjiy.png";
        }

        public static class SeededDataCounts
        {
            public const int LeaguesCount = 2;

            public const int TeamsCount = 30;

            public const int PlayersCount = 61;
        }
    }
}
