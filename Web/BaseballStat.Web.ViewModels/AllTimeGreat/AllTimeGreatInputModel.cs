namespace BaseballStat.Web.ViewModels.AllTimeGreat
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

    public class AllTimeGreatInputModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(GlobalConstants.DataValidations.NameMaxLength, MinimumLength = GlobalConstants.DataValidations.NameMinLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(GlobalConstants.DataValidations.BioMaxLength, MinimumLength = GlobalConstants.DataValidations.BioMinLength)]
        public string Bio { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [ValidateImageFileAttribute(ErrorMessage = GlobalConstants.ErrorMesages.Image)]
        public IFormFile Image { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
