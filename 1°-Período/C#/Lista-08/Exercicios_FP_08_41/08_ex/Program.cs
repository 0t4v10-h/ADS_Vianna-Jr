/* Faça um programa que leia duas matrizes quadradas de 
dimensão 3. Crie um procedimento que multiplique as duas 
matrizes. Imprima o resultado. */

class Program
{
    const int TAM = 3;
    static void Main(string[] args)
    {
        int [,] mat1 = new int [TAM,TAM];
        int [,] mat2 = new int [TAM,TAM];
        int i, j;

        Console.WriteLine("PRIMEIRA MATRIZ");
        for (i = 0; i < mat1.GetLength(0); i++)
        {
            Console.WriteLine("LINHA {0}", i+1);
            for (j = 0; j < mat1.GetLength(1); j++)
            {
                Console.Write("Elemento ({0},{1}): ", i, j);
                mat1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }

        Console.WriteLine("SEGUNDA MATRIZ");
        for (i = 0; i < mat2.GetLength(0); i++)
        {
            Console.WriteLine("LINHA {0}", i+1);
            for (j = 0; j < mat2.GetLength(1); j++)
            {
                Console.Write("Elemento ({0},{1}): ", i, j);
                mat2[i,j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }

        multiplicaMatrizes(mat1, mat2);
    }

    static void multiplicaMatrizes(int[,] m1, int[,] m2)
    {
        int [,] multiplica = new int [TAM,TAM];
        int i, j;

        Console.WriteLine("MULTIPLICAÇÂO DAS MATRIZES");
        for (i = 0; i < multiplica.GetLength(0); i++)
        {
            for (j = 0; j < multiplica.GetLength(1); j++)
            {
                Console.Write("{0,5}", m1[i,j] * m2[i,j]);
            }
            Console.WriteLine();
        }
    }
}