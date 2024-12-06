namespace BaseballStat.Web.ViewModels.Team
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Web.ViewModels.Common.CustomValidationAttributes;
    using BaseballStat.Web.ViewModels.Team;
    using Microsoft.AspNetCore.Http;

    public class TeamInputModel
        {
            [Required]
            [StringLength(GlobalConstants.Team.TeamNameMaxLength, MinimumLength = GlobalConstants.Team.TeamNameMinLength, ErrorMessage =GlobalConstants.ErrorMesages.TeamName)]
            public string Name { get; set; }

            [Required]
            [StringLength(GlobalConstants.Team.CityMaxLength, MinimumLength = GlobalConstants.DataValidations.CityMinLength, ErrorMessage =GlobalConstants.ErrorMesages.City)]
            public string City { get; set; }

            [Required]
            [StringLength(GlobalConstants.Team.StadiumMaxLength, MinimumLength = GlobalConstants.Team.StadiumMinLength),]
            public string Stadium { get; set; }

            [Required]
            [Range(GlobalConstants.DataValidations.FoundedYearMinValue, GlobalConstants.DataValidations.FoundedYearMaxValue)]
            public string FoundedYear { get; set; }

            [Required]
            [StringLength(GlobalConstants.Team.OwnerMaxLength, MinimumLength = GlobalConstants.Team.OwnerMinLength)]
            public string Owner { get; set; }

            [Required]
            [DataType(DataType.Upload)]
            [ValidateImageFile(ErrorMessage = GlobalConstants.ErrorMesages.Image)]
            public IFormFile Logo { get; set; }

            [Required]
            [Range(GlobalConstants.Team.LeagueIdMinValue, GlobalConstants.Team.LeagueIdMaxValue)]
            public int LeagueId { get; set; }
    }
}
