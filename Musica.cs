class Musica
{
    public Musica(Banda artista, string nome)
    {
        Nome = nome;
        Artista = artista;
    }

    public String Nome { get; set; }
    public Banda Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }


    public void ExibirFihaTecnica()
    {
        System.Console.WriteLine($"Musica {Nome}");
        System.Console.WriteLine($"Artista {Artista}");
        System.Console.WriteLine($"Duração {Duracao}"); 
        if(Disponivel)
        {
            System.Console.WriteLine("Contida no plano!");
        }
        else
        {
            System.Console.WriteLine("Musica indisponível neste plano! Adquira o plano Plus5 !");
        }
    }
}
