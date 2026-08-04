internal class Program
{
    private static void Main(string[] args)
    {
        int celcius;
        Console.Write("digite a temperatura em graus celcius: ");
        celcius = int.Parse(Console.ReadLine());

        double fahrenheit = (celcius * 9 / 5) + 32;

        Console.WriteLine("a temperatura em fahrenheit é: " + fahrenheit);
    }
}