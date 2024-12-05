namespace BaseballStat.Web.Controllers.TeamStatistic
{
    using System.Threading.Tasks;

    using BaseballStat.Services.Data.TeamStatistic;
    using BaseballStat.Web.ViewModels.TeamStatistic;
    using Microsoft.AspNetCore.Mvc;

    public class TeamStatisticController : Controller
    {
        private readonly ITeamStatisticService teamStatisticService;

        public TeamStatisticController(ITeamStatisticService teamStatisticService)
        {
            this.teamStatisticService = teamStatisticService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var team = await this.teamStatisticService.GetAllTeamStatisticsAsync<TeamStatisticViewModel>(id);
            return this.View(team);
        }
    }
}
