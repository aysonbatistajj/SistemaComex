﻿using SistemaComex.Modelos;

namespace SistemaComex.Menus;
internal class MenuListarPedido : Menu
{
    public MenuListarPedido(List<Pedido> pedidos)
    {
        Pedidos = pedidos;
    }
    public List<Pedido> Pedidos { get; set; }
    public override void Executar(List<Produto> produtos)
    {
        Console.Clear();

        Random random = new Random();

        ExibirTitulo("Listar Pedido");
        var pedidosOrdenados = Pedidos.OrderBy(p => p.Cliente.Nome);
        foreach (var pedidos in pedidosOrdenados)
        {
            pedidos.detalharPedido();
        }
    }
}
