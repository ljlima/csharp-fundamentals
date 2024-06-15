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
    }
    catch (System.Exception e)
    {
       Console.WriteLine($"Não foi possível concluir ação! \n {e}");
        throw;
    }
}