using GestaoLivraria.Communication.Requests;
using GestaoLivraria.Entities;
using GestaoLivraria.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoLivraria.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LivrariaController : ControllerBase
{
    private static List<Livro> livros = new List<Livro>() {
              new Livro
            {
                Id = 1,
                Titulo = "O Iluminado",
                Autor = "Stephen King",
                Genero = Genero.Terror,
                Preco = 29.90,
                Qntd = 10
            },
            new Livro
            {
                Id = 2,
                Titulo = "Diário de uma paixão",
                Autor = "Nicholas Sparks",
                Genero = Genero.Romance,
                Preco = 39.90,
                Qntd = 5
            },
            new Livro
            {
                Id = 3,
                Titulo = "Star Wars",
                Autor = "George Lucas",
                Genero = Genero.Fantasia,
                Preco = 59.90,
                Qntd = 2
            }
        };

    [HttpGet]
    [ProducesResponseType(typeof(List<Livro>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        return Ok(livros);
    }

    [HttpPost]
    [ProducesResponseType(typeof(Livro), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBook request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        int Id = livros.Count + 1;

        Livro response = new Livro
        {
            Id = Id,
            Titulo = request.Titulo,
            Autor = request.Autor,
            Genero = request.Genero,
            Preco = request.Preco,
            Qntd = request.Qntd
        };

        livros.Add(response);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateBook request, [FromRoute] int id)
    {
        if (!ModelState.IsValid) {
            return BadRequest();
        }
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id) {
        if (!ModelState.IsValid) {
            return BadRequest();
        }
        return NoContent();
    }
}
