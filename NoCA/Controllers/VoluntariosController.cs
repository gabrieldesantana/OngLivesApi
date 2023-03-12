using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;
using ONGLIVESAPI.Interfaces;

namespace ONGLIVES.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class VolunteersController : ControllerBase
{
    private readonly IVoluntarioService _service;
    public VolunteersController(IVoluntarioService service)
    {
        _service = service;
    }

    // [HttpGet("")]
    // public IActionResult Get()
    // {
    //     var voluntarios = _context.Voluntarios.ToList();
    //     return Ok(voluntarios);

    // }

    // [HttpGet("{id}")]
    // public IActionResult GetPorId(int id) 
    // {
    //     var voluntario = _context.Voluntarios.FirstOrDefault(x => x.Id == id);

    //     if (voluntario == null) 
    //         return BadRequest("Não foi possível localizar um voluntário com esse id");

    //     return Ok(voluntario);
    // }

    [HttpPost("")]
    public IActionResult Post(Voluntario voluntario)
    {
        // var voluntarios = _context.Voluntarios.ToList();


        // _context.Voluntarios.Add(voluntario);
        _service.Cadastrar(voluntario);

        return Ok(voluntario);
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