namespace BaseballStat.Web.ViewModels.AllTimeGreat
{
    using System.ComponentModel.DataAnnotations;

    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;

    public class AllTimeGreatViewModel : IMapFrom<AllTimeGreat>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Bio { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
