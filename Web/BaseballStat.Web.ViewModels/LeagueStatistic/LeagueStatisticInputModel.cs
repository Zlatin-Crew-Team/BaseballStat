namespace BaseballStat.Web.ViewModels.LeagueStatistic
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BaseballStat.Common;

    public class LeagueStatisticInputModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "League")]
        [Range(GlobalConstants.LeagueStatistic.LeagueIdMinValue, GlobalConstants.LeagueStatistic.LeagueIdMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.LeagueId)]
        public int LeagueId { get; set; }

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
