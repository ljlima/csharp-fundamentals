namespace ScreenMusic.Modelos;
class Album
{
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();
    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public double Media 
    {
        get 
        {
            if(notas.Count() == 0) return 0;
            else return notas.Average(nota => nota.Nota);
        }
    }

    public List<Musica> Musicas => musicas;
    public void AdicionarMusicas(Musica musica)
    {
        musicas.Add(musica);
    }
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
    public int DuracaoTotal  =>  musicas.Sum(m  => m.Duracao);

    public void ExibirMusicasAlbum()
    {
        System.Console.WriteLine($"Músicas do albúm {Nome}: ");
        foreach (var musica in musicas)
        {
            System.Console.WriteLine(musica.Nome);
        }
        System.Console.WriteLine($"Duração total do albúm: {DuracaoTotal}");
    }
}