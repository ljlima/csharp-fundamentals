namespace APPOO.Menu;
using APPOO.Modelos;
internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloMenu("Exibir Detalhes");
        System.Console.WriteLine("Digite o nome da banda que deseja saber mais: ");
        string nomeBanda = Console.ReadLine()!;

        if(bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda banda = bandasRegistradas[nomeBanda];

            System.Console.WriteLine(banda.Resumo);
            System.Console.WriteLine($"A média da banda: {banda.Media}");
            
            System.Console.WriteLine("Discografia");
            foreach (Album album in banda.Albuns)
            {
                System.Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
            
            Thread.Sleep(2000);
            Console.Clear();

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