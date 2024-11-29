namespace BaseballStat.Web.ViewModels.AllTimeGreat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Data.Models;

    public class AllTimeGreatListViewModel
    {
        public IEnumerable<AllTimeGreatViewModel> AllTimeGreats { get; set; }

        public int PageIndex { get; set; }

        public int TotalPages { get; set; }

        public bool HasPreviousPage => this.PageIndex > 1;

        public bool HasNextPage => this.PageIndex < this.TotalPages;
    }
}
