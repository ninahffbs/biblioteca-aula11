using aula11;
class Program
{
    static void Main()
    {
        Livro livro1 = new Livro(1, "Crime e Castigo");
        Console.WriteLine($"{livro1.Titulo}, {livro1.Status}");
        livro1.Emprestar("Nina");
        Console.WriteLine($"{livro1.Titulo}, {livro1.Status}");
        livro1.Devolver();
        Console.WriteLine($"{livro1.Titulo}, {livro1.Status}");
    }
}
