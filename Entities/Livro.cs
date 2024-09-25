using GestaoLivraria.Enums;

namespace GestaoLivraria.Entities;

public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public Genero Genero { get; set; }
    public double Preco { get; set; }
    public int Qntd { get; set; }  

}
