using CoSmellRefine.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CoSmellRefine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IMediaRepository mediaRepository;

        public MediaController(IMediaRepository mediaRepository)
        {
            this.mediaRepository = mediaRepository;
        }


        [HttpPost]
        public async Task<IActionResult> UploadAsync(IFormFile file)
        {
   
            var mediaURL = await mediaRepository.UploadAzureAsync(file);

            if (mediaURL == null)
            {
                return Problem("Sometihng went wrong!", null, (int)HttpStatusCode.InternalServerError);
            }

            return new JsonResult(new { link = mediaURL });
        }
    }
}
