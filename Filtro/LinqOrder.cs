using SCREENMUSIC.Modelo;
namespace SCREENMUSIC.Filtro;
class LinqOrder
{
    public static void ExibirListaArtistasOrdenada(List<Musica> musicas)
    {
        var todosArtistas = musicas.OrderBy(musica => musica.Artista)
                                    .Select(musica => musica.Artista)
                                    .Distinct()
                                    .ToList();


        foreach(var artista in todosArtistas)
        {
            System.Console.WriteLine($"- {artista}");
        }
    }
}