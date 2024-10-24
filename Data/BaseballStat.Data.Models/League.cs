namespace BaseballStat.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BaseballStat.Common;

    using BaseballStat.Data.Common.Models;

    public class League : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Name { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
