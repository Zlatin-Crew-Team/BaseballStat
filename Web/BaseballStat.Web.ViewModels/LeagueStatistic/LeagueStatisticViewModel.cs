namespace BaseballStat.Web.ViewModels.LeagueStatistic
{
    using System.ComponentModel.DataAnnotations;

    using BaseballStat.Common;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Mapping;

    public class LeagueStatisticViewModel : IMapFrom<LeagueStatistic>
    {
        [Required]
        [Display(Name = "League")]
        public int LeagueId { get; set; }

        public string LeagueName { get; set; }

        [Required]
        [Display(Name = "Games")]
        [Range(GlobalConstants.LeagueStatistic.GamesMinValue, GlobalConstants.LeagueStatistic.GamesMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.GamesRangeErrorMessage)]
        public int Games { get; set; }

        [Required]
        [Display(Name = "Wins")]
        [Range(GlobalConstants.LeagueStatistic.WinsMinValue, GlobalConstants.LeagueStatistic.WinsMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.WinsRangeErrorMessage)]
        public int Wins { get; set; }

        [Required]
        [Display(Name = "Losses")]
        [Range(GlobalConstants.LeagueStatistic.LossesMinValue, GlobalConstants.LeagueStatistic.LossesMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.LossesRangeErrorMessage)]
        public int Losses { get; set; }

        [Required]
        [Display(Name = "Titles")]
        [Range(GlobalConstants.LeagueStatistic.TitlesMinValue, GlobalConstants.LeagueStatistic.TitlesMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.TitlesRangeErrorMessage)]
        public int Titles { get; set; }
    }
}
