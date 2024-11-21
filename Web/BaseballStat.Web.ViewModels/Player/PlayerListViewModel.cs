namespace BaseballStat.Web.ViewModels.Player
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PlayerListViewModel
    {
        public IEnumerable<PlayerViewModel> Players { get; set; }

        public int PageIndex { get; set; }

        public int TotalPages { get; set; }

        public bool HasPreviousPage => this.PageIndex > 1;

        public bool HasNextPage => this.PageIndex < this.TotalPages;
    }
}
