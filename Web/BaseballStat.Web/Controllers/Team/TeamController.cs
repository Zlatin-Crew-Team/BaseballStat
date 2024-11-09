namespace BaseballStat.Web.Controllers.TeamController
{
    using System.Threading.Tasks;

    using BaseballStat.Services.Data.Teams;
    using BaseballStat.Web.ViewModels.Player;
    using BaseballStat.Web.ViewModels.Team;
    using Microsoft.AspNetCore.Mvc;

    public class TeamController : BaseController
    {
        private readonly ITeamService teamService;

        public TeamController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new TeamListViewModel
            {
                Teams = await this.teamService.GetAllTeamsAsync<TeamViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
