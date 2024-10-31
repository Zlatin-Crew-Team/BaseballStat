namespace BaseballStat.Web.ViewModels.Category
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public class CategoryInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile Image { get; set; }
    }
}
