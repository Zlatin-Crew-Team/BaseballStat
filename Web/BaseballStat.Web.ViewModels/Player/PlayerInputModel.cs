namespace BaseballStat.Web.ViewModels.Player
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BaseballStat.Common;
    using BaseballStat.Web.ViewModels.Common.CustomValidationAttributes;
    using BaseballStat.Web.ViewModels.Team;
    using Microsoft.AspNetCore.Http;

    public class PlayerInputModel
    {
        [Required]
        [StringLength(GlobalConstants.DataValidations.FirstNameMaxLength, MinimumLength = GlobalConstants.DataValidations.FirstNameMinLength)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(GlobalConstants.DataValidations.LastNameMaxLength, MinimumLength = GlobalConstants.DataValidations.LastNameMinLength)]
        public string LastName { get; set; }

        [Required]
        [RegularExpression("1B|2B|3B|SS|RF|CF|LF|C|SP|RP", ErrorMessage = "Invalid position.")]
        public string Position { get; set; }

        [Required]
        [RegularExpression("Left|Right|Two Handed", ErrorMessage = "Invalid bats value.")]
        public string Bats { get; set; }

        [Required]
        [RegularExpression("Left|Right|Two Handed", ErrorMessage = "Invalid throws value.")]
        public string Throws { get; set; }

        [Required]
        [Range(GlobalConstants.DataValidations.YearOfBirthMinValue, GlobalConstants.DataValidations.YearOfBirthMaxValue)]
        public int YearOfBirth { get; set; }

        [Required]
        [Range(GlobalConstants.TeamIds.MinValue, GlobalConstants.TeamIds.MaxValue)]
        public int TeamId { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [ValidateImageFileAttribute(ErrorMessage = GlobalConstants.ErrorMesages.Image)]
        public IFormFile Image { get; set; }
    }
}
