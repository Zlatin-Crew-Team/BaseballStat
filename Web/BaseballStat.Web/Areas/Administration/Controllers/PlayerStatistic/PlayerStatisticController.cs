namespace BaseballStat.Web.Areas.Administration.Controllers.PlayerStatistic
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Common;

    using BaseballStat.Services.Cloudinary;
    using BaseballStat.Services.Data.PlayerStattistic;
    using BaseballStat.Web.ViewModels.Player;
    using BaseballStat.Web.ViewModels.PlayerStatistic;
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Microsoft.AspNetCore.Mvc;

    [Area("Administration")]
    public class PlayerStatisticController : AdministrationController
    {
        private readonly IPlayerStatisticService playerStatisticService;
        private readonly ICloudinaryService cloudinaryService;

        public PlayerStatisticController(IPlayerStatisticService playerStatisticService, ICloudinaryService cloudinaryService)
        {
            this.playerStatisticService = playerStatisticService;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 3)
        {
            var players = await this.playerStatisticService.GetAllPlayerStatisticsAsync<PlayerStatisticViewModel>();
            var count = players.Count();
            var items = players.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new PlayerStatisticListViewModel
            {
                PlayerStatistics = items,
                PageIndex = pageIndex,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize),
            };

            return this.View(viewModel);
        }

        public IActionResult AddPlayerStatistic()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayerStatistic(PlayerStatisticInputModel input)
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
                    PublicId = $"{input.PlayerId}",
                };

                var uploadResult = await this.cloudinaryService.UploadPictureAsync(input.Image, $"{input.PlayerId}");
                imageUrl = uploadResult;
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                imageUrl = GlobalConstants.Images.CloudinaryMissing;
            }

            // Добавяне на статистиката чрез сървиса
            await this.playerStatisticService.AddPlayerStatistic(input);

            // Пренасочване към индекс страницата
            return this.RedirectToAction(nameof(this.Index));
        }

        public async Task<IActionResult> DeletePlayerStatistic(int id)
        {
            try
            {
                await this.playerStatisticService.DeletePlayerStatisticAsync(id);
                return this.RedirectToAction(nameof(this.Index));
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, "Error deleting the player statistic: " + ex.Message);
                return this.RedirectToAction(nameof(this.Index));
            }
        }
    }
}
