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

    [ProducesResponseType((200), Type= typeof(List<Vaga>))]
    [ProducesResponseType((404))]
    [HttpGet("")]
    public async Task<IActionResult> GetTodos()
    {
        var vagas = await _service.PegarTodos();

        if (vagas == null)
            return NotFound("Nenhum resgistro encontrado no sistema");

        return Ok(vagas);
    }

    [ProducesResponseType((200), Type= typeof(Vaga))]
    [ProducesResponseType((404))]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetPorId(int id)
    {
        var vaga = await _service.PegarPorId(id);

        if (vaga == null)
            return NotFound();

        return Ok(vaga);
    }

    [ProducesResponseType((201), Type= typeof(Vaga))]
    [ProducesResponseType((400))]
    [ProducesResponseType((404))]
    [HttpPost("")]
    public async Task<IActionResult> Post(Vaga vaga)
    {
        if (vaga == null)
            return BadRequest();
        
        await _service.Cadastrar(vaga);

        return CreatedAtAction("GetPorId", new {Id = vaga.Id}, vaga);
    }

    [ProducesResponseType((200), Type= typeof(Vaga))]
    [ProducesResponseType((404))]
    [HttpPut("")]
    public async Task<IActionResult> Put(EditVagaModel vaga)
    {
        if (vaga == null)
            return NotFound();

        var vagaEdit = await _service.Editar(vaga);

        if (vagaEdit == null)
            return BadRequest();
        
        return Ok(vagaEdit);
    }

    [ProducesResponseType((200))]
    [ProducesResponseType((400))]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var vaga = await _service.Deletar(id);
        if (vaga == false)
            return BadRequest();
        return Ok(vaga);
    }

}