using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entities;

namespace ONGLIVES.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class JobsController : ControllerBase
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

        var ong1 = new Institution 
        {
            Id = 102,
            Name = "Ong da vida",
            CNPJ = "01255534564323",
            Phone = "+5511987786745",
            AmountOfEmployee = 100,
            Address = new InstitutionAddress 
            {
                InstitutionId = 101,
                Address = "Rua C4 bloco f",
                City = "Aracaju",
                Country = "Brasil",
                Number = 1333,
                State = "Sergipe"
            }
        };

        var vaga1 = new Job 
        {
            Id = 1,
            VoluntaryId = 101,
            InstitutionId = 102,

            Voluntary = new Voluntary {
            Id = 101,
            FirstName = "Mario",
            LastName = "Silva",
            CPF = "01234564323",
            DateOfBirth = DateTime.Now,
            Gender = "Male",
            Schooling = "HighSchool",
            Email = "mario@teste.com",
            Address = new VoluntaryAddress 
            {
                VoluntaryId = 101,
                Address = "Rua A limpa",
                ZipCode = "987345000",
                City = "Aracaju",
                Country = "Brasil",
                Number = 1333,
                State = "Sergipe"
            }
            },

            Institution = new Institution 
        {
            Id = 102,
            Name = "Ong da vida",
            CNPJ = "01255534564323",
            Phone = "+5511987786745",
            AmountOfEmployee = 100,
            Address = new InstitutionAddress 
            {
                InstitutionId = 101,
                Address = "Rua C4 bloco f",
                ZipCode = "123456000",
                City = "Aracaju",
                Country = "Brasil",
                Number = 1333,
                State = "Sergipe"
            }
        },

            Description = "Primeira vaga",
            StartAt = DateTime.Now,
            Skill = "Painter",
            Type = "FullTime",
            WorkShift = "Afternoon"
        };

        return Ok(vaga1);
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