namespace BaseballStat.Web.ViewModels.Record
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

    public class RecordInputModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(GlobalConstants.DataValidations.HolderMaxLength, MinimumLength = GlobalConstants.DataValidations.HolderMinLength)]
        public string Holder { get; set; }

        [Required]
        [StringLength(GlobalConstants.DataValidations.BioMaxLength, MinimumLength = GlobalConstants.DataValidations.BioMinLength)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [ValidateImageFileAttribute(ErrorMessage = GlobalConstants.ErrorMesages.Image)]
        public IFormFile Image { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [Range(GlobalConstants.DataValidations.AwardTypeIdMinValue, GlobalConstants.DataValidations.AwardTypeIdMaxValue)]
        public int RecordTypeId { get; set; }
    }
}
