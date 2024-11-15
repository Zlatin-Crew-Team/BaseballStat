namespace BaseballStat.Web.ViewModels.TeamStatistic
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

    public class TeamStatisticViewModel : IMapFrom<TeamStatistic>
    {
        public int Id { get; set; }

        public int TeamId { get; set; }

        public string TeamName { get; set; }

        [Required]
        [Range(GlobalConstants.TeamStatistic.GamesMinValue, GlobalConstants.TeamStatistic.GamesMaxValue, ErrorMessage=GlobalConstants.ErrorMesages.TeamGames)]
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
