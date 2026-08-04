internal class Program
{
    private static void Main(string[] args)
    {
        // criar uma variável
        // sintaxe: tipo variável nome_variavel = valor

        // tipos de dados primários
        /* int -> representação de números inteiros */
        int idade = 21;

        /* double -> representação de números decimais */
        double salario = 7535.25;
        float altura = 1.75f;
        decimal peso = 71.35m;

        /* string -> representação de um texto alphanumérico */
        string nome = "Douglas";
        string celular = "112233344";
        string cpf = "123.456.789-03";

        /* bool -> representa um numero Booleano (True or false) */
        bool estudante = true;
        bool temlimite = false;

        /* dateTime -> representação de data e hora */
        DateTime cadastro = new DateTime(2026,08,04,09,15,32);
        DateOnly nascimento = new DateOnly(2010,02,23);

        /**************************************************************/

        /* operadores matemáticos
        + -> somar
        - -> subtrair
        * -> multiplicar
        / -> divisão
        % -> resto da divisão
        ^ -> 
        */

        int n1 = 10;
        int n2 = 3;
        double resultado = 0;

        //calcular a soma:
        resultado = n1 + n2;
        Console.WriteLine("a soma dos números é: " + resultado);

        //calcular a subtracao:
        resultado = n1 - n2;
        Console.WriteLine("a subtracao dos números é: " + resultado);

        //calcular a multiplicacao:
        resultado = n1 * n2;
        Console.WriteLine("a multiplicacao  dos números é: " + resultado);

        //calcular a divisao:
        resultado = n1 / n2;
        Console.WriteLine("a divisao dos números é: " + resultado);

        //calcular o resto da divisao:
        resultado = n1 % n2;
        Console.WriteLine("o resto da divisao dos números é: " + resultado);

        //calcular a potencia:
        resultado = n1 ^ n2;
        Console.WriteLine("a potencia dos números é: " + resultado);
         Console.WriteLine("Valor de N1: " + n1);




       /** Operador de Incremento ++ **/
        n1++; // Aumento o Numero atual em + 1
        Console.WriteLine("Valor de N1: " + n1);

        /** Operador de Incremento += **/
        n1+=10; // n1 = n1 + 10;
        Console.WriteLine("Valor de N1: " + n1); 

        
        /** Operador de Decremento -- **/
        n1--; // Aumento o Numero atual em + 1
        Console.WriteLine("Valor de N1: " + n1);

        /** Operador de Decremento -= **/
        n1-=10; // n1 = n1 - 10;
        Console.WriteLine("Valor de N1: " + n1);  

        /**************************************************************/

        /* operadores relacionais -> realizam comparações */
        /*
         > -> maior que
         < -> menor que
         >= -> maior ou igual
         <= -> menor ou igual
         == -> igual
         != -> diferentes 
         */
         idade = 12;
         Console.WriteLine("a idade informada é maior que 18? " + (idade > 18));
         
         peso = 10;
         Console.WriteLine("o peso informado é menor que 60 kg? " + (peso <= 60));

         estudante = false;
         Console.WriteLine("o nome informado é de um estudante? " + (estudante == true));

        /**************************************************************/

        /* operadores lógicos -> permitem combinar 2 ou mais condições */

        /* 
        && -> operador lógico "E" 
        || -> operador lógico "OU"
        ! -> operador de negação
        */

        peso = 110;
        altura = 170;

        Console.WriteLine("peso: " + peso + " altura: " + altura);
        Console.Write((peso <= 100) && (altura > 180));

        Console.WriteLine("peso: " + peso + " altura: " + altura);
        Console.Write((peso <= 100) && (altura > 180));
    }
}