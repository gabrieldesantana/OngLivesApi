using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entities;

namespace ONGLIVES.API.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
public class VolunteersController : ControllerBase
{

    [HttpGet("")]
    public IActionResult Get()
    {
        var voluntario1 = new Voluntary 
        {
            Id = 101,
            FirstName = "Mario",
            LastName = "Silva",
            CPF = "01234564323",
            DateOfBirth = DateTime.Now,
            Gender = "Male",
            Schooling = "HighSchool",
            Address = new VoluntaryAddress 
            {
                VoluntaryId = 101,
                Address = "Rua A limpa",
                City = "Aracaju",
                Country = "Brasil",
                Number = 1333,
                State = "Sergipe"
            }
        };
        return Ok(voluntario1);
    }

    [HttpPost("")]
    public IActionResult Post()
    {
        
        return Ok();
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