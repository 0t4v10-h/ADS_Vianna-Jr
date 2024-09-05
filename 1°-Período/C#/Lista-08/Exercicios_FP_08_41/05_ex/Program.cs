/* Faça um procedimento que receba uma matriz quadrada 
5 x 5 e crie uma matriz identidade. Imprima a matriz após 
sua inicialização em um outro procedimento. */

class Program
{
    const int TAM = 5;

    static void Main(string[] args)
    {
        int [,] mat = new int [TAM,TAM];
    
        imprimeMatID(mat);
    }

    static void imprimeMatID(int [,] m)
    {
        int i, j;
        for (i = 0; i < m.GetLength(0); i ++)
        {
            for (j = 0; j < m.GetLength(1); j++)
            {
                if (i == j)
                {
                    Console.Write("1  ");
                }
                else
                { 
                    Console.Write("0  ");
                }               
            }
        Console.WriteLine();
        }
        
    }
}