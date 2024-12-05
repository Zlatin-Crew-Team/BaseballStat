namespace BaseballStat.Web.Areas.Administration.Controllers.LeagueStatistic
{
    using Microsoft.AspNetCore.Mvc;

    [Area("Administration")]
    public class LeagueControllerStatistic : AdministrationController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
