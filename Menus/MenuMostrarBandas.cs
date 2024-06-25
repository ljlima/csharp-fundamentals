namespace ScreenMusic.Menu;
using ScreenMusic.Modelos;

internal class MenuMostrarBandas : Menu
{
    public override void Executar(Dictionary<string,Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloMenu("Mostrar Bandas");

        foreach (string bandas in bandasRegistradas.Keys)
        {
            System.Console.WriteLine($"Banda: {bandas}");
        }
        System.Console.WriteLine("Digite uma tecla para voltar ao menu inicial: ");
        Console.ReadKey();
        Console.Clear();
    }
}