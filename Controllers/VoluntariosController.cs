using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;
using ONGLIVESAPI.Interfaces;

namespace ONGLIVES.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class VoluntariosController : ControllerBase
{
    private readonly IVoluntarioService _service;
    public VoluntariosController(IVoluntarioService service)
    {
        _service = service;
    }

    [HttpGet("")]
    public IActionResult Get()
    {
        var voluntarios = _service.PegarTodos();

        if (voluntarios == null)
        {
            return NotFound();
        }

        return Ok(voluntarios);

    }

    [HttpGet("{id}")]
    public IActionResult GetPorId(int id) 
    {
        var voluntario = _service.PegarPorId(id);

        if (voluntario == null) 
            return BadRequest();

        return Ok(voluntario);
    }

    [HttpPost("")]
    public IActionResult Post(Voluntario voluntario)
    {
        if (voluntario == null)
            return BadRequest();
        
        _service.Cadastrar(voluntario);

        return Ok(voluntario);
    }

    [HttpPut("")]
    public IActionResult Put(Voluntario voluntario)
    {
        if (voluntario == null)
            return BadRequest();

        var voluntarioEdit = _service.Editar(voluntario);

        return Ok(voluntarioEdit);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Deletar(id);
        return Ok();
    }

}