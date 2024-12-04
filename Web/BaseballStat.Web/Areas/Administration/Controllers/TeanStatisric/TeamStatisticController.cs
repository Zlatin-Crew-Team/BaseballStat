namespace BaseballStat.Web.Areas.Administration.Controllers.TeanStatisric
{
    using Microsoft.AspNetCore.Mvc;

    public class TeamStatisticController : AdministrationController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
