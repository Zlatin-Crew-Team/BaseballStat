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
    }
}
