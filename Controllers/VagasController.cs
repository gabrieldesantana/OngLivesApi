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
        var vagas = _service.PegarTodos();

        if (vagas == null)
        {
            return NotFound();
        }

        return Ok(vagas);

    }


    [HttpPost("")]
    public IActionResult Post(Vaga vaga)
    {
        if (vaga == null)
            return BadRequest();
        
        // _service.Cadastrar(voluntario);

        return Ok(vaga);
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