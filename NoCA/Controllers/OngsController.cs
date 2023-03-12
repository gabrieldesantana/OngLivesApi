using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entidades;
using ONGLIVESAPI.Interfaces;

namespace ONGLIVES.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class InstitutionsController : ControllerBase
{
    private readonly IOngService _service;
    public InstitutionsController(IOngService service)
    {
        _service = service;
    }

    [HttpGet("rota1")]
    public IActionResult Get()
    {
        Ong ong = new Ong();
        ong.Nome = "Diego Enterprise";
        
        if (ong == null)
        {
            return BadRequest();
        }

        return Ok(ong);
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