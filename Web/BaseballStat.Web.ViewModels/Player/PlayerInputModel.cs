namespace BaseballStat.Web.ViewModels.Player
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Web.ViewModels.Common.CustomValidationAttributes;
    using Microsoft.AspNetCore.Http;

    public class PlayerInputModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Bats { get; set; }

        [Required]
        public string Throws { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImagefile(ErrorMessage = "Invalid image format.")]
        public IFormFile Image { get; set; }
    }
}
