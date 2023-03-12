using Microsoft.AspNetCore.Mvc;
using OngLives.Core.Entidades;

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
            // var voluntary = new Voluntary();
               
            return Ok();
        }
    }
}