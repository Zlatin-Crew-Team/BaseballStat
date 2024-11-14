namespace BaseballStat.Web.Controllers.TeamStatistic
{
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

        public IActionResult Index()
        {
            var team = this.teamStatisticService.GetAllTeamStatisticsAsync<TeamStatisticViewModel>();
            return this.View(team);
        }
    }
}
