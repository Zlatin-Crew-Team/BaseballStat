namespace BaseballStat.Web.Areas.Administration.Controllers.Player
{
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

        public async Task<IActionResult> Index()
        {
            var viewModel = new PlayerListViewModel
            {
                Players = await this.playerService.GetAllPlayersAsync<PlayerViewModel>(),
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

            await this.playerService.AddPlayerAsync(input.FirstName, input.LastName, input.Position, input.Bats, input.Throws, imageUrl);
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
