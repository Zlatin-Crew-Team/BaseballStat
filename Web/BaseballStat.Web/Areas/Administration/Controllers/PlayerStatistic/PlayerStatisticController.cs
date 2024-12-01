namespace BaseballStat.Web.Areas.Administration.Controllers.PlayerStatistic
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Services.Cloudinary;
    using BaseballStat.Services.Data.PlayerStattistic;
    using BaseballStat.Web.ViewModels.PlayerStatistic;
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

        public IActionResult AddPlayerStatistic(int playerId)
        {
            var model = new PlayerStatisticInputModel
            {
                PlayerId = playerId,
            };
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayerStatistic(PlayerStatisticInputModel input)
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
                    // Upload image to Cloudinary
                    imageUrl = await this.cloudinaryService.UploadPictureAsync(input.Image, $"{input.PlayerId}");
                }
            }
            catch (Exception)
            {
                this.TempData["ErrorMessage"] = "Failed to upload image. Using default placeholder.";
            }

            try
            {
                // Добавяне на статистиката чрез сървиса
                await this.playerStatisticService.AddPlayerStatistic(input, imageUrl);
            }
            catch (InvalidOperationException ex)
            {
                this.TempData["ErrorMessage"] = ex.Message;
                return this.View(input);
            }

            // Пренасочване към индекс страницата
            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePlayerStatistic(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.PlayerStatisticsCount)
            {
                this.TempData["ErrorMessage"] = "Cannot delete seeded player statistics.";
                return this.RedirectToAction("Index");
            }

            try
            {
                await this.playerStatisticService.DeletePlayerStatistic(id);
            }
            catch (InvalidOperationException ex)
            {
                this.TempData["ErrorMessage"] = ex.Message;
            }

            return this.RedirectToAction("Index");
        }
    }
}
