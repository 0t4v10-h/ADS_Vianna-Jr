/* Faça um programa que leia uma matriz quadrada de 
dimensão 10, uma função que encontre o maior valor desta 
matriz e uma função que encontre o menor valor. Imprima os 
valores encontrados na função principal. */

class Program
{
    const int TAM = 10;
    static void Main(string[] args)
    {
        int [,] mat = new int [TAM,TAM];
        int i, j;
        int maior, menor;

        for (i = 0; i < mat.GetLength(0); i++)
        {
            Console.WriteLine("\nLINHA {0}", i+1);
            for (j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("Elemento ({0},{1}): ", i, j);
                mat[i,j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        maior = encontraMaior(mat);
        menor = encontraMenor(mat);

        Console.Write("Maior valor encontrado: {0} \nMenor valor encontrado: {1}", maior, menor);
    }

    static int encontraMaior(int [,] matriz)
    {
        int maior = matriz[0,0];
        int i, j;

        for (i = 0; i < matriz.GetLength(0); i++)
        {
            for (j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i,j] > maior)
                {
                    maior = matriz[i,j];
                }
            }
        }
        return maior;
    }

    static int encontraMenor(int [,] matriz)
    {
        int menor = matriz[0,0];
        int i, j;

        for (i = 0; i < matriz.GetLength(0); i++)
        {
            for (j = 0; j < matriz.GetLength(1); j++)
            {
                if ( matriz[i,j] < menor)
                {
                    menor = matriz[i,j];
                }
            }
        }
        return menor;
    }
}