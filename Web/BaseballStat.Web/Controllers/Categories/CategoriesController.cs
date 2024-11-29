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

        // Action to redirect to Awards
        public IActionResult Award(int id)
        {
            return this.RedirectToAction("Index", "Award", new { id });
        }

        // Action to redirect to Records
        public IActionResult Records(int id)
        {
            return this.RedirectToAction("Index", "Records", new { id });
        }

        // Action to redirect to All Time Great
        public IActionResult AllTimeGreat(int id)
        {
            return this.RedirectToAction("Index", "AllTimeGreat", new { id });
        }
    }
}
