namespace BaseballStat.Web.ViewModels.Team
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TeamListViewModel
    {
        public IEnumerable<TeamViewModel> Teams { get; set; }
    }
}
