Dictionary<String,List<int>> bandas = new Dictionary<string, List<int>>();
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
    ExibirMensagemBoasVindas();
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
        case 1:  RegistrarBanda();
            break;
        case 2: VisualizarBanda();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: VerMediaBanda();
            break;

        case -1:
            Console.WriteLine("tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    System.Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    try
    {
        bandas.Add(nomeBanda.ToUpper(),new List<int>());
        System.Console.WriteLine($"Banda {nomeBanda} foi adicionada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenuOpcoes();
    }
    catch (System.Exception)
    {

        throw;
    }
    
}

void VisualizarBanda()
{
    Console.Clear();
    System.Console.WriteLine("Foram registradas até o momento as bandas: ");
    foreach (var banda in bandas.Keys)
        {
            System.Console.WriteLine(banda);
        }
    Thread.Sleep(2000);


    Console.Clear();
    ExibirMenuOpcoes();

}

void AvaliarBanda()
{
    Console.Clear();
    System.Console.WriteLine("Digite o nome da banda que deseja avaliar:");
    try
    {
        string bandaAvaliada = Console.ReadLine()!;
        bandaAvaliada = bandaAvaliada.ToUpper();

        if (bandas.ContainsKey(bandaAvaliada))
        {
            System.Console.WriteLine("Qual a nota dada a banda?");
            int nota = int.Parse(Console.ReadLine()!);
            bandas[bandaAvaliada].Add(nota);
            System.Console.WriteLine($"Nota {nota} atribuída a banda {bandaAvaliada.ToUpper()} com sucesso!");
            Thread.Sleep(2000);
        }
        else
        {
            System.Console.WriteLine("Não foi possível encontrar a banda digitada!!");
            System.Console.WriteLine("Pressione uma tecla para voltar no menu inicial: ");
            Console.ReadKey();

        }
        Console.Clear();
        ExibirMenuOpcoes();
    }
    catch (System.Exception)
    {
        
        throw;
    }  
}

void VerMediaBanda()
{
    Console.Clear();
    System.Console.WriteLine("Digite o nome da banda que deseja avaliar:");
    string bandaAvaliada = Console.ReadLine()!;
    bandaAvaliada = bandaAvaliada.ToUpper();
    if (bandas.ContainsKey(bandaAvaliada))
    {
        List<int> notasBanda = bandas[bandaAvaliada];
        System.Console.WriteLine($"A média de notas para a banda {bandaAvaliada} é {notasBanda.Average()}");
        Thread.Sleep(2000);
    }
    else
    {
        System.Console.WriteLine("Não foi possível encontrar a banda digitada!!");
        System.Console.WriteLine("Pressione uma tecla para voltar no menu inicial: ");
        Console.ReadKey();

    }
    Console.Clear();
    ExibirMenuOpcoes();
}

ExibirMenuOpcoes();