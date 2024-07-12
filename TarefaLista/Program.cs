string mensagemBoasVindas = "Seja Bem Vindo(a) ao SISTEMA COMEX";

Dictionary<string, int> produtos = new Dictionary<string, int>();

void Menu()
{
    int controle = -1;
    while (controle != 0)
    {
        Console.WriteLine($"\n------------- {mensagemBoasVindas} -------------\n");
        Console.WriteLine("Escolha uma das opções abaixo:");
        Console.WriteLine("1 - Ver produtos em estoque");
        Console.WriteLine("2 - Adicionar um produto");
        Console.WriteLine("0 - sair\n");
        Console.Write("Resposta: ");
        controle = int.Parse(Console.ReadLine()!);

        switch (controle)
        {
            case 1:
                LimparConsoleAdicionarTitulo("Estoque de Produtos");
                ListarProdutos();
                LimparConsole();
                break;
            case 2:
                LimparConsoleAdicionarTitulo("Adicionar novo produto");
                AdicionarProduto();
                LimparConsole();
                break;
            case 0:
                Console.WriteLine("Saindo... tchau tchau <3");
                break;
            default:
                Console.WriteLine("Opção Inválida...");
                LimparConsole();
                break;
        }
    }
}
void AdicionarProduto()
{
    Console.Write("Qual produto você quer cadastrar?: ");
    string nome = Console.ReadLine()!;

    Console.Write("\nInforme a quantidade disponível desse produto: ");
    int quantidade = int.Parse(Console.ReadLine()!);

    if (nome == "")
    {
        Console.WriteLine("Digite um nome válido");
    }
    else if (quantidade < 0)
    {
        Console.WriteLine("Digite uma quantidade válida");
    }
    else
    {
        produtos.Add(nome, quantidade);
        Console.WriteLine($"\nProduto {nome} com a quantidade {quantidade} adicionado ao estoque com sucesso!");
    }

}

void ListarProdutos()
{
    foreach (var produto in produtos)
    {
        Console.WriteLine($"\nNome: {produto.Key}");
        Console.WriteLine($"Quantidade: {produto.Value}\n");
    }

    if (produtos.Count == 0)
    {
        Console.WriteLine("Nenhum produto cadastrado!");
    }
}

void LimparConsoleAdicionarTitulo(string titulo)
{
    Thread.Sleep(1000);
    Console.Clear();
    mensagemBoasVindas = titulo;
    Console.WriteLine($"\n------------- {mensagemBoasVindas} -------------\n");
}
void LimparConsole()
{
    Thread.Sleep(5000);
    Console.Clear();
    mensagemBoasVindas = "SISTEMA COMEX";
}

Menu();