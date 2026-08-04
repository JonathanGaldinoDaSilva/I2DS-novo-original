internal class Program
{
    private static void Main(string[] args)
    {
        
        /* 
        se (condicao) for verdadeiro
        executar essa funçao 
        senão
        execute essa função
        
        if(condicao)
        {
        codigo se verdadeiro
        }else{
        codigo se falso
        }
         */

         // verificar se uma idade é maior do que 18 anos
         int idade = 10;
         if(idade >= 18)
        {
            Console.WriteLine("maior de idade");
        }
        else
        {
            Console.WriteLine("menor de idade");
        }

        /**************************************************************/
        Console.Write("digite a nota: ");
        int nota = int.Parse(Console.ReadLine());

        if(nota >= 7)
        {
            Console.WriteLine("aprovado");
        }
        else
        {
            Console.WriteLine("reprovado");

        /**************************************************************/

        bool bloqueado = false;
        if(!bloqueado)
            {
            Console.WriteLine("acesso permitido");
            }
        }

             /*****************************************************/

        Console.WriteLine("1 - Cadastrar");
        Console.WriteLine("2 - Consultar");
        Console.WriteLine("3 - Excluir");
        Console.WriteLine("4 - Sair");

        Console.Write("Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Cadastro selecionado.");
                break;
            case 2:
                Console.WriteLine("Consulta selecionada.");
                break;
            case 3:
                Console.WriteLine("Exclusão selecionada.");
                break;
            case 4:
                Console.WriteLine("Encerrando o Sistema.");
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}