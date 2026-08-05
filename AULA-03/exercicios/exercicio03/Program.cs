internal class Program
{
    private static void Main(string[] args)
    {
        int NotasAlu;
        int Nota1;
        int Nota2;
        int Nota3;
        

        Console.Write("Digite o nome do aluno: ");


        Console.Write("Digite a Primeira nota: ");
        Nota1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a Segunda nota: ");
        Nota2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        Nota3 = int.Parse(Console.ReadLine());

        double Media = (Nota1 + Nota2 + Nota3) / 3.0;

        if(Media >= 7.0)
        {
        Console.WriteLine("Voce foi aprovado! ");
        }
       else if (Media >= 5.0)
        {
            
        Console.WriteLine("voce está de recuperacao! ");
        }
        else 
        {
           Console.WriteLine("voce está reprovado! ");
        }

    }
}