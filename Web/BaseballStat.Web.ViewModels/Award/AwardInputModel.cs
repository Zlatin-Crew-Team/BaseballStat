namespace BaseballStat.Web.ViewModels.Award
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Web.ViewModels.Common.CustomValidationAttributes;
    using Microsoft.AspNetCore.Http;

    public class AwardInputModel
    {
        [Required]
        [Range(GlobalConstants.DataValidations.DescriptionMinLength, GlobalConstants.DataValidations.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [Range(GlobalConstants.DataValidations.YearOfBirthMinValue, GlobalConstants.DataValidations.YearOfBirthMaxValue)]
        public int Year { get; set; }

        [Required]
        public string Winner { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [ValidateImageFileAttribute(ErrorMessage = GlobalConstants.ErrorMesages.Image)]
        public IFormFile Image { get; set; }

        [Required]
        [Range(GlobalConstants.DataValidations.AwardTypeIdMinValue, GlobalConstants.DataValidations.AwardTypeIdMaxValue)]
        public string AwardTypeId { get; set; }

        [Required]
        [Range(GlobalConstants.DataValidations.CategoryIdMinValue, GlobalConstants.DataValidations.CategoryIdMaxValue)]
        public string CategoryId { get; set; }

        [Required]
        [Range(GlobalConstants.DataValidations.TeamIdMinValue, GlobalConstants.DataValidations.TeamIdMaxValue)]
        public string TeamId { get; set; }

        [Required]
        [Range(GlobalConstants.DataValidations.LeagueIdMinValue, GlobalConstants.DataValidations.LeagueIdMaxValue)]
        public string LeagueId { get; set; }
    }
}
