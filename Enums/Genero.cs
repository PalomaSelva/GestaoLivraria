using System.Text.Json.Serialization;

namespace GestaoLivraria.Enums;
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Genero
{
    Terror,
    Fantasia,
    Romance,
    Aventura,
    Suspense
}
