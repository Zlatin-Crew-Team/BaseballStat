namespace BaseballStat.Web.Controllers.AllTimeGreat
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Services.Data.AllTimeGreat;
    using BaseballStat.Web.ViewModels.AllTimeGreat;
    using BaseballStat.Web.ViewModels.Award;
    using Microsoft.AspNetCore.Mvc;

    public class AllTimeGreatController : BaseController
    {
        private readonly IAllTimeGreatService allTimeGreatService;

        public AllTimeGreatController(IAllTimeGreatService allTimeGreatService)
        {
            this.allTimeGreatService = allTimeGreatService;
        }

        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 2)
        {
            var allTimeGreat = await this.allTimeGreatService.GetAllTimeGreatAsync<AllTimeGreatViewModel>();
            var count = allTimeGreat.Count();
            var items = allTimeGreat.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new AllTimeGreatListViewModel
            {
                AllTimeGreats = items,
                PageIndex = pageIndex,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize),
            };
            return this.View(viewModel);
        }
    }
}
