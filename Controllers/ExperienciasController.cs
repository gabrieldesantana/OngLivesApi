using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;
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

    [ProducesResponseType((200), Type = typeof(List<Experiencia>))]
    [ProducesResponseType((404))]
    [HttpGet("")]
    public async Task<IActionResult> GetTodos()
    {
        var experiencias = await _service.PegarTodos();

        if (experiencias == null)
            return NotFound("Nenhum registro encontrado no sistema");

        return Ok(experiencias);
    }

    [ProducesResponseType((200), Type = typeof(Experiencia))]
    [ProducesResponseType((404))]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetPorId(int id) 
    {
        var experiencia = await _service.PegarPorId(id);

        if (experiencia == null) 
            return NotFound();

        return Ok(experiencia);
    }

    [ProducesResponseType((201), Type = typeof(Experiencia))]
    [ProducesResponseType((400))]
    [ProducesResponseType((404))]
    [HttpPost("")]
    public async Task<IActionResult> Post(InputExperienciaModel inputExperienciaModel)
    {
        if (inputExperienciaModel == null)
            return BadRequest();
        
        var experiencia = new Experiencia 
        {
        NomeVoluntario = inputExperienciaModel.NomeVoluntario,
        SobrenomeVoluntario = inputExperienciaModel.SobrenomeVoluntario,
        NomeOng = inputExperienciaModel.NomeOng,
        ProjetoEnvolvido = inputExperienciaModel.ProjetoEnvolvido,
        Opiniao = inputExperienciaModel.Opiniao,
        DataPostagem = DateTime.Now,
        DataExperienciaInicio = inputExperienciaModel.DataExperienciaInicio,
        DataExperienciaFim = inputExperienciaModel.DataExperienciaFim
        };

        experiencia = await _service.Cadastrar(experiencia);

        return CreatedAtAction("GetPorId", new {Id = experiencia.Id} , experiencia);
    }


    [ProducesResponseType((200), Type = typeof(EditExperienciaModel))]
    [ProducesResponseType((404))]
    [HttpPut("")]
    public async Task<IActionResult> Put(EditExperienciaModel experiencia)
    {
        if (experiencia == null)
            return NotFound();

        var experienciaEdit = await _service.Editar(experiencia);

        if (experienciaEdit == null)
            return BadRequest();

        return Ok(experienciaEdit);
    }

    [ProducesResponseType((200))]
    [ProducesResponseType((400))]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var experiencia = await _service.Deletar(id);
        if (experiencia == false)
            return BadRequest();
        return Ok(experiencia);
    }

}