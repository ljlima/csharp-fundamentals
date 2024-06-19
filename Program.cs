using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;
using SCREENMUSIC.Modelo;
using SCREENMUSIC.Filtro;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        //LinqFilter.ExibirTodosGeneros(musicas);
        //LinqOrder.ExibirListaArtistasOrdenada(musicas);
        ///LinqFilter.FiltrarArtistaPorGenero(musicas, "blues");
        LinqFilter.FiltrarMusicaPorArtista(musicas, "U2");


        MusicasPreferidas musicasPreferidasJao = new MusicasPreferidas("jao");
        musicasPreferidasJao.AdicionarMusicasPreferidas(musicas[66]);
        musicasPreferidasJao.AdicionarMusicasPreferidas(musicas[777]);
        musicasPreferidasJao.AdicionarMusicasPreferidas(musicas[88]);
        musicasPreferidasJao.AdicionarMusicasPreferidas(musicas[11]);
        musicasPreferidasJao.AdicionarMusicasPreferidas(musicas[5]);

        musicasPreferidasJao.ExibirMusicasPreferidas();
        musicasPreferidasJao.CriarArquivoJson();

        musicasPreferidasJao.CriarArquivosTxt();
    }
    catch (System.Exception e)
    {
       Console.WriteLine($"Não foi possível concluir ação! \n {e}");
        throw;
    }
}