namespace BaseballStat.Web.ViewModels.League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LeagueListViewModel
    {
        public IEnumerable<LeagueViewModel> Leagues { get; set; }
    }
}
