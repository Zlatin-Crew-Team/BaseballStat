namespace BaseballStat.Web.ViewModels.Team
{
    using System.ComponentModel.DataAnnotations;

    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;

    public class TeamViewModel : IMapFrom<Team>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Stadium { get; set; }

        [Required]
        public string FoundedYear { get; set; }

        [Required]
        public string Owner { get; set; }

        [Required]
        public string LogoUrl { get; set; }

        [Required]
        public string LeagueName { get; set; }
    }
}
