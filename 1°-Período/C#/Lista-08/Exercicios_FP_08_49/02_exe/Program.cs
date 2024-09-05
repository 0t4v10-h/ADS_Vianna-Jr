/*  Faça um programa que leia uma matriz 7 x 5 e imprima a 
terceira coluna. */

class Program
{
    static void Main(string[] args)
    {
        int [,] mat = new int [7,5];
        int i, j;

        for (i = 0; i < mat.GetLength(0); i++)
        {
            Console.WriteLine("\nLINHA {0}", i+1);
            
            for (j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("Valor ({0},{1}): ", i, j);
                mat[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        imprimeColuna(mat);
    }

    static void imprimeColuna(int[,] m)
    {
        int i, j;

        for (i = 0; i < m.GetLength(0); i++)
        {
            for (j = 0; j < m.GetLength(1); j++)
            {
                if (j == 2)
                {
                    Console.Write("{0,5}", m[i,j]);
                }
            }
        }
    }
}
