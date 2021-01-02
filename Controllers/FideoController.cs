using Microsoft.AspNetCore.Mvc;

namespace api_ef.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class FideoController : ControllerBase
    {
        public FideoController()
        {

        }

        [Route("GetName")]
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new { name = "Fideo" });
        }

    }
}