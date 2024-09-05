/* Faça um programa que leia uma matriz quadrada de 
tamanho 10 e um procedimento que inverta as linhas pelas 
colunas em uma segunda matriz de mesmo tamanho. 
Imprima ao final a segunda matriz. */

class Program
{
    const int TAM = 10;

    static void Main(string[] args)
    {
        int [,] mat = new int [TAM,TAM];
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
        
        inverteMatriz(mat);
    }

    static void inverteMatriz(int [,] m)
    {
        int i, j;

        for (j = 0; j < m.GetLength(0); j++)
        {
            for (i = 0; i < m.GetLength(1); i++)
            {
                Console.Write("{0,5}", m[i,j]);
            }
            Console.WriteLine();
        }        
    }
}