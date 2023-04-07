using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;
using ONGLIVES.API.VO;
using ONGLIVESAPI.Interfaces;

namespace ONGLIVES.API.Controllers;

[ApiController]
// [ApiVersion("1.0")]
// [Route("api/v{version:apiVersion}/[controller]")]
[Route("api/[controller]")]
public class ExperienciasController : ControllerBase
{
    private readonly IExperienciaService _service;
    public ExperienciasController(IExperienciaService service)
    {
        _service = service;
    }

    [HttpGet("")]
    public IActionResult Get()
    {
        var experiencias = _service.PegarTodos();

        if (experiencias == null)
        {
            return NotFound();
        }

        return Ok(experiencias);

    }


    [HttpGet("{id}")]
    public IActionResult GetPorId(int id)
    {
        var experiencias = _service.PegarPorId(id);

        if (experiencias == null)
            return BadRequest();

        return Ok(experiencias);
    }


    [HttpPost("")]
    public IActionResult Post(Experiencia experiencia)
    {
        if (experiencia == null)
            return BadRequest();

        _service.Cadastrar(experiencia);

        return Ok(experiencia);
    }

    [HttpPut("")]
    public IActionResult Put(Experiencia experiencia)
    {
        if (experiencia == null)
            return BadRequest();

        var experienciaEdit = _service.Editar(experiencia);

        return Ok(experienciaEdit);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Deletar(id);
        return Ok();
    }

}