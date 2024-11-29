namespace BaseballStat.Web.Controllers.Record
{
    using System.Threading.Tasks;

    using BaseballStat.Services.Data.Records;
    using BaseballStat.Web.ViewModels.Record;
    using Microsoft.AspNetCore.Mvc;

    public class RecordController : BaseController
    {
        private readonly IRecordService recordService;

        public RecordController(IRecordService recordService)
        {
            this.recordService = recordService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = await
                this.recordService.
                GetAllRecordsAsync<RecordViewModel>();
            return this.View(viewModel);
        }
    }
}
