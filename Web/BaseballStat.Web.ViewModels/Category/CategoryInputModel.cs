namespace BaseballStat.Web.ViewModels.Category
{
    using System.ComponentModel.DataAnnotations;

    using BaseballStat.Common;
    using BaseballStat.Web.ViewModels.Common.CustomValidationAttributes;
    using Microsoft.AspNetCore.Http;

    public class CategoryInputModel
    {
        [Required]
        [StringLength(
            GlobalConstants.DataValidations.NameMaxLength,
            ErrorMessage = GlobalConstants.ErrorMesages.Name,
            MinimumLength = GlobalConstants.DataValidations.NameMinLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(
            GlobalConstants.DataValidations.DescriptionMaxLength,
            ErrorMessage = GlobalConstants.ErrorMesages.Description,
            MinimumLength = GlobalConstants.DataValidations.DescriptionMinLength)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [ValidateImageFileAttribute(ErrorMessage = GlobalConstants.ErrorMesages.Image)]
        public IFormFile Image { get; set; }
    }
}
