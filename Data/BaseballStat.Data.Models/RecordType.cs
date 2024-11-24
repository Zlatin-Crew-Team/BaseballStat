namespace BaseballStat.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RecordType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}
