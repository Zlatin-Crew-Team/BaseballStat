namespace BaseballStat.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Models;

    public class Award : BaseDeletableModel<int>
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Winner { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public virtual AwardType AwardType { get; set; }

        public int AwardTypeId { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual League League { get; set; }

        public int LeagueId { get; set; }

        public virtual Team Team { get; set; }

        public int TeamId { get; set; }
    }
}
