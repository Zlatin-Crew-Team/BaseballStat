namespace BaseballStat.Web.ViewModels.Common.CustomValidationAttributes
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    public class ValidateImageFileAttribute : RequiredAttribute
    {
        private const int MaxFileLenghtInBytes = 1048576; // = ( 1*1024*1024 ) = 1MB;

        public override bool IsValid(object value)
        {
            IFormFile file = value as IFormFile;

            if (file == null)
            {
                return true;
            }

            if (file.Length > MaxFileLenghtInBytes)
            {
                return false;
            }

            // check the image mime types
            if (file.ContentType.ToLower() != "image/jpg"
                 && file.ContentType.ToLower() != "image/jpeg"
                 && file.ContentType.ToLower() != "image/png")
            {
                return false;
            }

            return true;
        }
    }
}
