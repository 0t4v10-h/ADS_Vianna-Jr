/*  Faça um programa para ler a quantidade de um total de 5 
produtos que uma empresa tem em suas 7 lojas e imprimir em uma 
tabela:
a) o total de cada produto nestas lojas 
b) a loja que tem menos produtos */ 

class Program
{
    static void Main(string[] args)
    {
        int [,] mat = new int [5,7];
        int i, j;

        for (i = 0; i < mat.GetLength(0); i++)
        {
            Console.WriteLine("PRODUTO {0}", i+1);
            for (j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("Loja {0}: ",j+1);
                mat[i,j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        imprimeTabela(mat);
        somarLojas(mat);
    }
    static void imprimeTabela(int[,] matriz)
    {
        int i, j;
        int qtProdutos = 0;

        Console.WriteLine("LOJA           |  1  |  2  |  3  |  4  |  5  |  6  |  7  |  TOTAL PRODUTOS  |");
        Console.WriteLine("_______________|_____|_____|_____|_____|_____|_____|_____|__________________|");
        for (i = 0; i < matriz.GetLength(0); i++)
        {
            Console.Write("\nPRODUTO {0}      |", i+1);           
            for (j = 0; j < matriz.GetLength(1); j++)
            {               
                Console.Write("{0,3}  |", matriz[i,j]);
                qtProdutos += matriz[i,j];
            }
            Console.Write("       {0,3}        |", qtProdutos);
            qtProdutos = 0;
        }
        Console.WriteLine("\n_______________|_____|_____|_____|_____|_____|_____|_____|__________________|");
    }
    static void somarLojas(int[,] mat)
    {
        int i, j;
        int produtosLojas = 0;
        int menor = int.MaxValue;
        int armazenar = 0;

        Console.Write("PRODUTOS \nPOR LOJA       |");
        for (j = 0; j < mat.GetLength(1); j++)
        {
            for (i = 0; i < mat.GetLength(0); i++)
            {
                produtosLojas += mat[i,j];
            } 
            if (menor > produtosLojas)
            {
                menor = produtosLojas;
                armazenar = j+1;
            }

            Console.Write("{0,3}  |", produtosLojas);
            produtosLojas = 0;
        }
        Console.WriteLine();
        Console.WriteLine("LOJA COM MENOS PRODUTOS: {0}", armazenar);
    }
}