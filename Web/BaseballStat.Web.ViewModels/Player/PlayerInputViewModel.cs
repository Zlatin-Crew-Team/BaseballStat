namespace BaseballStat.Web.ViewModels.Player
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Common;

    public class PlayerInputViewModel
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

        [Required]
        [Range(GlobalConstants.DataValidations.YearOfBirthMinValue, GlobalConstants.DataValidations.YearOfBirthMaxValue)]
        public int YearOfBirth { get; set; }

        public int TeamId { get; set; }
    }
}
