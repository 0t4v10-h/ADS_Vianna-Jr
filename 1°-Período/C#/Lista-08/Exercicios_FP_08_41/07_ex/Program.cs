/* Faça um programa que leia um vetor de dimensão 5 e uma 
matriz quadrada de dimensão 5. Crie um procedimento que 
multiplique o vetor pela matriz. Imprima o resultado. */

class Program
{
    const int TAM = 5;
    static void Main(string[] args)
    {
        int [,] mat = new int [TAM,TAM];
        int [] vet = new int [TAM];
        int i, j;

        Console.WriteLine("VAMOS MULTIPLICAR UMA MATRIZ POR UM VETOR.");
        Console.WriteLine("\nMATRIZ.");
        for (i = 0; i < mat.GetLength(0); i++)
        {
            Console.WriteLine("LINHA {0}: ", i+1);
            for (j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("Elemento ({0},{1}): ", i, j);
                mat[i,j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }

        Console.WriteLine("VETOR.");
        for (i = 0; i < vet.Length; i++)
        {
            Console.Write("Vetor{0} de {1}: ", i+1, vet.Length);
            vet[i] = Convert.ToInt32(Console.ReadLine());
        }

        multiplicaVetMat(mat, vet);
    }

    static void multiplicaVetMat(int [,] m, int [] v)
    {
        int i, j;

        Console.WriteLine("Resultado da multiplicação:");
        for (i = 0; i < m.GetLength(0); i++)
        {
            for (j = 0; j < m.GetLength(1); j++)
            {
                Console.Write("{0,5}", m[i,j] * v[i]);
            }
            Console.WriteLine();
        }

    }
}