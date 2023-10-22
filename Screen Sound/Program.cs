Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            ExibirOpcoesDoMenu();
            break;
        case 2:
            MostrarBandasRegistradas();
            ExibirOpcoesDoMenu();
            break;
        case 3:
            AvaliarUmBanda();
            ExibirOpcoesDoMenu();
            break;
        case 4:
            ExibirMedia();
            ExibirOpcoesDoMenu();
            break;
        case -1:
            Console.Clear();
            Console.WriteLine(@"
████████╗░█████╗░██╗░░██╗░█████╗░██╗░░░██╗  ████████╗░█████╗░██╗░░██╗░█████╗░██╗░░░██╗  ██╗██████╗░
╚══██╔══╝██╔══██╗██║░░██║██╔══██╗██║░░░██║  ╚══██╔══╝██╔══██╗██║░░██║██╔══██╗██║░░░██║  ╚═╝╚════██╗
░░░██║░░░██║░░╚═╝███████║███████║██║░░░██║  ░░░██║░░░██║░░╚═╝███████║███████║██║░░░██║  ░░░░█████╔╝
░░░██║░░░██║░░██╗██╔══██║██╔══██║██║░░░██║  ░░░██║░░░██║░░██╗██╔══██║██╔══██║██║░░░██║  ░░░░╚═══██╗
░░░██║░░░╚█████╔╝██║░░██║██║░░██║╚██████╔╝  ░░░██║░░░╚█████╔╝██║░░██║██║░░██║╚██████╔╝  ██╗██████╔╝
░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝░╚═════╝░  ░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝░╚═════╝░  ╚═╝╚═════╝░");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registros das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas!");
    /* for (int i = 0; i < listaDasBandas.Count; i++)
     {
         Console.WriteLine($"Banda: {listaDasBandas[i]}");
     }*/
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nPressione uma tecla para voltar ao menu iniciar.");
    Console.ReadKey();
    Console.Clear();
    

}

void AvaliarUmBanda()
{
    //digite qual banda deseja avaliar
    //se a banda existir no dicionarioo >> atribuir uma nota
    //senão, volta ao menu inicial

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(4000);
        Console.Clear();
        
    }
    else
    {
        Console.WriteLine($"A Banda {nomeDaBanda} não foi encontrado");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        
    }

}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        
    }
    else
    {
        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Digite ma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        
    }

}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();
