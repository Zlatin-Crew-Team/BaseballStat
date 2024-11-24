namespace BaseballStat.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Common.Models;

    public class Record : BaseDeletableModel<int>
    {
        [Required]
        public string Holder { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public virtual RecordType RecordType { get; set; }

        public int RecordTypeId { get; set; }

        [Required]
        public virtual Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}
