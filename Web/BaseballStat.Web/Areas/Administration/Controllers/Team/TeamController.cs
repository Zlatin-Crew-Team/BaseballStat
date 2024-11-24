namespace BaseballStat.Web.Areas.Administration.Controllers.Team
{
    using System;
    using System.Linq;
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

        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 3)
        {
            var teams = await this.teamService.GetAllTeamsAsync<TeamViewModel>();
            var count = teams.Count();
            var items = teams.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new TeamListViewModel
            {
                Teams = items,
                PageIndex = pageIndex,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize),
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

            await this.teamService.AddAsync(input.Name, input.City, input.FoundedYear, logoUrl, input.Owner, input.Stadium, input.LeagueId);
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
    }
}
