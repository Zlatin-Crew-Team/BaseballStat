namespace BaseballStat.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Services.Data.Player;
    using BaseballStat.Services.Data.PlayerStattistic;
    using BaseballStat.Web.ViewModels.Player;
    using BaseballStat.Web.ViewModels.PlayerStatistic;
    using Microsoft.AspNetCore.Mvc;

    public class PlayerController : BaseController
    {
        private readonly IPlayerService playerService;

        public PlayerController(IPlayerService playerService)
        {
            this.playerService = playerService;
        }

        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 3)
        {
            var players = await this.playerService.GetAllPlayersAsync<PlayerViewModel>();
            var count = players.Count();
            var items = players.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new PlayerListViewModel
            {
                Players = items,
                PageIndex = pageIndex,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize),
            };

            return this.View(viewModel);
        }
    }
}
