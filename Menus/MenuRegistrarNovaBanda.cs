namespace ScreenMusic.Menu;
using ScreenMusic.Modelos;
//using OpenAI_API;

internal class MenuRegistrarNovaBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloMenu("Registrar nova banda");
        System.Console.WriteLine("Digite o nome da nova banda que deseja adicionar:");
        string nomeBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeBanda);
        bandasRegistradas.Add(nomeBanda,banda);

        // string api_key = "";
        // OpenAIAPI api = new OpenAIAPI(api_key);
        // //var chat = client.Chat.CreateConversation();
        // var chat = api.Chat.CreateConversation();
        // chat.AppendSystemMessage($"Resuma a banda {nomeBanda} em 1 parágrafo. Adote um estilo informal");
        // var resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        // banda.Resumo = resposta;

        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
