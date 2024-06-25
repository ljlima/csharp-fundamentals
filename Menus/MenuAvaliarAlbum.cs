namespace ScreenMusic.Menu;
using ScreenMusic.Modelos;
internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloMenu("Avaliar Álbum");
        System.Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;

        if(bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda bandaAvaliada = bandasRegistradas[nomeBanda];

            System.Console.WriteLine("Digite o nome do álbum que deseja avaliar: ");
            string tituloAlbum = Console.ReadLine()!;

            if(bandaAvaliada.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album albumAvaliado = bandaAvaliada.Albuns.First(a => a.Nome.Equals(tituloAlbum));

                System.Console.WriteLine("Qual a nota dada a banda?");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                albumAvaliado.AdicionarNota(nota);
                System.Console.WriteLine($"A nota {nota} foi atribuída com sucesso ao album {albumAvaliado.Nome}");
                Thread.Sleep(2000);
                Console.Clear();

            }
            else
            {
                System.Console.WriteLine($"Não foi possível encontrar o album {tituloAlbum}!");
                System.Console.WriteLine("Pressione uma tecla para voltar ao menu inicial: ");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            System.Console.WriteLine($"Não foi possível encontrar a banda {nomeBanda}!");
            System.Console.WriteLine("Pressione uma tecla para voltar ao menu inicial: ");
            Console.ReadKey();
            Console.Clear();
        }
        
    }
    
}