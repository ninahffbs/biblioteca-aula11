using aula11;
class Program
{
    static void Main()
    {
        Livro livro1 = new Livro(1, "Crime e Castigo");
        Pessoa pessoa1 = new Pessoa(1, "Nina");
        // Console.WriteLine($"{livro1.Titulo}, {livro1.Status}");
        // livro1.Emprestar("Nina");
        // Console.WriteLine($"{livro1.Titulo}, {livro1.Status}");
        // livro1.Devolver();
        // Console.WriteLine($"{livro1.Titulo}, {livro1.Status}");
        pessoa1.PegarLivro(livro1);
        foreach (var livro in pessoa1.Livros)
        {
            Console.WriteLine($"- {livro.Titulo} ({livro.Status})");
        }
        pessoa1.DevolverLivro(livro1);
        foreach (var livro in pessoa1.Livros)
        {
            Console.WriteLine($"- {livro.Titulo} ({livro.Status})");
        }
    }
}
