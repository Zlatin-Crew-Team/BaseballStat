namespace BaseballStat.Web.Controllers.League
{
    using System.Threading.Tasks;

    using BaseballStat.Services.Data.League;
    using BaseballStat.Web.ViewModels.League;
    using BaseballStat.Web.ViewModels.Player;
    using Microsoft.AspNetCore.Mvc;

    public class LeagueController : BaseController
    {
        private readonly ILeagueService leagueService;

        public LeagueController(ILeagueService leagueService)
        {
            this.leagueService = leagueService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var viewModel = new LeagueListViewModel
            {
                Leagues = await this.leagueService.GetAllLeaguesAsync<LeagueViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
