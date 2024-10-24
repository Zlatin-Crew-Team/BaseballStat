namespace BaseballStat.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Data.Common.Models;

    public class Team : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.CityMaxLength)]
        public string City { get; set; }

        [Required]
        public string Stadium { get; set; }

        public League League { get; set; }

        public int LeagueId { get; set; }

        [Required]
        public string FoundedYear { get; set; }

        [Required]
        public string LogoUrl { get; set; }

        [Required]
        public string Owner { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
