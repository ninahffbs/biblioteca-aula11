using Microsoft.VisualBasic;

namespace aula11;

public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public List<Livro> Livros { get; set; }

    public Pessoa(int id, string nome)
    {
        Id = id;
        Nome = nome;
        Livros = new List<Livro>();
    }
    public void PegarLivro(Livro livro)
    {
        if (livro.Status == "Disponível")
        {
            Livros.Add(livro);
            livro.Status = "Emprestado";
            Console.WriteLine($"Livro emprestado para {this.Nome} com sucesso");
        }
        else
        {
            Console.WriteLine("Não é possível pegar esse livro emprestado no momento.");
        }
    }
    public void DevolverLivro(Livro livro)
    {
        foreach (var item in Livros)
        {
            if (item == livro)
            {
                Livros.Remove(livro);
                livro.Status = "Disponível";
                Console.WriteLine($"Livro devolvido por {this.Nome} com sucesso");
                return;
            }
        }
        Console.WriteLine($"Esse livro não pode ser devolvido por {this.Nome}.");
    }
}