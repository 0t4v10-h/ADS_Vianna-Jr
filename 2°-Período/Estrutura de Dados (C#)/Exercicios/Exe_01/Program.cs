
/* Faça um procedimento recursivo que receba um vetor
de inteiros e imprima todos os elementos desse vetor */
 

internal class Program
{
    private static void Main(string[] args)
    {
        var vetor = new int[] {1, 2, 3, 4, 5};

        imprime(vetor);
    }
    static void imprime(int[] vetor)
    {
        imprime(vetor,0);
    }

    static void imprime(int[] vetor, int indice)
    {
        if(indice >= vetor.Length)
        {
            Console.WriteLine();
            return;
        }

        Console.Write($"{vetor[indice]} ");
        imprime(vetor, indice + 1);
    }
}