internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM FILAS (FIFO) ===");

        // 1 - Cria um nova fila vazia
        Queue<string> filaBanco = new Queue<string>();

        // 2 - Adicionar elementos na fila
        filaBanco.Enqueue("João");           
        filaBanco.Enqueue("Maria");         
        filaBanco.Enqueue("Carlos");          
        filaBanco.Enqueue("Ana");         
        filaBanco.Enqueue("Pedro");         


        // 3 - Percorrer elementos de uma fila
        Console.WriteLine();
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 4 - Retirar um elemento da lista
        string pessoaRetirada = filaBanco.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada}");

        filaBanco.Enqueue("Paula");
        Console.WriteLine();
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 5 - Verificar se existe um determinado elemento na lista
        string procurar = "Joao";
        bool achou = filaBanco.Contains(procurar);
        Console.WriteLine();
        if (achou)
        {
            Console.WriteLine($"{procurar} está na fila!");
        }
        else
        {
            Console.WriteLine($"{procurar} está sendo atendido!");
        }
    }
}