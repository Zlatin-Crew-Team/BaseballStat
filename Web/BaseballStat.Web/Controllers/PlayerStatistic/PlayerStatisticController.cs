namespace BaseballStat.Web.Controllers.PlayerStatistic
{
    using System.Threading.Tasks;

    using BaseballStat.Services.Data.Player;
    using BaseballStat.Services.Data.PlayerStattistic;
    using BaseballStat.Web.ViewModels.PlayerStatistic;
    using Microsoft.AspNetCore.Mvc;

    public class PlayerStatisticController : Controller
    {
        private readonly IPlayerStatisticService playerStatisticService;

        public PlayerStatisticController(IPlayerStatisticService playerStatisticService)
        {
            this.playerStatisticService = playerStatisticService;
        }

        public async Task<IActionResult> Index(int playerId)
        {
            var viewModel = await this.playerStatisticService.GetByIdAsync<PlayerStatisticViewModel>(playerId);
            return this.View(viewModel);
        }
    }
}
