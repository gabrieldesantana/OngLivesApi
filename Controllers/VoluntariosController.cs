using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;
using ONGLIVESAPI.Interfaces;

namespace ONGLIVES.API.Controllers;

[ApiController]
// [ApiVersion("1.0")]
// [Route("api/v{version:apiVersion}/[controller]")]
[Route("api/[controller]")]
public class VoluntariosController : ControllerBase
{
    private readonly IVoluntarioService _service;
    public VoluntariosController(IVoluntarioService service)
    {
        _service = service;
    }

    [ProducesResponseType((200), Type = typeof(List<Voluntario>))]
    [ProducesResponseType((404))]
    [HttpGet("")]
    public async Task<IActionResult> GetTodos()
    {
        var voluntarios = await _service.PegarTodos();

        if (voluntarios == null)
            return NotFound("Nenhum registro encontrado no sistema");

        return Ok(voluntarios);
    }

    [ProducesResponseType((200), Type = typeof(Voluntario))]
    [ProducesResponseType((404))]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetPorId(int id) 
    {
        var voluntario = await _service.PegarPorId(id);

        if (voluntario == null) 
            return NotFound();

        return Ok(voluntario);
    }

    [ProducesResponseType((201), Type = typeof(Voluntario))]
    [ProducesResponseType((400))]
    [ProducesResponseType((404))]
    [HttpPost("")]
    public async Task<IActionResult> Post(InputVoluntarioModel inputVoluntarioModel)
    {
        if (inputVoluntarioModel == null)
            return BadRequest();

        var voluntario = new Voluntario 
        {

        Nome = inputVoluntarioModel.Nome,
        Sobrenome = inputVoluntarioModel.Sobrenome,
        CPF = inputVoluntarioModel.CPF,
        DataNascimento = inputVoluntarioModel.DataNascimento,

        Escolaridade = inputVoluntarioModel.Escolaridade,
        Genero = inputVoluntarioModel.Genero,
        Email = inputVoluntarioModel.Email,
        Telefone = inputVoluntarioModel.Telefone,
        Habilidade = inputVoluntarioModel.Habilidade,
        Avaliacao = inputVoluntarioModel.Avaliacao,
        HorasVoluntaria = inputVoluntarioModel.HorasVoluntaria,
        QuantidadeExperiencias = inputVoluntarioModel.QuantidadeExperiencias,
        Endereco = inputVoluntarioModel.Endereco,

        Id = inputVoluntarioModel.Id
        };
        
        await _service.Cadastrar(voluntario);

        return CreatedAtAction("GetPorId", new {Id = voluntario.Id} , voluntario);
    }

    [ProducesResponseType((200), Type = typeof(EditVoluntarioModel))]
    [ProducesResponseType((404))]
    [HttpPut("")]
    public async Task<IActionResult> Put(EditVoluntarioModel voluntario)
    {
        if (voluntario == null)
            return NotFound();

        var voluntarioEdit = await _service.Editar(voluntario);

        if (voluntarioEdit == null)
            return BadRequest();

        return Ok(voluntarioEdit);
    }

    [ProducesResponseType((200))]
    [ProducesResponseType((400))]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var voluntario = await _service.Deletar(id);
        if (voluntario == false)
            return BadRequest();
        return Ok(voluntario);
    }

}