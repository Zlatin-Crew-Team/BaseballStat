namespace BaseballStat.Web.ViewModels.League
{
    using System.Collections;

    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;

    public class LeagueViewModel : IMapFrom<League>
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }
    }
}
