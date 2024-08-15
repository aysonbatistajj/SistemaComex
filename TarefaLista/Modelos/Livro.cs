namespace SistemaComex.Modelos;
internal class Livro : Produto, IIdentificacao
{
    public Livro(string nome) : base(nome){
    }
    string Isbn { get; set; }
    int TotalPáginas { get; set; }

    public string Identificacao => $"Nome: {Nome} | ISBN: {Isbn}";
}