/* Faça um programa que leia uma matriz 6 x 3 e um 
procedimento que gere duas matrizes 3 x 3, a primeira com 
as 3 primeiras linhas e a outra com as restantes. */

class Program
{
    const int TAM = 3;

    static void Main(string [] args)
    {
        int [,] mat = new int [TAM+TAM, TAM];
        int i, j;

        for (i = 0; i < mat.GetLength(0); i++)
        {
            Console.WriteLine("LINHA {0}", i+1);

            for (j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("Elemento ({0},{1}): ",i, j);
                mat[i,j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        divideMatriz(mat);
    }

    static void divideMatriz(int[,] m)
    {
        int [,] m1 = new int [TAM,TAM];
        int [,] m2 = new int [TAM,TAM];
        int i, j;
        int k, l, n, o;

        /*Console.WriteLine("PRIMEIRA MATRIZ");
        for (i = 0; i < m1.GetLength(0); i++)
        {
            for (j = 0; j < m.GetLength(1); j++)
            {
                m1[i,j] = m[i,j];
                Console.Write("{0,5}", m1[i,j]);
            }
            Console.WriteLine();
        }*/
        
        for (i = 0; i < m.GetLength(0); i++)
        {
            for (j = 0; j < m.GetLength(1); j++)
            {
               
                if (i < m1.GetLength(0))
                {
                    m1[i,j] = m[i,j];
                }
            
                else
                {
                    m2[i - m1.GetLength(0),j] = m[i,j];
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n  PRIMEIRA MATRIZ:");
        for (k = 0; k < m1.GetLength(0); k++)
        {
            for (l = 0; l < m1.GetLength(1); l++)
            {
                Console.Write("{0,5}", m1[k,l]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n  SEGUNDA MATRIZ:");
        for (n = 0; n < m2.GetLength(0); n++)
        {
            for (o = 0; o < m2.GetLength(1); o++)
            {
                Console.Write("{0,5}", m2[n,o]);
            }
            Console.WriteLine();
        }
    }
}