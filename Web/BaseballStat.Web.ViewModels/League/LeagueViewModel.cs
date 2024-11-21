namespace BaseballStat.Web.ViewModels.League
{
    using System.Collections;
    using System.ComponentModel.DataAnnotations;

    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;

    public class LeagueViewModel : IMapFrom<League>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
