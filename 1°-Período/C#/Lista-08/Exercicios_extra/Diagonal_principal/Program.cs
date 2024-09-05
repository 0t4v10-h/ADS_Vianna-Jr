/* Faça um programa que que leia uma matriz quadrada e exiba 
apenas os valores contidos na diagonal principal. */

class Program
{
    const int TAM = 5;
    static void Main(string[] args)
    {
        int [,] mat = new int [TAM,TAM];
        int i, j;

        for (i = 0; i < mat.GetLength(0); i++)
        {
            Console.WriteLine("LINHA {0}", i+1);
            for (j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("Elemento ({0},{1}): ", i, j);
                mat[i,j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        imprimeDiagonal(mat);
    }
    static void imprimeDiagonal(int [,] matriz)
    {
        int i, j;

        for (i = 0; i < matriz.GetLength(0); i++)
        {
            for (j = 0; j < matriz.GetLength(1); j++)
            {
                if (i == j)
                {
                    Console.Write("{0} ", matriz[i,j]);
                }
            }
        }
    }
}