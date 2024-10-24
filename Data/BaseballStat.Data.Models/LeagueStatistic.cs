namespace BaseballStat.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Models;

    public class LeagueStatistic : BaseDeletableModel<int>
    {
        public int LeagueId { get; set; }

        public League League { get; set; }

        [Required]
        public int Games { get; set; }

        [Required]
        public int Wins { get; set; }

        [Required]
        public int Losses { get; set; }

        [Required]
        public int Titles { get; set; }
    }
}
