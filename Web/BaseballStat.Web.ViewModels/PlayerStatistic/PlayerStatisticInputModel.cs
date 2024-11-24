namespace BaseballStat.Web.ViewModels.PlayerStatistic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Services.Mapping;
    using BaseballStat.Web.ViewModels.Common.CustomValidationAttributes;
    using BaseballStat.Web.ViewModels.Player;
    using Microsoft.AspNetCore.Http;

    public class PlayerStatisticInputModel
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public PlayerViewModel Player { get; set; }

        [Required]
        [Range(GlobalConstants.PlayerStatistic.GamesMinValue, GlobalConstants.PlayerStatistic.GamesMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.Games)]
        public int Games { get; set; }

        [Required]
        [Range(GlobalConstants.PlayerStatistic.AtBatsMinValue, GlobalConstants.PlayerStatistic.AtBatsMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.AtBats)]
        public int AtBats { get; set; }

        [Required]
        [Range(GlobalConstants.PlayerStatistic.RunsMinValue, GlobalConstants.PlayerStatistic.RunsMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.Runs)]
        public int Runs { get; set; }

        [Required]
        [Range(GlobalConstants.PlayerStatistic.HitsMinValue, GlobalConstants.PlayerStatistic.HitsMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.Hits)]
        public int Hits { get; set; }

        [Required]
        [Range(GlobalConstants.PlayerStatistic.DoublesMinValue, GlobalConstants.PlayerStatistic.DoublesMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.Doubles)]
        public int Doubles { get; set; }

        [Required]
        [Range(GlobalConstants.PlayerStatistic.TriplesMinValue, GlobalConstants.PlayerStatistic.TriplesMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.Triples)]
        public int Triples { get; set; }

        [Required]
        [Range(GlobalConstants.PlayerStatistic.HomeRunsMinValue, GlobalConstants.PlayerStatistic.HomeRunsMaxValue, ErrorMessage = GlobalConstants.ErrorMesages.HomeRuns)]
        public int HomeRuns { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [ValidateImageFileAttribute(ErrorMessage = GlobalConstants.ErrorMesages.Image)]
        public IFormFile Image { get; set; }
    }
}
