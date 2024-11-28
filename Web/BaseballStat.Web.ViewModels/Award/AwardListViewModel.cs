namespace BaseballStat.Web.ViewModels.Award
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AwardListViewModel
    {
        public IEnumerable<AwardViewModel> Awards { get; set; }
    }
}
