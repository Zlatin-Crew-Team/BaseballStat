namespace BaseballStat.Web.Areas.Administration.Controllers.League
{
    using System;
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Services.Cloudinary;
    using BaseballStat.Services.Data.League;
    using BaseballStat.Web.ViewModels.League;
    using Microsoft.AspNetCore.Mvc;

    [Area("Administration")]
    public class LeagueController : AdministrationController
    {
        private readonly ILeagueService leagueService;
        private readonly ICloudinaryService cloudinaryService;

        public LeagueController(ILeagueService leagueService, ICloudinaryService cloudinaryService)
        {
            this.leagueService = leagueService;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new LeagueListViewModel
            {
                Leagues = await this.leagueService.GetAllLeaguesAsync<LeagueViewModel>(),
            };

            return this.View(viewModel);
        }

        public IActionResult AddLeague()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddLeague(LeagueInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string imageUrl = GlobalConstants.Images.CloudinaryMissing;
            try
            {
                if (input.Image != null)
                {
                    imageUrl = await this.cloudinaryService.UploadPictureAsync(input.Image, $"{input.Name}");
                }
            }
            catch (Exception)
            {
                this.TempData["ErrorMessage"] = "Failed to upload image. Default placeholder will be used.";
            }

            try
            {
                await this.leagueService.AddAsync(input.Name, imageUrl);
                this.TempData["SuccessMessage"] = "League added successfully!";
                return this.RedirectToAction("Index");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "An error occurred while adding the league.");
                return this.View(input);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteLeague(int id)
        {
            try
            {
                await this.leagueService.DeleteAsync(id);
                return this.RedirectToAction("Index");
            }
            catch (InvalidOperationException ex)
            {
                this.TempData["ErrorMessage"] = ex.Message;
                return this.RedirectToAction("Index");
            }
        }
    }
}
