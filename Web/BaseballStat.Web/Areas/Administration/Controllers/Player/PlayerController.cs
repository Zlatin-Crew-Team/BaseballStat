namespace BaseballStat.Web.Areas.Administration.Controllers.Player
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Services.Cloudinary;
    using BaseballStat.Services.Data.Player;
    using BaseballStat.Web.ViewModels.Player;
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Microsoft.AspNetCore.Mvc;

    [Area("Administration")]
    public class PlayerController : AdministrationController
    {
        private readonly IPlayerService playerService;
        private readonly ICloudinaryService cloudinaryService;

        public PlayerController(IPlayerService playerService, ICloudinaryService cloudinaryService)
        {
            this.playerService = playerService;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 3)
        {
            var players = await this.playerService.GetAllPlayersAsync<PlayerViewModel>();
            var count = players.Count();
            var items = players.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new PlayerListViewModel
            {
                Players = items,
                PageIndex = pageIndex,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize),
            };

            return this.View(viewModel);
        }

        public IActionResult AddPlayer()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayer(PlayerInputModel input)
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
                    imageUrl = await this.cloudinaryService.UploadPictureAsync(input.Image, $"{input.FirstName}_{input.LastName}");
                }
            }
            catch (Exception)
            {
                this.TempData["ErrorMessage"] = "Failed to upload image. Default placeholder will be used.";
            }

            try
            {
                var playerId = await this.playerService.AddPlayerAsync(
                    input.FirstName,
                    input.LastName,
                    input.Position,
                    input.Bats,
                    input.Throws,
                    input.YearOfBirth,
                    input.TeamId,
                    imageUrl);

                this.TempData["SuccessMessage"] = "Player added successfully!";
                return this.RedirectToAction("AddPlayerStatistic", "PlayerStatistic", new { playerId });
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "An error occurred while adding the player.");
                return this.View(input);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            try
            {
                await this.playerService.DeletePlayerAsync(id);
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
