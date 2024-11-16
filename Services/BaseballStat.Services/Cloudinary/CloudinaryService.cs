namespace BaseballStat.Services.Cloudinary
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Microsoft.AspNetCore.Http;

    public class CloudinaryService : ICloudinaryService
    {
        private Cloudinary cloudinary;

        public CloudinaryService(Cloudinary cloudinary)
        {
            this.cloudinary = cloudinary;
        }

        public async Task<string> UploadPictureAsync(IFormFile pictureFile, string fileName)
        {
            byte[] destinationData;

            using (var ms = new MemoryStream())
            {
                await pictureFile.CopyToAsync(ms);
                destinationData = ms.ToArray();
            }

            UploadResult uploadResult = null;

            using (var ms = new MemoryStream(destinationData))
            {
                ImageUploadParams uploadParams = new ImageUploadParams
                {
                    Folder = "images",
                    File = new FileDescription(fileName, ms),
                };

                uploadResult = await this.cloudinary.UploadAsync(uploadParams);
            }

            if (uploadResult == null)
            {
                throw new Exception("Upload to Cloudinary failed.");
            }

            if (uploadResult.SecureUrl == null)
            {
                throw new Exception("SecureUrl is null.");
            }

            return uploadResult.SecureUrl.AbsoluteUri;
        }
    }
}
