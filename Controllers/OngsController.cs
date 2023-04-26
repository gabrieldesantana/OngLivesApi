using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;
using ONGLIVESAPI.Interfaces;

namespace ONGLIVES.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class OngController : ControllerBase
{
    private readonly IOngService _service;
    public OngController(OngService service)
    {
        _service = service;
    }

    [ProducesResponseType((200), Type = typeof(List<Voluntario>))]
    [ProducesResponseType((404))]
    [HttpGet("")]
    public async Task<IActionResult> GetTodos()
    {
        var ong = await _service.PegarTodos();

        if (ong == null)
            return NotFound("Nenhum registro encontrado no sistema");

        return Ok(ong);
    }

    [ProducesResponseType((200), Type = typeof(Voluntario))]
    [ProducesResponseType((404))]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetPorId(int id)
    {
        var ong = await _service.PegarPorId(id);

        if (ong == null)
            return NotFound();

        return Ok(ong);
    }


    [ProducesResponseType((201), Type = typeof(Voluntario))]
    [ProducesResponseType((400))]
    [ProducesResponseType((404))]
    [HttpPost("")]
    public async Task<IActionResult> Post(Voluntario voluntario)
    {
        if (ong == null)
            return BadRequest();

        await _service.Cadastrar(ong);

        return CreatedAtAction("GetPorId", new { Id = voluntario.Id }, voluntario);
    }

    [ProducesResponseType((200), Type = typeof(Voluntario))]
    [ProducesResponseType((404))]
    [HttpPut("")]
    public async Task<IActionResult> Put(EditVoluntarioModel voluntario)
    {
        if (ong == null)
            return NotFound();

        var OngEdit = await _service.Editar(voluntario);

        if (OngEdit == null)
            return BadRequest();

        return Ok(OngEdit);
    }
    [ProducesResponseType((200))]
    [ProducesResponseType((400))]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var ong = await _service.Deletar(id);
        if (ong == false)
            return BadRequest();
        return Ok(ong);
    }

}