namespace BaseballStat.Web.ViewModels.Team
{
    using System.ComponentModel.DataAnnotations;

    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;

    public class TeamViewModel : IMapFrom<Team>
    {
        [Required]

        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Stadium { get; set; }

        [Required]
        public string LogoUrl { get; set; }

        [Required]
        public string LeagueName { get; set; }
    }
}
