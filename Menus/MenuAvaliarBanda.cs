namespace ScreenMusic.Menu;
using ScreenMusic.Modelos;
internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloMenu("Avaliar Banda");
        System.Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;

        if(bandasRegistradas.ContainsKey(nomeBanda))
        {
            Banda bandaAvaliada = bandasRegistradas[nomeBanda];

            System.Console.WriteLine("Qual a nota dada a banda?");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            bandaAvaliada.AdicionarNota(nota);
            System.Console.WriteLine($"A nota {nota.Nota} foi atribuída com sucesso a banda {bandaAvaliada.Nome}");
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