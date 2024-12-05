namespace BaseballStat.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BaseballStat.Common;

    using BaseballStat.Data.Common.Models;

    public class League : BaseDeletableModel<int>
    {
        public League()
        {
            this.Teams = new HashSet<Team>();
            this.Awards = new HashSet<Award>();
        }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public bool IsProtectedLeague { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public virtual ICollection<Award> Awards { get; set; }
    }
}
