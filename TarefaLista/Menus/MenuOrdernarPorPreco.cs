﻿using SistemaComex.Modelos;

namespace SistemaComex.Menus;
internal class MenuOrdernarPorPreco : Menu
{
    public override void Executar(List<Produto> produtos)
    {
        base.Executar(produtos);

        base.Executar(produtos);
        ExibirTitulo("Produtos Ordenados por Preço");

        var produtosOrdenadosPorPreco =
            from produto in produtos
            orderby produto.PrecoUnitario ascending
            select produto;

        foreach (var produto in produtosOrdenadosPorPreco)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: R$ {produto.PrecoUnitario}");
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
        Console.ReadKey();
        Console.Clear();
    }
}