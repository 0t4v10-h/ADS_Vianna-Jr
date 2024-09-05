/* Faça um programa que leia um vetor de 15 posições
(reais) e depois um valor a ser procurado no vetor. Imprima
se o valor foi ou não encontrado e a quantidade de vezes que
o valor está presente no vetor. */

class Program
{
    static void Main(string [] args)
    {
        int [] vetor = new int [15];
        int procurar;
        
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Valor {0} de {1}: ", i + 1, vetor.Length);
            vetor [i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Qual valor deve ser procurado: ");
        procurar = Convert.ToInt32(Console.ReadLine());

        imprimeValor (vetor, procurar);
    }
    static void imprimeValor(int [] vetor, int procurar)
    {
        int armazenar = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (procurar == vetor[i])
            {
                armazenar++;
            }         
        }
        if (armazenar >= 1)
        {
            Console.Write("Valor {0} encontrado {1} vezes.", procurar, armazenar);
        }
        else 
        {
            Console.Write("Valor {0} não encontrado.", procurar);
        }
    }
}

