namespace BaseballStat.Web.Areas.Administration.Controllers.Record
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BaseballStat.Common;
    using BaseballStat.Services.Cloudinary;
    using BaseballStat.Services.Data.Records;
    using BaseballStat.Web.ViewModels.AllTimeGreat;
    using BaseballStat.Web.ViewModels.Record;
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Microsoft.AspNetCore.Mvc;

    [Area("Administration")]
    public class RecordController : AdministrationController
    {
        private readonly IRecordService recordService;
        private readonly ICloudinaryService cloudinaryService;

        public RecordController(IRecordService recordService, ICloudinaryService cloudinaryService)
        {
            this.recordService = recordService;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IActionResult> Index(int pageIndex = 1, int pageSize = 3)
        {
            var record = await this.recordService.GetAllRecordsAsync<RecordViewModel>();
            var count = record.Count();
            var items = record.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new RecordListViewModel
            {
                Record = items,
                PageIndex = pageIndex,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize),
            };
            return this.View(viewModel);
        }

        public IActionResult AddRecord()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRecord(RecordInputModel input)
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
                    PublicId = $"{input.Holder}",
                };

                var uploadResult = await this.cloudinaryService.UploadPictureAsync(input.Image, $"{input.Holder}");
                imageUrl = uploadResult;
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                imageUrl = GlobalConstants.Images.CloudinaryMissing;
            }

            const int fixedCategoryId = 2;

            await this.recordService.AddRecord(input.Id, input.Holder, input.Description, imageUrl, input.RecordTypeId, fixedCategoryId);
            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await this.recordService.DeleteRecordAsync(id);
            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
