using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.RetailManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        [HttpGet("Result")]
        public IActionResult result()
        {
            return Ok("Done");
        }
    }
}
