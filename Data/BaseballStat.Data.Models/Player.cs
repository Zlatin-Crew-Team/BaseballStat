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

    public class Player : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.DataValidations.FirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.LastNameMaxLength)]
        public string LastName { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Bats { get; set; }

        [Required]
        public string Throws { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public bool IsProtected { get; set; }

        [Required]
        [Range(GlobalConstants.DataValidations.YearOfBirthMinValue, GlobalConstants.DataValidations.YearOfBirthMaxValue)]
        public int YearOfBirth { get; set; }

        public virtual Team Team { get; set; }

        public int TeamId { get; set; }
    }
}
