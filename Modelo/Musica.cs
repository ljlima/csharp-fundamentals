using System.Text.Json.Serialization;
namespace SCREENMUSIC.Modelo;
class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirMusica()
    {
        System.Console.WriteLine($"Nome: {Nome}");
        System.Console.WriteLine($"Artista: {Artista}");
        System.Console.WriteLine($"Duração: {Duracao}");
        System.Console.WriteLine($"Gênero: {Genero}");
    }

    public void ExibirGeneros()
    {
        System.Console.WriteLine($"Gênero: {Genero}");
    }
}