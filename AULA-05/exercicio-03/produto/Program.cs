internal class Program
{
    public class Produto
    {
        public int Codigo {get; set;}
        public string Nome {get; set;}
        public int Preco {get; set;}

        public int Quantidade {get; set;}

        public double ValorEstoque()
        {
            return Preco * Quantidade;
        }
    }


    private static void Main(string[] args)
    {
        // produto 1
        Produto produto1 = new Produto();
        produto1.Codigo = 10001;
        produto1.Nome = "teclado";
        produto1.Preco = 120;
        produto1.Quantidade = 2;

        // produto 2
        Produto produto2 = new Produto();
        produto2.Codigo = 10002;
        produto2.Nome = "mouse";
        produto2.Preco = 130;
        produto2.Quantidade = 5;

        // produto 3
        Produto produto3 = new Produto();
        produto3.Codigo = 10003;
        produto3.Nome = "monitor";
        produto3.Preco = 140;
        produto3.Quantidade = 9;
        

        Console.WriteLine("\nProduto 1");
        Console.WriteLine($"Código: {produto1.Codigo}");
        Console.WriteLine($"Nome: {produto1.Nome}");
        Console.WriteLine($"Preço: R$ {produto1.Preco:F2}");
        Console.WriteLine($"Estoque: {produto1.Quantidade}");
        Console.WriteLine($"Valor em estoque: R$ {produto1.ValorEstoque():F2}");

        Console.WriteLine("\nProduto 2");
        Console.WriteLine($"Código: {produto2.Codigo}");
        Console.WriteLine($"Nome: {produto2.Nome}");
        Console.WriteLine($"Preço: R$ {produto2.Preco:F2}");
        Console.WriteLine($"Estoque: {produto2.Quantidade}");
        Console.WriteLine($"Valor em estoque: R$ {produto2.ValorEstoque():F2}");
   
        Console.WriteLine("\nProduto 3");
        Console.WriteLine($"Código: {produto3.Codigo}");
        Console.WriteLine($"Nome: {produto3.Nome}");
        Console.WriteLine($"Preço: R$ {produto3.Preco:F2}");
        Console.WriteLine($"Estoque: {produto3.Quantidade}");
        Console.WriteLine($"Valor em estoque: R$ {produto3.ValorEstoque():F2}");
    }

}