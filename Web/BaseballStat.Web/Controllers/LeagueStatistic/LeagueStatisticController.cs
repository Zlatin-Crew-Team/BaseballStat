namespace BaseballStat.Web.Controllers.LeagueStatistic
{
    using System.Threading.Tasks;

    using BaseballStat.Services.Data.League;
    using BaseballStat.Services.Data.LeagueStatistic;
    using BaseballStat.Web.ViewModels.LeagueStatistic;
    using Microsoft.AspNetCore.Mvc;

    public class LeagueStatisticController : Controller
    {
        private readonly ILeagueStatisticService leagueStatisticService;

        public LeagueStatisticController(ILeagueStatisticService leagueStatisticService)
        {
            this.leagueStatisticService = leagueStatisticService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var league = await this.leagueStatisticService.GetByIdAsync<LeagueStatisticViewModel>(id);
            return this.View();
        }
    }
}
