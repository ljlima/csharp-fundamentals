using APPOO.Menu;
using OPENAI_API;
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

        string api_key = "";
        var client = new OpenAiApi(api_key);
        var chat = client.Chat.CreateConversation();
        chat.AppendSystemMessage($"Resuma a banda {nomeBanda} em 1 parágrafo. Adote um estilo informal");
        var resposta = chat.GetResponseFromChatBotAsync().GetAwaiter().GetResult();
        banda.Resumo = resposta;

        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
