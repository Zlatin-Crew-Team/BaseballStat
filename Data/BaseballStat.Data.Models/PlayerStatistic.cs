namespace BaseballStat.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Models;

    public class PlayerStatistic : BaseDeletableModel<int>
    {
        public int PlayerId { get; set; }

        public Player Player { get; set; }

        [Required]
        public int Games { get; set; }

        [Required]
        public int AtBats { get; set; }

        [Required]
        public int Runs { get; set; }

        [Required]
        public int Hits { get; set; }

        [Required]
        public int Doubles { get; set; }

        [Required]
        public int Triples { get; set; }

        [Required]
        public int HomeRuns { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
