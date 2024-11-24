namespace BaseballStat.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Models;

    public class AllTimeGreat : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Bio { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
