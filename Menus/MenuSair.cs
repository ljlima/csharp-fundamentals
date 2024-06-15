namespace APPOO.Menu;

using System.Collections.Generic;
using APPOO.Modelos;
internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        System.Console.WriteLine("Tchau! :)");
    }
}