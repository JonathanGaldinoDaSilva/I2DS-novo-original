internal class Program
{
    public class Aluno
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Idade {get; set;}
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM LISTAS ===");

        // 1 - Iniciar um nova lista
        List<Aluno> listaAlunos = new List<Aluno>();

        Aluno aluno1 = new Aluno{ 
        Nome = "olga",Idade = "12"};
        Aluno aluno2 = new Aluno{ 
        Nome = "diogenes",Idade = "25"};
        Aluno aluno3 = new Aluno{ 
        Nome = "patapin" ,Idade = "85"};

        // 2 - Incluir elementos em uma lista
        listaAlunos.Add(aluno1);
        listaAlunos.Add(aluno2); 
        listaAlunos.Add(aluno3);

        // 3 - Percorrer todos os elementos de uma lista     
        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"{item.Nome} - {item.Idade}");
        }

        // 4 - Alterar um elemento da lista
        listaAlunos[1].Idade = "55";
        

        
        
        Console.WriteLine();
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }

        // 5 - Quantidade de elementos da lista
        Console.WriteLine();
        Console.WriteLine($"Quantidade de Elementos na lista: {listaAlunos.Count()}");

        // 6 - Remover um elemento da lista por índice
        listaAlunos.RemoveAt(0);
        Console.WriteLine();
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }


        
        
        
    }
}