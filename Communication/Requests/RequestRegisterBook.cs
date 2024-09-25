using GestaoLivraria.Enums;

namespace GestaoLivraria.Communication.Requests;

public class RequestRegisterBook
{
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public Genero Genero { get; set; }
    public double Preco { get; set; }
    public int Qntd { get; set; }

}
