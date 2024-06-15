using APPOO.Menu;
using APPOO.Modelos;
//https://www.nuget.org/packages/OpenAI/#chat-conversations


Dictionary<int, Menu> opcoes = new Dictionary<int, Menu>();

opcoes.Add(1, new MenuRegistrarNovaBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuExibirDetalhes());
opcoes.Add(4, new MenuMostrarBandas());
opcoes.Add(5, new MenuAvaliarBanda());
opcoes.Add(6, new MenuAvaliarAlbum());
opcoes.Add(-1, new MenuSair());

Dictionary<string,Banda> bandasRegistradas = new Dictionary<string, Banda>();

Banda banda1 = new Banda("Banda Antiga");
Banda banda2 = new Banda("Banda Nova");


bandasRegistradas.Add(banda1.Nome,banda1);
bandasRegistradas.Add(banda2.Nome,banda2);


void ExibirMensagemBoasVindas()
{
    Console.Clear();
    string mensagemBoasVindas = "Bem vindo ao Screen Audio!";
    //verbatim literal ; @" string desejada"  
    //o verbatim exibe a mensagem no código para facilitar a interpretação por outro programador

    //Logotipo
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirMenuOpcoes()
{
    int opcaoEscolhidaNumerica = 0;
    do
    {
        ExibirMensagemBoasVindas();
    // "\n" dá o espaço
    Console.WriteLine("\nDigite 1 para Registrar uma banda");
    Console.WriteLine("Digite 2 para Registrar um álbum");
    Console.WriteLine("Digite 3 para Exibir detalhes de uma banda");
    Console.WriteLine("Digite 4 para Ver as bandas registradas");
    Console.WriteLine("Digite 5 para Avaliar uma banda registrada");
    Console.WriteLine("Digite 6 para  Avaliar um Álbum de uma banda  registrada");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("\nEscolha uma opção: ");
    //Exclamação garante que não será retornado nulo
    string opcaoEscolhida = Console.ReadLine()!; // "!" garante que não será retornado null
    opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); // converte para inteiro

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuEscolhido = opcoes[opcaoEscolhidaNumerica];
        menuEscolhido.Executar(bandasRegistradas);
    }
    else
    {
        System.Console.WriteLine("Opção Inválida!!!");
    }

    }
    while(opcaoEscolhidaNumerica != -1);
}


ExibirMenuOpcoes();
