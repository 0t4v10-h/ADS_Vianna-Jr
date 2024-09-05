/* Faça um procedimento para calcular a multiplicação de 
uma matriz 3 x 4 por um escalar. Faça também um 
procedimento capaz de imprimir esta matriz. Ao final, 
desenvolva uma função principal onde será criada e lida uma 
matriz 3 x 4. Faça nesta função a chamada dos dois 
procedimentos criados anteriormente. */

class Program
{
    static void Main(string[] args)
    {
        int [,] matriz = new int [3,4];
        int escalar;
        int i, j;

        for (i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine("LINHA {0}", i+1);
            for (j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write("Elemento ({0},{1}): ", i, j);
                matriz[i,j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        Console.Write("Informe o escalar: ");
        escalar = Convert.ToInt32(Console.ReadLine());

        multiplicaMatrizes(matriz, escalar);
        imprimeMatriz(matriz);
    }

    static void multiplicaMatrizes(int[,] mat, int escalar)
    {
        int i, j;

        for (i = 0; i < mat.GetLength(0); i++)
        {
            for (j = 0; j < mat.GetLength(1); j++)
            {
                mat[i,j] *= escalar;
            }
        }
    }
    static void imprimeMatriz(int [,] m)
    {
        int i, j;
        Console.WriteLine("\nMatriz multiplicada pelo escalar:");

        for (i = 0; i < m.GetLength(0); i++)
        {
            for (j = 0; j < m.GetLength(1); j++)
            {
                Console.Write("{0,5}", m[i,j]);
            }
            Console.WriteLine("\n");
        }
    }
}