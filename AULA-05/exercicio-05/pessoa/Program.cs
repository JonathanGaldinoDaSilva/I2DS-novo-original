
    /*
    private static void Main(string[] args)
    {
        // funcionario 1
        funcionario func1 = new Funcionario();
        func1.Nome = "joão da silva";
        func1.IdadeAtual = 32;
        func1.Salario = 3242.45;
        func1.registro = 123;

        // funcionario 2
        Funcionario func2 = new Funcionario();
        func2.Nome = "joão da silva";
        func2.IdadeAtual = 32;
        func2.Salario = 3242.45;
        func2.registro = 123;

        // funcionario 3
        Funcionario func3 = new Funcionario();
        func3.Nome = "joão da silva";
        func3.IdadeAtual = 32;
        func3.Salario = 3242.45;
        func3.registro = 123;

        //exibindo os funcionarios
        Console.WriteLine("=== Funcionários ===");

        Console.WriteLine()
    }

    public class pessoa
    {
        public string Nome {get; set;}
        public string IdadeAtual{get; set;}

        public void Envelhecer( int anos)
        {
            IdadeAtual += anos;
        
        }

        public class Funcionario : pessoa
        {
            public double Salario {get; set;}
            public int registro {get; set;}
        }
        
    }
    */


internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro funcionário
        Funcionario funcionario1 = new Funcionario();
        funcionario1.Nome = "João da Silva";
        funcionario1.IdadeAtual = 32;
        funcionario1.Salario = 2750.00;
        funcionario1.Registro = 125;

        // Segundo funcionário
        Funcionario funcionario2 = new Funcionario();
        funcionario2.Nome = "Maria das Rosas";
        funcionario2.IdadeAtual = 67;
        funcionario2.Salario = 3750.00;
        funcionario2.Registro = 175;

        // Terceiro funcionário
        Funcionario funcionario3 = new Funcionario();
        funcionario3.Nome = "Tereza Teixeira";
        funcionario3.IdadeAtual = 69;
        funcionario3.Salario = 4750.00;
        funcionario3.Registro = 165;

        // Exibindo os funcionários
        Console.WriteLine("=== Funcionários ===");

        Console.WriteLine("\nFuncionário 1");
        Console.WriteLine($"Nome:  {funcionario1.Nome}");
        Console.WriteLine($"Idade:  {funcionario1.IdadeAtual}");
        Console.WriteLine($"Registro:  {funcionario1.Registro}");
        Console.WriteLine($"Salário:  {funcionario1.Salario:F2}");

        Console.WriteLine("\nFuncionário 2");
        Console.WriteLine($"Nome:  {funcionario2.Nome}");
        Console.WriteLine($"Idade:  {funcionario2.IdadeAtual}");
        Console.WriteLine($"Registro:  {funcionario2.Registro}");
        Console.WriteLine($"Salário:  {funcionario2.Salario:F2}");

        Console.WriteLine("\nFuncionário 3");
        Console.WriteLine($"Nome:  {funcionario3.Nome}");
        Console.WriteLine($"Idade:  {funcionario3.IdadeAtual}");
        Console.WriteLine($"Registro:  {funcionario3.Registro}");
        Console.WriteLine($"Salário:  {funcionario3.Salario:F2}");

        // Envelhecendo os funcionários
        funcionario1.Envelhecer(13);
        funcionario2.Envelhecer(22);
        funcionario3.Envelhecer(30);

        // Exibindo as novas idades
        Console.WriteLine("\n=== APÓS ENVELHECER ===");

        Console.WriteLine($"{funcionario1.Nome}: {funcionario1.IdadeAtual} anos");
        Console.WriteLine($"{funcionario2.Nome}: {funcionario2.IdadeAtual} anos");
        Console.WriteLine($"{funcionario3.Nome}: {funcionario3.IdadeAtual} anos");
    }

    public class Pessoa
    {
        public string Nome {get; set;}
        public int IdadeAtual {get; set;}
        public void Envelhecer(int anos)
        {
            IdadeAtual += anos;
        }
    }

    public class Funcionario : Pessoa
    {
        public double Salario {get; set;}
        public int Registro{get; set;}
    }
}
