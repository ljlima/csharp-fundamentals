namespace ScreenMusic.Modelos;
internal class Banda : IAvaliavel
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public Banda(string nome)
    {
        Nome = nome;
    }
    public String Nome { get; set; }
    public double Media 
    { 
        get
        {
            if(notas.Count() == 0) return 0;
            else return notas.Average(notaBanda => notaBanda.Nota);
        } 
    }
    public string? Resumo { get; set; }
    public List<Album> Albuns => albuns;
    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }
    public void AdicionarNota (Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        System.Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            System.Console.WriteLine($"Album: {album.Nome} - Duração: {album.DuracaoTotal}");
        }
    }
}