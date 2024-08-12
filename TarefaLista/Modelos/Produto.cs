using System.Text.Json.Serialization;

namespace SistemaComex.Modelos;
internal class Produto
{
    public Produto(string nome)
    {
        Nome = nome;
    }

    [JsonPropertyName("title")]
    public string Nome { get; set; }

    [JsonPropertyName("description")]
    public string Descricao => $"{Nome} | Preço: R${PrecoUnitario} e Possui {Quantidade} em Estoque";

    [JsonPropertyName("price")]
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; }
}