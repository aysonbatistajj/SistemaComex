using ProjetoBiblioteca.Modelos;
namespace ProjetoBiblioteca.Menus;
internal class MenuSair : Menu
{
    public override void Executar(Biblioteca biblioteca)
    {
        Console.WriteLine("Tchau Tchau :)");
    }
}