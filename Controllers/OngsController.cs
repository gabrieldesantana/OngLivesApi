using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;
using ONGLIVESAPI.Interfaces;

namespace ONGLIVES.API.Controllers;

[ApiController]
// [ApiVersion("1.0")]
// [Route("api/v{version:apiVersion}/[controller]")]
[Route("api/[controller]")]

//public class OngController : ControllerBase
public class OngsController : ControllerBase
{
    private readonly IOngService _service;
    public OngsController(OngService service)
    {
        _service = service;
    }

    [HttpGet("")]
    public IActionResult Get()
    {
        var ong = _service.PegarTodos();

        if (ong == null)
        {
            return NotFound();
        }

        return Ok(ong);

    }

    [HttpGet("{id}")]
    public IActionResult GetPorId(int id)
    {
        var ong = _service.PegarPorId(id);

        if (ong == null)
            return BadRequest();

        return Ok(ong);
    }

    [HttpPost("")]
    public IActionResult Post(Ong ong)
    {
        if (ong == null)
            return BadRequest();

        _service.Cadastrar(ong);

        return Ok(ong);
    }

    [HttpPut("")]
    public IActionResult Put(Ong ong)
    {
        if (ong == null)
            return BadRequest();

        var ongEdit = _service.Editar(ong);

        return Ok(ongEdit);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Deletar(id);
        return Ok();
    }

}