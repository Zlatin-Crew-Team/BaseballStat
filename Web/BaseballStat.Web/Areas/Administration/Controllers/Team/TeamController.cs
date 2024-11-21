namespace BaseballStat.Web.Areas.Administration.Controllers.Team
{
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Services.Cloudinary;
    using BaseballStat.Services.Data.Teams;
    using BaseballStat.Web.ViewModels.Team;
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Microsoft.AspNetCore.Mvc;

    [Area("Administration")]
    public class TeamController : AdministrationController
    {
        private readonly ITeamService teamService;
        private readonly ICloudinaryService cloudinaryService;

        public TeamController(ITeamService teamService, ICloudinaryService cloudinaryService)
        {
            this.teamService = teamService;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new TeamListViewModel
            {
                Teams = await this.teamService.GetAllTeamsAsync<TeamViewModel>(),
            };

            return this.View(viewModel);
        }

        public IActionResult AddTeam()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTeam(TeamInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string logoUrl;
            try
            {
                // Upload logo to Cloudinary
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(input.Logo.FileName, input.Logo.OpenReadStream()),
                    PublicId = $"{input.Name}_logo",
                };

                var uploadResult = await this.cloudinaryService.UploadPictureAsync(input.Logo, $"{input.Name}_logo");
                logoUrl = uploadResult;
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                logoUrl = GlobalConstants.Images.CloudinaryMissing;
            }

            await this.teamService.AddAsync(input.Name, input.City, input.FoundedYear, logoUrl, input.Owner, input.Stadium,input.LeagueId);
            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.TeamsCount)
            {
                return this.RedirectToAction("Index");
            }

            await this.teamService.DeleteTeamAsync(id);

            return this.RedirectToAction("Index");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTeam(int id, TeamInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string logoUrl;
            try
            {
                // Upload logo to Cloudinary if a new logo is provided
                if (input.Logo != null)
                {
                    var uploadParams = new ImageUploadParams
                    {
                        File = new FileDescription(input.Logo.FileName, input.Logo.OpenReadStream()),
                        PublicId = $"{input.Name}_logo",
                    };

                    var uploadResult = await this.cloudinaryService.UploadPictureAsync(input.Logo, $"{input.Name}_logo");
                    logoUrl = uploadResult;
                }
                else
                {
                    // If no new logo is provided, retain the existing logo URL
                    var existingTeam = await this.teamService.GetByIdAsync<TeamViewModel>(id);
                    logoUrl = existingTeam.LogoUrl;
                }
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                logoUrl = GlobalConstants.Images.CloudinaryMissing;
            }

            await this.teamService.UpdateTeamAsync(id, input.Name, input.City, input.FoundedYear, logoUrl, input.Owner, input.Stadium);
            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
