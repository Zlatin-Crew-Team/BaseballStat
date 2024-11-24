namespace BaseballStat.Web.Areas.Administration.Controllers.PlayerStatistic
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Services.Cloudinary;
    using BaseballStat.Services.Data.PlayerStattistic;
    using BaseballStat.Web.ViewModels.Player;
    using BaseballStat.Web.ViewModels.PlayerStatistic;
    using Microsoft.AspNetCore.Mvc;

    [Area("Administration")]
    public class PlayerStatisticController : AdministrationController
    {
        private readonly IPlayerStatisticService playerStatisticService;
        private readonly ICloudinaryService cloudinaryService;

        public PlayerStatisticController(IPlayerStatisticService playerStatisticService, ICloudinaryService cloudinaryService)
        {
            this.playerStatisticService = playerStatisticService;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 3)
        {
            var players = await this.playerStatisticService.GetAllPlayerStatisticsAsync<PlayerStatisticViewModel>();
            var count = players.Count();
            var items = players.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new PlayerStatisticListViewModel
            {
                PlayerStatistics = items,
                PageIndex = pageIndex,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize),
            };

            return this.View(viewModel);
        }
    }
}
