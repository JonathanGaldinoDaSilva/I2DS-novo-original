internal class Program
{
    private static void Main(string[] args)
    {
        // primeiro livro 
        Livro livro1 = new Livro();
        livro1.Titulo = "snoop o cão";
        livro1.Editora = "Harry";
        livro1.AnoLancamento = 1954;

        // segundo livro
        Livro livro2 = new Livro();
        livro2.Titulo = "turma da magali";
        livro2.Editora = "tiago";
        livro2.AnoLancamento = 1953;

        // terceiro livro
        Livro livro3 = new Livro();
        livro3.Titulo = "Ratata";
        livro3.Editora = "bobb";
        livro3.AnoLancamento = 1934;

        Console.WriteLine("=== LIVROS ===");
        Console.WriteLine($"\nlivro 1:  {livro1.Titulo} | Autor: {livro1.Editora}");
        Console.WriteLine($"\nlivro 2:  {livro2.Titulo} | Autor: {livro2.Editora}");
        Console.WriteLine($"\nlivro 3:  {livro3.Titulo} | Autor: {livro3.Editora}");

    }

    public class Livro
    {
        public string Titulo {get; set;}

        public string Autor {get; set;}

        public string Editora {get; set;}

        public int AnoLancamento {get; set;}
    }


}