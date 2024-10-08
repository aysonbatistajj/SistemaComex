﻿namespace SistemaComex.Modelos;

public class Eletronico
{
    public Eletronico(string nome, double preco)
    {
        Nome = nome;
        PrecoUnitario = preco;
    }
    public string Nome { get; }
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; }
    public string Descricao => $"Produto: {Nome} \nPreço Unitário: R$ {PrecoUnitario} \n{Quantidade} unidades em Estoque \n";

}