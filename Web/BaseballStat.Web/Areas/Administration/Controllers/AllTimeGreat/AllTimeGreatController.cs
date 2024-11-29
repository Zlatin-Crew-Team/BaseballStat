namespace BaseballStat.Web.Areas.Administration.Controllers.AllTimeGreat
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Services.Cloudinary;
    using BaseballStat.Services.Data.AllTimeGreat;
    using BaseballStat.Services.Data.Award;
    using BaseballStat.Web.ViewModels.AllTimeGreat;
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Microsoft.AspNetCore.Mvc;

    [Area("Administration")]
    public class AllTimeGreatController : AdministrationController
    {
        private readonly IAllTimeGreatService allTimeGreatService;
        private readonly ICloudinaryService cloudinaryService;

        public AllTimeGreatController(IAllTimeGreatService allTimeGreatService, ICloudinaryService cloudinaryService)
        {
            this.allTimeGreatService = allTimeGreatService;
            this.cloudinaryService = cloudinaryService;
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

        public IActionResult AddAllTimeGreat()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAllTimeGreatAsync(AllTimeGreatInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string imageUrl;
            try
            {
                // Upload image to Cloudinary
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(input.Image.FileName, input.Image.OpenReadStream()),
                    PublicId = $"{input.Name}",
                };

                var uploadResult = await this.cloudinaryService.UploadPictureAsync(input.Image, $"{input.Name}");
                imageUrl = uploadResult;
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                imageUrl = GlobalConstants.Images.CloudinaryMissing;
            }

            await this.allTimeGreatService.AddAllTimeGreatAsync(input.Id,input.Name, input.Bio, imageUrl);
            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.AllTimeGreats)
            {
                return this.RedirectToAction("Index");
            }

            await this.allTimeGreatService.DeleteAllTimeGreatAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
