/* Faça um programa que leia 3 vetores reais de dimensão 
10 e um procedimento que gere uma matriz (10 x 3) onde 
cada coluna é dada por um destes vetores. */

class Program
{
    const int TAM = 10;
    static void Main(string[] args)
    {
        int [] vet1 = new int [TAM];
        int [] vet2 = new int [TAM];
        int [] vet3 = new int [TAM];
        int i, j, k;

        Console.WriteLine("VETOR 1:");
        for (i = 0; i < vet1.Length; i++)
        {
            Console.Write("valor {0} de {1}: ", i+1, vet1.Length);
            vet1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("VETOR 2:");
        for (j = 0; j < vet2.Length; j++)
        {
            Console.Write("valor {0} de {1}: ", j+1, vet2.Length);
            vet2[j] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("VETOR 3:");
        for (k = 0; k < vet3.Length; k++)
        {
            Console.Write("valor {0} de {1}: ", k+1, vet3.Length);
            vet3[k] = Convert.ToInt32(Console.ReadLine());
        }
        gerarMatriz(vet1, vet2, vet3);
    }

    static void gerarMatriz(int[] v1, int[] v2, int[] v3)
    {
        int [,] mat = new int [TAM,3];
        int i, j, k, l;

        Console.WriteLine("\nMatriz gerada pelos vetores:");
        for (i = 0; i < mat.GetLength(0); i++)
        {
            for (j = 0; j < mat.GetLength(1); j++)
            {
                mat[i,0] = v1[i];
                mat[i,1] = v2[i];
                mat[i,2] = v3[i];
            }
        }
        
        for (k = 0; k < mat.GetLength(0); k++)
        {
            for (l = 0; l < mat.GetLength(1); l++)
            {
                Console.Write("{0,5}", mat[k,l]);
            }
            Console.WriteLine();
        }
    }
}