using System.IO.Compression;
using System.Text.Json;
using SCREENMUSIC.Modelo;
namespace SCREENMUSIC.Modelo;
class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaMusicasPreferidas { get; set; }
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaMusicasPreferidas = new List<Musica>();        
    }

    public void AdicionarMusicasPreferidas(Musica musica)
    {
        ListaMusicasPreferidas.Add(musica);
        Console.WriteLine($"Musica {musica} Adicionada com sucesso!");
    }

    public void ExibirMusicasPreferidas()
    {
        foreach (var musica in ListaMusicasPreferidas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        System.Console.WriteLine();
    }

    public void CriarArquivoJson()
    {
        var json = JsonSerializer.Serialize(
            new
            {
                nome = Nome,
                musica = ListaMusicasPreferidas
            }
        );

        string nomeArquivo = $"Musicas preferidas - {Nome}";
        File.WriteAllText(nomeArquivo,json);

        System.Console.WriteLine($"Arquivo criado com sucesso!{Path.GetFullPath(nomeArquivo)}");
    }

    public void CriarArquivosTxt()
    {
        string nomeArquivo = $"Musicas preferidas - {Nome} txt";
        using (StreamWriter arquivo = new StreamWriter(nomeArquivo))
        {
            arquivo.WriteLine(nomeArquivo);
            foreach (var musica in ListaMusicasPreferidas)
            {
                arquivo.WriteLine($"- {musica.Nome} de {musica.Artista}");
            }
            arquivo.Close();
            System.Console.WriteLine("Arquivo Gerado com sucesso!");
        }
    }
}