/* ) Faça uma função que receba um vetor de números 
inteiros e um valor inteiro. A função deverá procurar este 
segundo valor neste vetor e retornar seu índice se for 
encontrado. Se o elemento não for encontrado, retornar -1. */

class Program
{
    static void Main(string [] args)
    {
        int [] vetor = new int [7];
        int procurar, recebe;

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Valor {0} de {1}: ", i + 1, vetor.Length);
            vetor [i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Valor a ser procurado: ");
        procurar = Convert.ToInt32(Console.ReadLine());

        recebe = retornaIndice(vetor, procurar);

        if (recebe >= 1)
        {
            Console.Write("Valor {0} encontrado no indice {1}", procurar, recebe);
        }
        else
        {
            Console.Write(recebe);
        }
    }
    static int retornaIndice(int [] vet, int procura)
    {
        int armazenar = 0;

        for (int i = 0; i < vet.Length; i++)
        {
            if (procura == vet[i])
            {
                armazenar = i;
            }
        }

        if (armazenar >= 1)
        {
            return armazenar;
        }

        else
        {
            return (-1);
        }
    }
}

