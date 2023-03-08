using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entities;

namespace ONGLIVES.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class InstitutionsController : ControllerBase
{

    [HttpGet("rota1")]
    public IActionResult Get()
    {
        Institution institution = new Institution();
        institution.Name = "Diego Enterprise";

        if (institution == null)
        {
            return BadRequest();
        }

        return Ok(institution);
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