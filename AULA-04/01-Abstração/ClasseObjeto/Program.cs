using System.Threading.Tasks.Dataflow;

internal class Program
{
    private static void Main(string[] args)
    {
       /* classe -> é a abstração de um objeto do mundo real para o mundo computacional
       
       Objetivo -> é a instancia de uma classe
       */

       // instanciar um objeto do tipo Aluno
       Aluno aluno01 = new Aluno();
       Aluno aluno02 = new Aluno();

       //atribuir valores
        aluno01.Nome = "José da silva";
        aluno01.RM = 2444;
        aluno01.DataNascimento = new DateOnly(2010,01,15);

        aluno02.Nome = "João dos santos";
        aluno02.RM = 1234;
        aluno02.DataNascimento = new DateOnly(2006,12,07);

        //executar os métodos
        aluno01.ApresentarSe();
        aluno02.ApresentarSe();


    }

    public class Aluno // declaração de uma classe
    {
        // Atributos -> Características
        public string Nome {get; set; }
        public int RM {get; set; }
        public DateOnly DataNascimento {get; set; }

        // métodos -> ações ou funcionalidades
        public void ApresentarSe()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e meu RM é {RM} nasci na data {DataNascimento}");
        }
    }
}