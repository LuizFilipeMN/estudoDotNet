using System.ComponentModel;
using System.Collections.Generic;

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
        AvaliarBanda();
        break;
        case 4:
        Console.WriteLine("Você selecionou a opção " + opcao + ".");
        ExibirMediaBanda();
        break;
        case 0:
        Console.WriteLine("Você decidiu sair");
        break;
        default:
        Console.WriteLine("Você selecionou uma opção inválida.");
        break;
    }
}

List<string>listaBandas = new List<string>();
int quantidadeBandas = 0;

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

    listaBandas.Add(nome);
    quantidadeBandas++;

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
    foreach(string listaBanda in listaBandas){
        Console.WriteLine($"Banda: {listaBanda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Menu();
}

Dictionary<string, List<double>> avaliacoesBanda = new Dictionary<string, List<double>>();


void AvaliarBanda()
{
    Console.Clear();

    if(quantidadeBandas == 0){
        Console.WriteLine("Nenhuma banda cadastrada para avaliação.");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Menu();
        return;
    }

    Console.WriteLine("Escolha a banda para avaliação:");
    for(int i = 0; i < quantidadeBandas; i++){
        Console.WriteLine($"{i + 1}. {listaBandas[i]}");
    }

    int escolha = int.Parse(Console.ReadLine()!);

    if(escolha >= 1 && escolha <= quantidadeBandas){
        string bandaEscolhida = listaBandas[escolha - 1];

        Console.WriteLine($"Digite a avaliação para a banda {bandaEscolhida} (de 1 a 5):");
        double avaliacao = double.Parse(Console.ReadLine()!);
        if(avaliacoesBanda.ContainsKey(bandaEscolhida)){
            avaliacoesBanda[bandaEscolhida].Add(avaliacao);
        }else{
            List<double> novaAvaliacao = new List<double> { avaliacao };
            avaliacoesBanda.Add(bandaEscolhida, novaAvaliacao);
        }
        Console.WriteLine($"A banda {bandaEscolhida} foi avaliada com sucesso!");

    }else{
        Console.WriteLine("Opção inválida.");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Menu();
}

void ExibirMediaBanda()
{
    Console.Clear();
    if(quantidadeBandas == 0){
        Console.WriteLine("Nenhuma banda cadastrada para avaliação.");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Menu();
        return;
    }

    Console.WriteLine("Selecione a banda que você deseja visualizar a média: ");

    for(int i = 0; i < quantidadeBandas; i++){
        Console.WriteLine($"{i + 1}. {listaBandas[i]}");
    }

    int escolha = int.Parse(Console.ReadLine()!);

    if(escolha >= 1 && escolha <= quantidadeBandas){
        string bandaEscolhida = listaBandas[escolha - 1];
        if(avaliacoesBanda.ContainsKey(bandaEscolhida)){
            List<double> avaliacoes = avaliacoesBanda[bandaEscolhida];
            double media = avaliacoes.Average();
            Console.WriteLine($"A média de avaliação para a banda {bandaEscolhida} é: {media}");
        }else{
            Console.WriteLine($"A banda {bandaEscolhida} ainda não foi avaliada.");
        }
    }else{
        Console.WriteLine("Opção inválida.");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Menu();

}


BoasVindas();
Menu();