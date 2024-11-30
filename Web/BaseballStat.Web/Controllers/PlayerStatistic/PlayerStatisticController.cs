namespace BaseballStat.Web.Controllers.PlayerStatistic
{
    using System.Threading.Tasks;

    using BaseballStat.Services.Data.Player;
    using BaseballStat.Services.Data.PlayerStattistic;
    using BaseballStat.Web.ViewModels.PlayerStatistic;
    using Microsoft.AspNetCore.Mvc;

    public class PlayerStatisticController : BaseController
    {
        private readonly IPlayerStatisticService playerStatisticService;

        public PlayerStatisticController(IPlayerStatisticService playerStatisticService)
        {
            this.playerStatisticService = playerStatisticService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var player = await this.playerStatisticService.GetPlayerStatisticByIdAsync<PlayerStatisticViewModel>(id);
            return this.View(player);
        }
    }
}
