namespace BaseballStat.Web.ViewModels.TeamStatistic
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BaseballStat.Common;

    public class TeamStatisticInput
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Range(GlobalConstants.TeamIds.MaxValue, GlobalConstants.TeamIds.MinValue, ErrorMessage = GlobalConstants.ErrorMesages.TeamId)]
        public int TeamId { get; set; }

        [Required]
        [Range(GlobalConstants.TeamStatistic.GamesMinValue, GlobalConstants.TeamStatistic.GamesMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.TeamGames)]
        public int Games { get; set; }

        [Required]
        [Range(GlobalConstants.TeamStatistic.WinsMinValue, GlobalConstants.TeamStatistic.WinsMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.TeamWins)]
        public int Wins { get; set; }

        [Required]
        [Range(GlobalConstants.TeamStatistic.LossesMinValue, GlobalConstants.TeamStatistic.LossesMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.TeamLosses)]
        public int Losses { get; set; }

        [Required]
        [Range(GlobalConstants.TeamStatistic.TitlesMinValue, GlobalConstants.TeamStatistic.TitlesMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.TeamTitles)]
        public int Titles { get; set; }
    }
}
