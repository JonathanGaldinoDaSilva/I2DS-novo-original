internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM TELEFONE ===");
        // Sintaxe Dictonary<chave, valor>
        //                  <key, value>
        
        // 1 - Criar um dicionário vazio
        Dictionary<string, string> ListaTelefone = new Dictionary<string, string>();
        
        // 2 - Adicionar elementos no ListaTelefone
        ListaTelefone.Add("Karina Vizinha","11 12121212");
        ListaTelefone.Add("Gustavo professor", "11 12121212");
        ListaTelefone.Add("Fernando Professor", "11 12121212");
        ListaTelefone.Add("Cristiano Dev full-stack", "11 12121212");

        // 3 - Percorrer todos os elemetos de um ListaTelefone
        Console.WriteLine();
        foreach (var item in ListaTelefone)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 4 - Alterar um elemento do ListaTelefone
        ListaTelefone["Karina"] = "Construção destinada à moradia definitiva ou temporária.";
        Console.WriteLine();
        foreach (var item in ListaTelefone)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 5 - Verificar se uma chave (key) existe dentro do dicionário
        string telefone;
        bool chaveExiste = ListaTelefone.TryGetValue("Nome", out telefone);
        Console.WriteLine();
        if (chaveExiste)
        {
            Console.WriteLine($"A palavra foi encontrada: {telefone}");
        }
        else
        {
            Console.WriteLine("A palavra não foi encontrada no dicionário");
        }

        // 6 - Excluir um elemento do ListaTelefone -> Somente por Chave(Key)
        ListaTelefone.Remove("Casa");
        Console.WriteLine();
        foreach (var item in ListaTelefone)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 7 - Ordenar um Dicionario por chave
        var TelefoneOrdenado = ListaTelefone.OrderBy(i => i.Key);
        Console.WriteLine();
        foreach (var item in TelefoneOrdenado)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}