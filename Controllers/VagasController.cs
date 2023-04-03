using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;
using ONGLIVESAPI.Interfaces;

namespace ONGLIVES.API.Controllers;

[ApiController]
// [ApiVersion("1.0")]
// [Route("api/v{version:apiVersion}/[controller]")]
[Route("api/[controller]")]
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

    [HttpGet("{id}")]
    public IActionResult GetPorId(int id)
    {
        var vaga = _service.PegarPorId(id);

        if (vaga == null)
            return BadRequest();

        return Ok(vaga);
    }

    [HttpPost("")]
    public IActionResult Post(Vaga vaga)
    {
        if (vaga == null)
            return BadRequest();
        
        _service.Cadastrar(vaga);

        return Ok(vaga);
    }

    [HttpPut("")]
    public IActionResult Put(Vaga vaga)
    {
        if (vaga == null)
            return BadRequest();

        var vagaEdit = _service.Editar(vaga);

        return Ok(vagaEdit);
    }

    [HttpDelete("")]
    public IActionResult Delete(int id)
    {
        _service.Deletar(id);
        return Ok();
    }

}