using SCREENMUSIC.Modelo;


namespace SCREENMUSIC.Filtro;
class LinqFilter
{
    public static void ExibirTodosGeneros(List<Musica> musicas)
    {
        var todosGeneros = musicas.Select(genero => genero.Genero).Distinct().ToList();

        foreach (var genero in todosGeneros)
        {
            System.Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGenero(List<Musica> musicas, string genero)
    {
        var todosArtistasPorGenero = musicas.Where(artista => artista.Genero!.Contains(genero))
                                  .Select(musica => musica.Artista)
                                  .Distinct()
                                  .ToList();

        foreach (var artista in todosArtistasPorGenero)
        {
            System.Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicaPorArtista(List<Musica> musicas, string nomeArtista)
    {
        var todosMusicasPorArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista))
                                  .Select(musica => musica.Nome)
                                  .ToList();
        System.Console.WriteLine($"Nome do artista: {nomeArtista}");
        foreach (var musica in todosMusicasPorArtista)
        {
            System.Console.WriteLine($"- {musica}");
        }
    }

      public static void FiltrarMusicaPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var todosMusicasPorTonalidade = musicas.Where(musica => musica.Tonalidade!.Equals(tonalidade))
                                                .Select(musica => musica.Nome)
                                                .Distinct()
                                                .ToList();
        System.Console.WriteLine($"Tonalidade: {tonalidade}");
        foreach (var musica in todosMusicasPorTonalidade)
        {
            System.Console.WriteLine($"- {musica}");
        }
    }
    

}