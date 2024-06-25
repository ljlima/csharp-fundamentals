namespace ScreenMusic.Modelos;
class Episodio
{
    List<string> convidados = new List<string>();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; set; }
    public String Titulo { get; set; }
    public int Duracao { get; set; }
    public String Resumo => $"{Ordem}.{Titulo} ({Duracao} mins) - {string.Join(",",convidados)}";

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }

}