namespace ScreenMusic.Menu;
using ScreenMusic.Modelos;
using System.Collections.Generic;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        System.Console.WriteLine("Tchau! :)");
    }
}