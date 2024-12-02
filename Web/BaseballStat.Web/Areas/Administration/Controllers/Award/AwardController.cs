namespace BaseballStat.Web.Areas.Administration.Controllers.Award
{
    using Microsoft.AspNetCore.Mvc;

    [Area("Administration")]
    public class AwardController : AdministrationController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
