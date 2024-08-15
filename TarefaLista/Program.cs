using SistemaComex.Menus;
using SistemaComex.Modelos;
using System.Net;
using System.Text.Json;

string mensagemBoasVindas = "Sejam Bem Vindos ao Sistema Comex";
List<Produto> produtos = new List<Produto>() {

    new Produto("Arroz 5kg") { Quantidade = 18, PrecoUnitario = 15.50m},
    new Produto("Café 500g") { Quantidade = 60, PrecoUnitario = 14.90m },
    new Produto("Leite Integral 1L") { Quantidade = 50, PrecoUnitario = 5.20m },
    new Produto("Óleo de Soja 900ml") { Quantidade = 40, PrecoUnitario = 8.99m },
    new Produto("Açúcar 2kg") { Quantidade = 35, PrecoUnitario = 4.30m }
};

List<Cliente> clientes = new() {
    new Cliente("Lionel Luffy Uzumaki"){CPF = "000.000.000-01"}
};
List<Pedido> pedidos = new() {
   
};


Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuCadastrarProduto());
opcoes.Add(2, new MenuListarProdutos());
opcoes.Add(3, new MenuOrdernarPorTitulo());
opcoes.Add(4, new MenuOrdernarPorPreco());
opcoes.Add(5, new MenuConsultarAPI());
opcoes.Add(6, new MenuCadastrarCliente(clientes));
opcoes.Add(7, new MenuListarCliente(clientes));
opcoes.Add(8, new MenuCadastrarPedido(pedidos, clientes));
opcoes.Add(9, new MenuListarPedido(pedidos));
opcoes.Add(10, new MenuAdicionarItem(pedidos));
opcoes.Add(11, new MenuDetalharPedido(pedidos));

async Task ExibirMenu()
{
    Console.WriteLine(@"
░█████╗░░█████╗░███╗░░░███╗███████╗██╗░░██╗
██╔══██╗██╔══██╗████╗░████║██╔════╝╚██╗██╔╝
██║░░╚═╝██║░░██║██╔████╔██║█████╗░░░╚███╔╝░
██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░░██╔██╗░
╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗██╔╝╚██╗
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝");

    Console.WriteLine("\n" + mensagemBoasVindas);
    Console.WriteLine("\n1 - Criar Produto.");
    Console.WriteLine("2 - Listar Produtos.");
    Console.WriteLine("3 - Ordernar Produtos por Titulo.");
    Console.WriteLine("4 - Ordernar Produtos por Preço.");
    Console.WriteLine("5 - Consultar API Externa.");
    Console.WriteLine("-1 - Sair.");
    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcaoEscolhidaNumerica > 0)
    {
        if (opcaoEscolhidaNumerica == 5)
        {
            await new MenuConsultarAPI().Executar();
        }
        else
        {
            Menu menu = opcoes[opcaoEscolhidaNumerica];
            menu.Executar(produtos);
            await ExibirMenu();
        }
    }
    else
    {
        Console.WriteLine("Tchau Tchau :)");
    }
}
await ExibirMenu();