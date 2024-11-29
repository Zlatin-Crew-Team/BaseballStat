namespace BaseballStat.Web.ViewModels.Record
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    public class RecordListViewModel
    {
        public IEnumerable<RecordViewModel> Record { get; set; }
    }
}
