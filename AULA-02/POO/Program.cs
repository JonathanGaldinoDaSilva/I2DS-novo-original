using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        // comentario de linha

        /* 
        comentario de bloco
        pode fazer várias linhas
        */

        // escreve uma linha de texto na tela
        Console.WriteLine("programaçào orientado a objetos\n");

        Console.WriteLine("abstração - 1° pilar da POO");

        /* criar uma classe em C# */
        //a classe deve ser declarada fora do bloco de programa

        /* criar um objeto a partir de uma classe */

        Pet pet1 = new Pet();
        pet1.nome = "totó";
        pet1.tipo = "cachorro";
        pet1.idade = 3;
        pet1.mostraronome();

        Pet pet2 = new Pet();
        pet2.nome = "Mingau";
        pet2.tipo = "gato";
        pet2.idade = 8;
        pet2.mostraronome();
        }
                public class Pet // nome da classe sempre inicia com letraa Maiusculas
    {
        // declaração dos atributos
        public string nome;
        public string tipo;
        public int idade;

        //declaração dos métodos
        public void mostraronome()
        {
            Console.WriteLine("meu nome é ", this.nome);
        }
    }
   
}

//
//
//