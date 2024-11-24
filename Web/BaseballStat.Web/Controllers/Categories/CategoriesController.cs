namespace BaseballStat.Web.Controllers.Categories
{
    using System.Threading.Tasks;

    using BaseballStat.Services.Data.Categories;
    using BaseballStat.Web.ViewModels.Category;
    using Microsoft.AspNetCore.Mvc;

    public class CategoriesController : BaseController
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new CategoriesListViewModel
            {
                Categories = await this.categoriesService.GetAllAsync<CategoryViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var award = new CategoryAwardViewModel
            {
                PlayerName = "Shohei Othani",
                TeamName = "Los Angeles Dodgers",
                AwardName = "MVP",
                Year = 2024,
            };

            return this.View(award);
        }
    }
}
