namespace BaseballStat.Web.ViewModels.LeagueStatistic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LeagueStatisticListViewModel
    {
        public IEnumerable<LeagueStatisticViewModel> LeagueStatistics { get; set; }
    }
}
