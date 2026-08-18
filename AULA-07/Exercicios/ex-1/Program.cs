internal class Program
{
    public class Fruta
    {
        public string? Nome {get; set;}
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM LISTAS ===");

        // 1 - Iniciar um nova lista
        List<Fruta> listaFrutas = new List<Fruta>();

        Fruta fruta1 = new Fruta{ Nome = "morango "};
        Fruta fruta2 = new Fruta{ Nome = "banana"};
        Fruta fruta3 = new Fruta{ Nome = "mamao"};

        // 2 - Incluir elementos em uma lista
        listaFrutas.Add(fruta1);
        listaFrutas.Add(fruta2); 
        listaFrutas.Add(fruta3);

        // 3 - Percorrer todos os elementos de uma lista     
        foreach (var item in listaFrutas)
        {
            Console.WriteLine($"{item.Nome}");
        }

        // 4 - Alterar um elemento da lista
        listaFrutas[2].Nome = "caqui";
        
        Console.WriteLine();
        foreach (var fruta in listaFrutas)
        {
            Console.WriteLine($"{fruta.Nome}");
        }

        // 5 - Quantidade de elementos da lista
        Console.WriteLine();
        Console.WriteLine($"Quantidade de Elementos na lista: {listaFrutas.Count()}");

        // 6 - Remover um elemento da lista por índice
        listaFrutas.RemoveAt(0);
        Console.WriteLine();
        foreach (var fruta in listaFrutas)
        {
            Console.WriteLine($"{fruta.Nome}");
        }

        // 7 - Remover um elemento da lista por objeto 
        listaFrutas.Remove(fruta3);
        Console.WriteLine();
        foreach (var fruta in listaFrutas)
        {
            Console.WriteLine($"{fruta.Nome}");
        }
        

        // 8 - Remover todos os elementos da lista
        listaFrutas.Clear();
    }
}