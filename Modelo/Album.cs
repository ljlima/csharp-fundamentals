class Album
{
    private List<Musica> musicas = new List<Musica>();
    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }

    public void AdicionarMusicas(Musica musica)
    {
        musicas.Add(musica);
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
