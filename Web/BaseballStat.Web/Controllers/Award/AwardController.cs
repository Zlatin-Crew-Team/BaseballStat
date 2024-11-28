namespace BaseballStat.Web.Controllers.Award
{
    using System.Threading.Tasks;

    using BaseballStat.Services.Data.Award;
    using BaseballStat.Web.ViewModels.Award;
    using BaseballStat.Web.ViewModels.Category;
    using Microsoft.AspNetCore.Mvc;

    public class AwardController : BaseController
    {
        private readonly IAwardService awardService;

        public AwardController(IAwardService awardService)
        {
            this.awardService = awardService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new AwardListViewModel
            {
                Awards = await this.awardService.GetAllAsync<AwardViewModel>(),
            };
            return this.View(viewModel);
        }
    }
}
