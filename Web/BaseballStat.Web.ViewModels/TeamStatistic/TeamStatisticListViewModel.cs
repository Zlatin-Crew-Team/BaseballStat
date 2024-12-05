namespace BaseballStat.Web.ViewModels.TeamStatistic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TeamStatisticListViewModel
    {
        public IEnumerable<TeamStatisticViewModel> TeamStatistics { get; set; }

        public int PageIndex { get; set; }

        public int TotalPages { get; set; }

        public bool HasPreviousPage => this.PageIndex > 1;

        public bool HasNextPage => this.PageIndex < this.TotalPages;
    }
}
