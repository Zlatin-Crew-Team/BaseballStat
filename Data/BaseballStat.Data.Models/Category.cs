namespace BaseballStat.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BaseballStat.Common;
    using BaseballStat.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Players = new HashSet<Player>();
            this.Teams = new HashSet<Team>();
            this.Leagues = new HashSet<League>();
            this.Awards = new HashSet<Award>();
            this.AllTimeGreats = new HashSet<AllTimeGreat>();
        }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public virtual ICollection<League> Leagues { get; set; }

        public virtual ICollection<Award> Awards { get; set; }

        public virtual ICollection<AllTimeGreat> AllTimeGreats { get; set; }
    }
}
