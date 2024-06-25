namespace ScreenMusic.Menu;
using ScreenMusic.Modelos;
internal class Menu
{
    public void ExibirTituloMenu(string titulo)
    {
        int quantidadeLetras = titulo.Length;
        string asterisco = string.Empty.PadLeft(quantidadeLetras,'*');
        System.Console.WriteLine(asterisco);
        System.Console.WriteLine(titulo);
        System.Console.WriteLine(asterisco+"\n\n");
    }

    public virtual void Executar(Dictionary<string,Banda> bandasRegistradas)
    {
        Console.Clear();
    }
}