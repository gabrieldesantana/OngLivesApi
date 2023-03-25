using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entidades;

namespace ONGLIVES.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class VagasController : ControllerBase
{
    
    [HttpGet("")]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpPost("")]
    public IActionResult Post()
    {
        return Ok();
    }

    [HttpPut("")]
    public IActionResult Put()
    {
        return Ok();
    }

    [HttpDelete("")]
    public IActionResult Delete()
    {
        return Ok();
    }

}