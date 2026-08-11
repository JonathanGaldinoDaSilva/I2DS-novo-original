internal class Program
{
    private static void Main(string[] args)
    {
        // aluno 1
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "caio";
        aluno1.Email = "ocaiao@gmail.com";
        aluno1.Nascimento = "23/10/1920";
        aluno1.Rm = 356744389;

        // aluno 2
        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Leo messi";
        aluno2.Email = "QueMiraBobo@gmail.com";
        aluno2.Nascimento = "23/10/1980";
        aluno2.Rm = 387484473;

        // aluno 3
        Aluno aluno3 = new Aluno();
        aluno3.Nome = "CR7";
        aluno3.Email = "Siiiir@gmail.com";
        aluno3.Nascimento = "23/10/1970";
        aluno3.Rm = 387483374;

        Console.WriteLine($"\n nome: {aluno1.Nome} | Rm: {aluno1.Rm}");
        Console.WriteLine($"\n nome: {aluno2.Nome} | Rm: {aluno2.Rm}");
        Console.WriteLine($"\n nome: {aluno3.Nome} | Rm: {aluno3.Rm}");

    }

    public class Aluno
    {
        public string Nome {get; set;}

        public string Email {get; set;}

        public string Nascimento {get; set;}

        public int Rm {get; set;}

    }
}