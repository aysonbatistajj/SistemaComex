using SistemaComex.Modelos;

namespace SistemaComex.Menus;
internal class MenuCadastrarCliente : Menu
{
    public MenuCadastrarCliente(List<Cliente> clientes)
    {
        Clientes = clientes;
    }

    public List<Cliente> Clientes { get; set; }
    public override void Executar(List<Produto> produtos)
    {
        Console.Clear();
        ExibirTitulo("Cadastrar Cliente");
        Console.WriteLine("Digite o nome do cliente: ");
        string nomeCliente = Console.ReadLine()!;
        Console.Write("Digite o CPF do Cliente: ");
        string cpfCliente = Console.ReadLine()!;

        Cliente c = new(nomeCliente) { CPF = cpfCliente };
        Clientes.Add(c);

        Console.WriteLine("\nCliente Adicionado com Sucesso!\n\n");

        FinalizarOperacao();
    }
}