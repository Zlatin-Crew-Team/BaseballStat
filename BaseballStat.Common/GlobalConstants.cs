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

        public static class ErrorMesages
        {
            public const string Name = "Name must be between 2 and 40 characters.";

            public const string Description = "Description must be between 5 and 100 characters.";

            public const string Image = "Please select a JPG, JPEG or PNG image smaller than 1MB.";
        }

        public static class SeededDataCounts
        {
            public const int LeaguesCount = 2;

            public const int TeamsCount = 30;

            public const int PlayersCount = 61;
        }
    }
}
