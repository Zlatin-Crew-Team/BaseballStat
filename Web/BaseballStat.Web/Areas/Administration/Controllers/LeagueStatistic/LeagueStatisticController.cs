namespace BaseballStat.Web.Areas.Administration.Controllers.LeagueStatistic
{
    using System;
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Services.Data.LeagueStatistic;
    using BaseballStat.Web.ViewModels.League;
    using BaseballStat.Web.ViewModels.LeagueStatistic;
    using BaseballStat.Web.ViewModels.TeamStatistic;
    using Microsoft.AspNetCore.Mvc;

    [Area("Administration")]
    public class LeagueStatisticController : AdministrationController
    {
        private readonly ILeagueStatisticService leagueStatisticService;

        public LeagueStatisticController(ILeagueStatisticService leagueStatisticService)
        {
            this.leagueStatisticService = leagueStatisticService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new LeagueStatisticListViewModel
            {
                LeagueStatistics = await this.leagueStatisticService.GetAllLeagueStatisticsAsync<LeagueStatisticViewModel>(),
            };

            return this.View(viewModel);
        }

        public IActionResult AddLeagueStatistic(int leagueId)
        {
            var model = new LeagueStatisticInputModel
            {
                LeagueId = leagueId,
            };
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddLeagueStatistic(LeagueStatisticInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                // Добавяне на нова статистика чрез сервиза
                await this.leagueStatisticService.AddLeagueStatisticAsync(model.LeagueId, model.Games, model.Wins, model.Losses, model.Titles);

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
        public async Task<IActionResult> DeleteLeagueStatistic(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.LeagueStatisticsCount)
            {
                this.TempData["ErrorMessage"] = "Cannot delete seeded player statistics.";
                return this.RedirectToAction("Index");
            }

            try
            {
                await this.leagueStatisticService.DeleteLeagueStatisticAsync(id);
            }
            catch (InvalidOperationException ex)
            {
                this.TempData["ErrorMessage"] = ex.Message;
            }

            return this.RedirectToAction("Index");
        }
    }
}
