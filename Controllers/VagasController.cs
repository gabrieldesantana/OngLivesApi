using Microsoft.AspNetCore.Mvc;
using ONGLIVES.API.Entidades;

namespace ONGLIVES.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class VagasController : ControllerBase
{
    
    [HttpGet("")]
    public IActionResult Get()
    {
        var voluntario1 = new Voluntario 
        {
            Id = 101,
            Nome = "Mario",
            Sobrenome = "Silva",
            CPF = "01234564323",
            DataAniversario = DateTime.Now,
            Genero = "Masculino",
            Escolaridade = "EnsinoMedio",
            Email = "xpto@teste.com",
            Endereco = new Endereco 
            {
                Id = 101,
                Cep = "49000000",
                EnderecoLinhaUm = "Rua A limpa",
                EnderecoLinhaDois = "Condominio XPTO",
                Numero = 1333,
                Bairro = "Centro",
                Cidade = "Aracaju",
                Estado = "Sergipe",
                Pais = "Brasil"
            }
        };

        var ong1 = new Ong 
        {
            Id = 102,
            Nome = "Ong da vida",
            CNPJ = "01255534564323",
            Telefone = "+5511987786745",
            QuantidadeEmpregados = 100,
            Endereco = new Endereco 
            {
                Id = 101,
                Cep = "459999999",
                EnderecoLinhaUm = "Rua C4 bloco f",
                EnderecoLinhaDois = "Rua C4 bloco f",
                Numero = 1333,
                Bairro = "Centro",
                Cidade = "Aracaju",
                Estado = "Sergipe",
                Pais = "Brasil"
            }
        };

        var vaga1 = new Vaga 
        {
            Id = 1,
            VoluntarioId = 101,
            OngId = 102,
            Voluntario = voluntario1,
            Ong = ong1,

            Descricao = "Primeira vaga",
            DataInicio = DateTime.Now,
            DataFim = DateTime.Now.AddDays(30),
            Habilidade = "Pintor",
            Tipo = "Meio periodo",
            Turno = "Tarde"
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