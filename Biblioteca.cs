namespace aula11;

public class Biblioteca
{
    public List<Livro> Livros { get; set; }
    public List<Pessoa> Pessoas { get; set; }

    public Biblioteca()
    {
        Livros = new List<Livro>();
        Pessoas = new List<Pessoa>();
    }

    public void CadastrarLivro(Livro livro)
    {
        foreach (var item in Livros)
        {
            if (item.Isbn == livro.Isbn)
            {
                Console.WriteLine("Esse livro já está cadastrado!");
                return;
            }
        }
        Livros.Add(livro);
        Console.WriteLine("Livro cadastrado com sucesso!");
    }
    public void CadastrarUsuario(Pessoa pessoa)
    {
        foreach (var item in Pessoas)
        {
            if (item.Id == pessoa.Id)
            {
                Console.WriteLine("Essa pessoa já está cadastrada no sistema");
                return;
            }
        }
        Pessoas.Add(pessoa);
        Console.WriteLine("Usuário cadastrado com sucesso!");
    }
    public void ListarLivros()
    {
        if (Livros.Count == 0)
        {
            Console.WriteLine("Não há nenhum livro cadastrado no momento.");
            return;
        }
        foreach (var item in Livros)
        {
            Console.WriteLine($"{item.Isbn} - {item.Titulo}, {item.Status}");
        }
    }
    public void EmprestarLivro(Livro livro, Pessoa pessoa)
    {
        bool livroCadastrado = false;
        bool pessoaCadastrada = false;

        foreach (var item in Livros)
        {
            if (item.Isbn == livro.Isbn)
            {
                livroCadastrado = true;
                break;
            }
        }
        foreach (var item in Pessoas)
        {
            if (item.Id == pessoa.Id)
            {
                pessoaCadastrada = true;
                break;
            }
        }

        if (!livroCadastrado)
        {
            Console.WriteLine("Livro não cadastrado na biblioteca.");
            return;
        }

        if (!pessoaCadastrada)
        {
            Console.WriteLine("Pessoa não cadastrada na biblioteca.");
            return;
        }

        if (livro.Status != "Disponível")
        {
            Console.WriteLine("Livro indisponível para empréstimo.");
            return;
        }
        pessoa.PegarLivro(livro);
    }
}