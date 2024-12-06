namespace BaseballStat.Web.ViewModels.League
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

    public class LeagueInputModel
    {
        [Required]
        [Range(GlobalConstants.DataValidations.LeagueIdMinValue, GlobalConstants.DataValidations.LeagueIdMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.LeagueId)]
        public int Id { get; set; }

        [Required]
        [StringLength(GlobalConstants.DataValidations.NameMaxLength, MinimumLength = GlobalConstants.DataValidations.NameMinLength, ErrorMessage = GlobalConstants.ErrorMesages.Name)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [ValidateImageFileAttribute(ErrorMessage = GlobalConstants.ErrorMesages.Image)]
        public IFormFile Image { get; set; }
    }
}
