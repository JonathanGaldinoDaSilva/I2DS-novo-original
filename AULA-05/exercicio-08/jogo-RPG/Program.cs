
internal class Program
{
    private static void Main(string[] args)
    {
        int num1d;
        int num2d;
        int num3d;
        int num4d;
        int num5d;
        int num6d;



        Console.Write("Escolha seu personagem: ");

        Console.WriteLine("\n1- Gigante");
        Console.WriteLine("2- QuiMario");
        Console.WriteLine("3- Máskara mago");

        num1d = int.Parse(Console.ReadLine());



        Console.WriteLine("1- ataque rápido: 80 pontos de xp");
        Console.WriteLine("2- espada encantada: 200 pontos de xp");
        Console.WriteLine("3- feitiço mágico: 0 pontos de xp/ atrapalha o adversário na próxima jogada");

        string loading;

        Console.Write("Decida-se: ");
        loading = Console.ReadLine();

       switch (loading)
       {
        
        case "1":
        Console.WriteLine("Uau!", num1d, "que rápido!");
        break;
        case "2":
        Console.WriteLine("Cuidado", num1d, "para não se cortar!");
        break;
        case "3":
        Console.WriteLine("Esperto hein?", num1d);
        break;
        default:
        Console.WriteLine("essa opçao é invalida");
        break;
       };





    }
}
