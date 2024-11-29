namespace BaseballStat.Web.ViewModels.Record
{
    using System.ComponentModel.DataAnnotations;

    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;

    public class RecordViewModel : IMapFrom<Record>
    {
        [Required]
        public string Holder { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
