namespace BaseballStat.Web.Areas.Administration.Controllers.Award
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Common;
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

        public IActionResult AddAward()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAward(AwardInputModel input)
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
                    imageUrl = await this.cloudinaryService.UploadPictureAsync(input.Image, $"{input.Description}");
                }
            }
            catch (Exception)
            {
                this.TempData["ErrorMessage"] = "Failed to upload image. Default placeholder will be used.";
            }

            try
            {
                await this.awardService.AddAwardAsync(input, imageUrl);
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
        public async Task<IActionResult> DeleteAward(int id)
        {
            try
            {
                await this.awardService.DeleteAwardAsync(id);
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
