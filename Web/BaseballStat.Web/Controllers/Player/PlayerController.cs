namespace BaseballStat.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Services.Data.Player;
    using BaseballStat.Web.ViewModels.Player;
    using Microsoft.AspNetCore.Mvc;

    public class PlayerController : BaseController
    {
        private readonly IPlayerService playerService;

        public PlayerController(IPlayerService playerService)
        {
            this.playerService = playerService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new PlayerListViewModel
            {
                Players = await this.playerService.GetAllPlayersAsync<PlayerViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
