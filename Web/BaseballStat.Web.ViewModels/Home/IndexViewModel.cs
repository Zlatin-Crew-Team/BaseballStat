namespace BaseballStat.Web.ViewModels.Home
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Web.ViewModels.Category;
    using BaseballStat.Web.ViewModels.League;
    using BaseballStat.Web.ViewModels.Player;
    using BaseballStat.Web.ViewModels.Team;

    public class IndexViewModel
    {
        public IEnumerable<IndexCategoryViewModel> Categories { get; set; }

        public IEnumerable<TeamViewModel> Teams { get; set; }

        public IEnumerable<PlayerViewModel> Players { get; set; }

        public IEnumerable<LeagueViewModel> League { get; set; }
    }
}
