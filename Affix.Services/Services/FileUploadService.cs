using Affix.ServiceContract.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Affix.Services.Services
{
    public class FileUploadService : IFileUploadService
    {
        public async Task<string> UploadAsync(IFormCollection collection)
        {
            var file = collection.Files[0];
            var uniqueFileName = $"{Guid.NewGuid()}_{file.FileName}";
            var filePath = Path.Combine(@"E:\images", uniqueFileName);
            await using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return uniqueFileName;
        }
    }
}
