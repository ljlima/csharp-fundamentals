class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public String Nome { get; set; }
    public String Host { get; set; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        System.Console.WriteLine($"Podcast >|{Nome}|< Apresentado por: [{Host}]");
        foreach (Episodio episodio in episodios.OrderBy(ep => ep.Ordem))
        {
            System.Console.WriteLine(episodio.Resumo);
        }

        System.Console.WriteLine($"Número total de episódios: {TotalEpisodios}");
    }
}