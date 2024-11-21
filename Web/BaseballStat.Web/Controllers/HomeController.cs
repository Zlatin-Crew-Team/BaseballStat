namespace BaseballStat.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Services.Data.Categories;
    using BaseballStat.Services.Data.League;
    using BaseballStat.Services.Data.Player;
    using BaseballStat.Services.Data.Teams;
    using BaseballStat.Web.ViewModels;
    using BaseballStat.Web.ViewModels.Home;
    using BaseballStat.Web.ViewModels.League;
    using BaseballStat.Web.ViewModels.Player;
    using BaseballStat.Web.ViewModels.Team;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ICategoriesService categoriesService;
        private readonly IPlayerService playersService;
        private readonly ITeamService teamsService;
        private readonly ILeagueService leaguesService;

        public HomeController(
            ICategoriesService categoriesService,
            IPlayerService playersService,
            ITeamService teamsService,
            ILeagueService leaguesService)
        {
            this.categoriesService = categoriesService;
            this.playersService = playersService;
            this.teamsService = teamsService;
            this.leaguesService = leaguesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new IndexViewModel
            {
                Categories = await this.categoriesService.GetAllAsync<IndexCategoryViewModel>(GlobalConstants.SeededDataCounts.Categories),
                Players = await this.playersService.GetAllPlayersAsync<PlayerViewModel>(),
                Teams = await this.teamsService.GetAllTeamsAsync<TeamViewModel>(),
                League = await this.leaguesService.GetAllLeaguesAsync<LeagueViewModel>(),
                FeaturedPlayer = (await this.playersService.GetAllPlayersAsync<PlayerViewModel>()).FirstOrDefault(),
                FeaturedTeam = (await this.teamsService.GetAllTeamsAsync<TeamViewModel>()).FirstOrDefault(),
                FeaturedLeague = (await this.leaguesService.GetAllLeaguesAsync<LeagueViewModel>()).FirstOrDefault(),
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [Route("Error/404")]
        public IActionResult Error404()
        {
            return this.View();
        }

        [Route("Error/{code:int}")]
        public IActionResult Error(int code)
        {
            if (code == 404)
            {
                return this.RedirectToAction("Error404");
            }

            return this.View(code);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
