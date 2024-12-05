namespace BaseballStat.Web.Areas.Administration.Controllers.TeamStatistic
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Data.Common.Repositories;
    using BaseballStat.Data.Models;
    using BaseballStat.Services.Data.TeamStatistic;
    using BaseballStat.Web.ViewModels.TeamStatistic;
    using Microsoft.AspNetCore.Mvc;

    [Area("Administration")]
    public class TeamStatisticController : AdministrationController
    {
        private readonly ITeamStatisticService teamStatisticService;

        public TeamStatisticController(ITeamStatisticService teamStatisticService)
        {
            this.teamStatisticService = teamStatisticService;
        }

        // GET: /Administration/TeamStatistic/Index
        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 3)
        {
            var teams = await this.teamStatisticService.GetAllTeamStatisticsAsync<TeamStatisticViewModel>();
            var count = teams.Count();
            var items = teams.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new TeamStatisticListViewModel
            {
                TeamStatistics = items,
                PageIndex = pageIndex,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize),
            };

            return this.View(viewModel);
        }

        public IActionResult AddTeamStatistic()
        {
            var model = new TeamStatisticInput(); // Използваме Input модел за формата
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddTeamStatistic(TeamStatisticInput model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                // Добавяне на нова статистика чрез сервиза
                await this.teamStatisticService.AddTeamStatisticAsync(model.TeamId, model.Games, model.Wins, model.Losses, model.Titles);

                this.TempData["SuccessMessage"] = "Team statistic added successfully.";
                return this.RedirectToAction(nameof(this.Index));
            }
            catch (Exception ex)
            {
                this.TempData["ErrorMessage"] = ex.Message;
                return this.View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTeamStatistic(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.TeamStatisticsCount)
            {
                this.TempData["ErrorMessage"] = "Cannot delete seeded team statistics.";
                return this.RedirectToAction(nameof(this.Index));
            }

            try
            {
                await this.teamStatisticService.DeleteTeamStatisticAsync(id);
                this.TempData["SuccessMessage"] = "Team statistic deleted successfully.";
            }
            catch (InvalidOperationException ex)
            {
                this.TempData["ErrorMessage"] = ex.Message;
            }

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
