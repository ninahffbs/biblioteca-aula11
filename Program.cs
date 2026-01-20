using aula11;
using System;
class Program
{
    static void Main()
    {
        Pessoa pessoa1 = new Pessoa(1, "Nina");
        Biblioteca biblioteca = new Biblioteca();

        while (true)
        {
            Console.WriteLine("--- Bem vinde a biblioteca da Nina! <3 ---");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1- Listar todos os livros");
            Console.WriteLine("2- Emprestar livro");
            Console.WriteLine("3- Sair");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 3)
            {
                break;
            }
            else if (opcao == 1)
            {
                biblioteca.ListarLivros();
                continue;
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Para emprestar um livro, cadastre o usuário:");
                Console.WriteLine("Registre o nome do usuário:");
                string nome = Console.ReadLine();
                Random rnd = new Random();
                Pessoa pessoa = new Pessoa(rnd.Next(1, 1000), nome);
                biblioteca.CadastrarUsuario(pessoa);

                Console.WriteLine("\n--- Lista de livros: ---");
                biblioteca.ListarLivros();
                Console.WriteLine("Agora insira o id do livro que deseja emprestar:");
                int idEscolhido = int.Parse(Console.ReadLine());

                Livro livroEscolhido = null;
                foreach (var livro in biblioteca.Livros)
                {
                    if (livro.Isbn == idEscolhido)
                    {
                        livroEscolhido = livro;
                        break;
                    }
                }
                if (livroEscolhido == null)
                {
                    Console.WriteLine("Livro com esse Id não encontrado.");
                }
                else
                {
                    biblioteca.EmprestarLivro(livroEscolhido, pessoa);
                }
                continue;
            }
        }
    }
}
