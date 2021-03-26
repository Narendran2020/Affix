using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Affix.ServiceContract.Services
{
     public interface IFileUploadService
    {
        Task<string> UploadAsync(IFormCollection collection);
    }
}
