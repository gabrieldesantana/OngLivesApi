using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;
using ONGLIVESAPI.Interfaces;

namespace ONGLIVES.API.Controllers;

[ApiController]
// [ApiVersion("1.0")]
// [Route("api/v{version:apiVersion}/[controller]")]
[Route("api/[controller]")]
public class OngsController : ControllerBase
{
    private readonly IOngService _service;
    public OngsController(IOngService service)
    {
        _service = service;
    }

    [ProducesResponseType((200), Type = typeof(List<Voluntario>))]
    [ProducesResponseType((404))]
    [HttpGet("")]
    public async Task<IActionResult> GetTodos()
    {
        var ongs = await _service.PegarTodos();

        if (ongs == null)
            return NotFound("Nenhum registro encontrado no sistema");

        return Ok(ongs);
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
    public async Task<IActionResult> Post(InputOngModel inputOngModel)
    {
        if (inputOngModel == null)
            return BadRequest();

        var ong = new Ong 
        {
        Nome = inputOngModel.Nome,
        CNPJ = inputOngModel.CNPJ,
        Telefone = inputOngModel.Telefone,
        Email = inputOngModel.Email,
        AreaAtuacao = inputOngModel.AreaAtuacao,
        QuantidadeEmpregados = inputOngModel.QuantidadeEmpregados,
        Endereco = inputOngModel.Endereco,

        Id = inputOngModel.Id
        };
        
        await _service.Cadastrar(ong);

        return CreatedAtAction("GetPorId", new { Id = ong.Id }, ong);
    }


    [ProducesResponseType((200), Type = typeof(Voluntario))]
    [ProducesResponseType((404))]
    [HttpPut("")]
    public async Task<IActionResult> Put(EditOngModel ong)
    {
        if (ong == null)
            return NotFound();

        var OngEdit = await _service.Editar(ong);

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