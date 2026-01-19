namespace aula11;
public class Livro
{
    public int Isbn { get; set; }
    public string Titulo { get; set; }
    public string Status { get; set; }
    public string Locatario { get; set; }

    public Livro(int isbn, string titulo)
    {
        Isbn = isbn;
        Titulo = titulo;
        Status = "Disponível";
        Locatario = "";
    }
    public void Emprestar(string locatario)
    {
        if (Status == "Emprestado")
        {
            Console.WriteLine("Esse livro não está disponível para empréstimo");
        }
        else if (Status == "Disponível")
        {
            Status = "Emprestado";
            Locatario = locatario;
            Console.WriteLine("Livro emprestado com sucesso!");
        }
    }
    public void Devolver()
    {
        if (Status == "Disponível")
        {
            Console.WriteLine("Não se pode devolver esse livro.");
        }
        else if (Status == "Emprestado")
        {
            Status = "Disponível";
            Locatario = "";
            Console.WriteLine("Livro devolvido com sucesso!");
        }
    }
}