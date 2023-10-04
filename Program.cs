void BoasVindas()
{
    Console.WriteLine("\x1b[1;34m███╗░░░███╗░█████╗░██████╗░░██████╗░░██████╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░░██████╗");
        Console.WriteLine("\x1b[1;34m████╗░████║██╔══██╗██╔══██╗██╔═══██╗██╔════╝  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗██╔════╝");
        Console.WriteLine("\x1b[1;34m██╔████╔██║███████║██████╔╝██║██╗██║╚█████╗░  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║╚█████╗░");
        Console.WriteLine("\x1b[1;34m██║╚██╔╝██║██╔══██║██╔══██╗╚██████╔╝░╚═══██╗  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║░╚═══██╗");
        Console.WriteLine("\x1b[1;34m██║░╚═╝░██║██║░░██║██║░░██║░╚═██╔═╝░██████╔╝  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██████╔╝");
        Console.WriteLine("\x1b[1;34m╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═════╝░  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═════╝░");
}

void Menu()
{
    int opcao = 0;

    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para visualizar todas as bandas registradas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");
    Console.Write("\nDigite a opção desejada: ");

    opcao = int.Parse(Console.ReadLine()!);
    switch(opcao){
        case 1:
        Console.WriteLine("Você selecionou a opção " + opcao + ".");
        adicionarBanda();
        break;
        case 2:
        Console.WriteLine("Você selecionou a opção " + opcao + ".");
        listarBandas();
        break;
        case 3:
        Console.WriteLine("Você selecionou a opção " + opcao + ".");
        break;
        case 4:
        Console.WriteLine("Você selecionou a opção " + opcao + ".");
        break;
        case 0:
        Console.WriteLine("Você decidiu sair");
        break;
        default:
        Console.WriteLine("Você selecionou uma opção inválida.");
        break;
    }
}

List<string>listaBanda = new List<string>(); //Listar bandas

void adicionarBanda()
{
    string nome, genero;
    int opcoes;

    Console.Clear();
    Console.WriteLine("Cadastro de bandas");

    Console.WriteLine("Insira o nome da banda: ");
    nome = Console.ReadLine()!;
    Console.WriteLine($"A banda {nome} foi cadastrada com sucesso!");

    Console.WriteLine("Insira o gênero da banda: ");
    genero = Console.ReadLine()!;
    Console.WriteLine($"A banda {nome} de gênero {genero} foi atualizada com sucesso!");

    listaBanda.Add(nome);
    // listaBanda.Add(genero);

    Console.WriteLine("Deseja cadastrar uma nova banda ou voltar para o menu principal?\nDigite 0 para voltar ao menu principal ou 1 para continuar no menu de cadastro de bandas.");
    opcoes = int.Parse(Console.ReadLine()!);
    if(opcoes == 0 || opcoes == 1){
        if(opcoes == 1){
            Console.WriteLine("Você optou em continuar no menu de cadastro de bandas");
            adicionarBanda();
        }else{
            Console.WriteLine("Você optou em voltar para o menu principal.");
            Menu();
        }
    }else{
        Console.WriteLine("Opção inválida, tente novamente.");
        adicionarBanda();
    }
    
}

void listarBandas()
{
    Console.Clear();
    for(int i =0; i < listaBanda.Count; i++){
        Console.WriteLine($"Banda: {listaBanda[i]}");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Menu();
    }
}

void adicionarMusica()
{

}

BoasVindas();
Menu();