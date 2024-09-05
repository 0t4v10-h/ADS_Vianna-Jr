/* Faça um programa que leia uma matriz de caracteres 5 x 
10 e uma função que conte quantas letras “a” aparecem na 
matriz. Você poderá fazer a leitura letra a letra ou considerar 
que cada linha da matriz é uma string. */

class Program
{
    static void Main(string[] args)
    {
        string [,] mat = new string [5,10];
        int i, j;
        int recebe;

        for (i = 0; i < mat.GetLength(0); i++)
        {
            Console.WriteLine("LINHA {0}", i+1);
            for (j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("Caractere ({0},{1}): ", i, j);
                mat[i,j] = Console.ReadLine();
            }
        }
        recebe = contaCaractere(mat);
        Console.Write("\nQuantidade de 'a' encontrado na matriz: {0}", recebe);
    }

    static int contaCaractere(string[,] matriz)
    {
        int i, j;
        int cont = 0;
        
        for (i = 0; i < matriz.GetLength(0); i++)
        {
            for (j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i,j] == "a")
                {
                    cont++;
                }
            }
        }
        return cont;
    }
}
/*
static void LerMatriz(char[,] mat)
{
    string linha;

    for (int i = 0; i < mat.GetLength(0); i++)
    {
        Console.Write("Linha de texto {0} de {1}: ", i + 1, mat.GetLength(0));
        linha = Console.ReadLine();

        for (int j = 0; j < mat.GetLength(1) && j < linha.Length; j++)
        {
            mat[i, j] = linha[j];
        }
    }
}
*/