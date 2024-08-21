namespace ProjetoBiblioteca.Modelos;

internal class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public DateTime DataPublicacao { get; set; }
    public bool EstaEmprestado { get; set; }

    public Livro(string titulo)
    {
        Titulo = titulo;
    }
}
