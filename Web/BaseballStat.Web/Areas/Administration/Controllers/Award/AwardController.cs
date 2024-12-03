namespace BaseballStat.Web.Areas.Administration.Controllers.Award
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Services.Cloudinary;
    using BaseballStat.Services.Data.Award;
    using BaseballStat.Web.ViewModels.Award;
    using Microsoft.AspNetCore.Mvc;

    [Area("Administration")]
    public class AwardController : AdministrationController
    {
        private readonly IAwardService awardService;
        private readonly ICloudinaryService cloudinaryService;

        public AwardController(IAwardService awardService, ICloudinaryService cloudinaryService)
        {
            this.awardService = awardService;
            this.cloudinaryService = cloudinaryService;
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
