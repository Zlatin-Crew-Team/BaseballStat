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

            string imageUrl;
            try
            {
                // Upload image to Cloudinary
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(input.Image.FileName, input.Image.OpenReadStream()),
                    PublicId = $"{input.FirstName}_{input.LastName}",
                };

                var uploadResult = await this.cloudinaryService.UploadPictureAsync(input.Image, $"{input.FirstName}_{input.LastName}");
                imageUrl = uploadResult;
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                imageUrl = GlobalConstants.Images.CloudinaryMissing;
            }

            await this.playerService.AddPlayerAsync(input.FirstName, input.LastName, input.Position, input.Bats, input.Throws, input.YearOfBirth, input.TeamId, imageUrl);
            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.PlayersCount)
            {
                return this.RedirectToAction("Index");
            }

            await this.playerService.DeletePlayerAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
