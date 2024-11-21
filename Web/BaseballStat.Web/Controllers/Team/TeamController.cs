namespace BaseballStat.Web.Controllers.TeamController
{
    using System;
    using System.Linq;
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

        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 3)
        {
            var teams = await this.teamService.GetAllTeamsAsync<TeamViewModel>();
            var count = teams.Count();
            var items = teams.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new TeamListViewModel
            {
                Teams = items,
                PageIndex = pageIndex,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize),
            };

            return this.View(viewModel);
        }
    }
}
