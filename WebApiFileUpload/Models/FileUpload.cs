using Microsoft.AspNetCore.Http;

namespace WebApiFileUpload.Models
{
    public class FileUpload
    {
        public IFormFile files { get; set; }
    }
}
