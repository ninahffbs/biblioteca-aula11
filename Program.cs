using aula11;
class Program
{
    static void Main()
    {
        Livro livro1 = new Livro(1, "Crime e Castigo");
        Livro livro2 = new Livro(2, "Em agosto nos vemos");
        Pessoa pessoa1 = new Pessoa(1, "Nina");
        Biblioteca biblioteca = new Biblioteca();
        // Console.WriteLine($"{livro1.Titulo}, {livro1.Status}");
        // livro1.Emprestar("Nina");
        // Console.WriteLine($"{livro1.Titulo}, {livro1.Status}");
        // livro1.Devolver();
        // Console.WriteLine($"{livro1.Titulo}, {livro1.Status}");
        // pessoa1.PegarLivro(livro1);
        // foreach (var livro in pessoa1.Livros)
        // {
        //     Console.WriteLine($"- {livro.Titulo} ({livro.Status})");
        // }
        // pessoa1.DevolverLivro(livro1);
        // foreach (var livro in pessoa1.Livros)
        // {
        //     Console.WriteLine($"- {livro.Titulo} ({livro.Status})");
        // }
        biblioteca.CadastrarLivro(livro1);
        biblioteca.ListarLivros();
        biblioteca.CadastrarUsuario(pessoa1);
        biblioteca.EmprestarLivro(livro2, pessoa1);
        biblioteca.ListarLivros();
    }
}
