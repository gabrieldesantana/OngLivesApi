using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;
using ONGLIVESAPI.Interfaces;

namespace ONGLIVES.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class VagasController : ControllerBase
{
    private readonly IVagaService _service;
    public VagasController(IVagaService service)
    {
        _service = service;
    }

    [HttpGet("")]
    public IActionResult Get()
    {
        // var voluntarios = _service.PegarTodos();

        // if (voluntarios == null)
        // {
        //     return NotFound();
        // }

        return Ok();

    }


    [HttpPost("")]
    public IActionResult Post(Vaga voluntario)
    {
        if (voluntario == null)
            return BadRequest();
        
        // _service.Cadastrar(voluntario);

        return Ok(voluntario);
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