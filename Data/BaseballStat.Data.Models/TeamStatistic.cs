namespace BaseballStat.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Models;

    public class TeamStatistic : BaseDeletableModel<int>
    {
        public int TeamId { get; set; }

        public Team Team { get; set; }

        public int Games { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public int Titles { get; set; }
    }
}
