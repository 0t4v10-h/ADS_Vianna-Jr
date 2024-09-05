/* ) Faça um programa para exibir a soma de duas matrizes 
quadradas 3 x 3. Deverá ser criado um procedimento para 
ler uma matriz (será chamado duas vezes com parâmetros 
diferentes) e um segundo procedimento que irá imprimir a 
soma das matrizes passadas como parâmetro. */

class Program
{
    static void Main(string[] args)
    {
        int [,] mat1 = new int [3,3];
        int [,] mat2 = new int [3,3];

        Console.WriteLine("\n1° MATRIZ\n");
        lerMatriz(mat1);
        Console.WriteLine("\n2° MATRIZ\n");
        lerMatriz(mat2);

        somaMatrizes(mat1, mat2);
    }
           
    static void lerMatriz(int[,] m)
    {
         int i, j;

        for (i = 0; i < m.GetLength(0); i++)
        {
            Console.WriteLine("\nLINHA {0} ", i + 1);
            for (j = 0; j < m.GetLength(1); j++)
            {
                Console.Write("Valor {0},{1}: ", i, j);
                m[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    static void somaMatrizes(int[,] m1, int[,] m2)
    {
        int [,] soma = new int [3,3];
        int i, j;

        Console.WriteLine("\n SOMA DAS MATRIZES\n");
        for (i = 0; i < soma.GetLength(0); i++)
        {
            for (j = 0; j < soma.GetLength(1); j++)
            {
                Console.Write("{0,5}",m1[i,j] + m2[i,j]);
            }
            Console.WriteLine();
        }
    }
}
