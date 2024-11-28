namespace BaseballStat.Web.ViewModels.Award
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Data.Models;

    using BaseballStat.Services.Mapping;

    public class AwardViewModel : IMapFrom<Award>
    {
        public string Description { get; set; }

        public int Year { get; set; }

        public string Winner { get; set; }

        public string ImageUrl { get; set; }

        public string AwardTypeId { get; set; }
    }
}
