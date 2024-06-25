using ScreenMusic.Modelos;

namespace ScreenMusic.Menu;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloMenu("Registrar Álbum");

        System.Console.WriteLine("Digite o nome da banda o qual deseja adicionar o albúm");
        string nomeBanda = Console.ReadLine()!;
        if(bandasRegistradas.ContainsKey(nomeBanda))
        {
            System.Console.WriteLine("Digite o nome do álbum que deseja adicionar");
            string tituloAlbum = Console.ReadLine()!;

            Banda banda = bandasRegistradas[nomeBanda];

            banda.AdicionarAlbum(new Album(tituloAlbum));

            Console.WriteLine($"O álbum {tituloAlbum} de {nomeBanda} foi registrado com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}