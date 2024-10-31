namespace BaseballStat.Web.ViewModels.Team
{
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;

    public class TeamViewModel : IMapFrom<Team>
    {
        public string Name { get; set; }

        public string City { get; set; }

        public string Stadium { get; set; }

        public string LogoUrl { get; set; }

        public string LeagueName { get; set; }
    }
}
