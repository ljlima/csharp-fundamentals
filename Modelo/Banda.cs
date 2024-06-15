class Banda
{
    private List<Album> albums = new List<Album>();
    public Banda(string nome)
    {
        Nome = nome;
    }
    public String Nome { get; set; }

    public void ExibirDadosBanda()
    {
        System.Console.WriteLine($"Banda {Nome}");
        if(albums?.Any() == true ) 
        {
            System.Console.WriteLine("Albuns: ");
            foreach (var album in albums)
            {
                System.Console.WriteLine(album);
            }
        }
        else
        {
            System.Console.WriteLine("Ainda não foram encontrados albums cadastrados! Cadastre um albúm!");
        }
    }
}
