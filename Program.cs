void ExibirMensagemBoasVindas()
{
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
    // "\n" dá o espaço
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para exibir todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para ver a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("\nEscolha uma opção: ");
    //Exclamação garante que não será retornado nulo
    string opcaoEscolhida = Console.ReadLine()!; // "!" garante que não será retornado null
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); // converte para inteiro
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            Console.WriteLine("Você digitou a opção: " + opcaoEscolhidaNumerica);
            break;
        case 2:
            Console.WriteLine("Você digitou a opção: " + opcaoEscolhidaNumerica);
            break;
        case 3:
            Console.WriteLine("Você digitou a opção: " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você digitou a opção: " + opcaoEscolhidaNumerica);
            break;

        case -1:
            Console.WriteLine("tchau :)");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

ExibirMensagemBoasVindas();
ExibirMenuOpcoes();