﻿using SistemaComex.Modelos;

namespace SistemaComex.Menus;
internal class MenuCadastrarProduto : Menu
{

    public override void Executar(List<Produto> produtos)
    {
        base.Executar(produtos);

        ExibirTitulo("Cadastrar Produtos");

        Console.Write("Insira o nome do produto: ");
        string nomeProduto = Console.ReadLine()!;

        Console.Write("Digite o Preço Unitário: ");
        string preco = Console.ReadLine()!;
        decimal precoConvertido = decimal.Parse(preco);
       

        Console.Write("Digite a Quantidade em Estoque: ");
        string quantidade = Console.ReadLine()!;
        int quantidadeConvertida = int.Parse(quantidade);


        Produto produto = new Produto(nomeProduto)
        {
            PrecoUnitario = precoConvertido,
            Quantidade = quantidadeConvertida
        };

        produtos.Add(produto);

        Console.WriteLine($"\nO Produto {nomeProduto} Cadastrado com Sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
    }
}