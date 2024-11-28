namespace BaseballStat.Web.Controllers.Award
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Services.Data.Award;
    using BaseballStat.Web.ViewModels.Award;
    using BaseballStat.Web.ViewModels.Category;
    using BaseballStat.Web.ViewModels.Player;
    using Microsoft.AspNetCore.Mvc;

    public class AwardController : BaseController
    {
        private readonly IAwardService awardService;

        public AwardController(IAwardService awardService)
        {
            this.awardService = awardService;
        }

        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 2)
        {
            var awardedPlayers = await this.awardService.GetAllAwardAsync<AwardViewModel>();
            var count = awardedPlayers.Count();
            var items = awardedPlayers.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new AwardListViewModel
            {
                Awards = items,
                PageIndex = pageIndex,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize),
            };
            return this.View(viewModel);
        }
    }
}
