internal class Program
{
    private static void Main(string[] args)
    {
        
        /* vetores e matrizes 
        vetor -> é uma estrutura de dados utilizada para armazenar
        vários valores de um mesmo tipo dentro de uma unica variavel
        
        tipo[] nome_vetor = new tipo[tamanho];
        */

        /* iniciar um vetor -> lista de frutas */

        string[] listaFrutas = {"maca","manga","melancia","morango","melão"};

        Console.WriteLine("acessar o terceiro elemento da lista: ");
        Console.WriteLine(listaFrutas[2]);

        Console.WriteLine("alterar o segundo elemento da lista: ");
        listaFrutas[1] = "Banana";

        for (int indice = 0; indice < listaFrutas.Count(); indice++ )
        {
            Console.WriteLine(listaFrutas[indice]);
        }

        /**************************************************/

        foreach (string fruta in listaFrutas)
        {
            Console.WriteLine(fruta);
        }
        
    }
}