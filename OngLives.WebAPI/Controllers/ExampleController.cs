using Microsoft.AspNetCore.Mvc;

namespace OngLives.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExampleController : ControllerBase
    {
        public ExampleController()
        {
           
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}