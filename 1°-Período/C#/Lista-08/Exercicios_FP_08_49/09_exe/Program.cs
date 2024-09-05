/* Idem ao exercício 1, agora com o seguinte “Menu”:
Escolha uma opção de cálculo para matrizes:
1) Soma
2) Diferença
3) Transposta 
4) Produto
5) Sair
Opção:__ 
Na opção (3) o usuário só precisa fornecer uma matriz, nas opções
(1), (2) e (4) o usuário deve fornecer duas matrizes.
Observação, a matriz deve ser 3x3. */

class Program
{
    const int TAM = 3;
    static void Main(string[] args)
    {
        int opcao;

        Console.WriteLine("\nEscolha uma opção de cálculo para matrizes: ");
        Console.WriteLine("1) Soma \n2) Diferença \n3) Transposta \n4) Produto \n5) Sair");
        Console.Write("Opção: ");
        opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 5)
        {
            Console.Write("Você escolheu a opção 'SAIR'. ");
        }
        else if (opcao >= 1 && opcao <= 4)
        {
            gerarMatriz(opcao);
        }
        else
        {
            Console.WriteLine("Desculpe! Opção invalida.");
        }
    }

    static void gerarMatriz(int opc)
    {
        int[,] mat = new int [TAM,TAM];
        int i, j;

        Console.WriteLine("\nINFORME UMA MATRIZ: ");
        for (i = 0; i < mat.GetLength(0); i++)
        {
            Console.WriteLine("\nLINHA {0}", i+1);
            for (j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("Elemento ({0},{1}): ",i, j);
                mat[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        if (opc == 1 || opc == 2 || opc == 4)
        {
            somaDifProd(mat, opc);
        }

        else if (opc == 3)
        {
            Console.WriteLine("\nMATRIZ TRANSPOSTA:");

            for (j = 0; j < mat.GetLength(1); j++)
            {
                for (i = 0; i < mat.GetLength(0); i++)
                {
                    Console.Write("{0,5}", mat[i,j]);
                }
                Console.WriteLine();
            }
        }
    }

    static void somaDifProd(int[,] mat1, int opcao)
    {
        int[,] mat2 = new int [TAM,TAM];
        int[,] operacao = new int [TAM,TAM];
        int i, j, k, l;

        Console.WriteLine("\nVAMOS PRECISAR DE UMA SEGUNDA MATRIZ: ");
        for(i = 0; i < mat2.GetLength(0); i++)
        {
            Console.WriteLine("\nLINHA {0}", i+1);
            for(j = 0; j < mat2.GetLength(1); j++)
            {
                Console.Write("Elemento ({0},{1}): ", i, j);
                mat2[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine();
        if (opcao == 1)
        {
            Console.WriteLine("SOMA DAS MATRIZES: ");
        }
        else if (opcao == 2)
        {
            Console.WriteLine("DIFERENÇA ENTRE AS MATRIZES: ");
        }
        else if (opcao == 4)
        {
            Console.WriteLine("PRODUTO DAS MATRIZES: ");
        }

        for(k = 0; k < mat1.GetLength(0); k++)
        {
            for(l = 0; l < mat1.GetLength(1); l++)
            {
                if (opcao == 1)
                {
                    operacao[k,l] = mat1[k,l] + mat2[k,l];
                    Console.Write("{0,5}", operacao[k,l]);
                }

                else if (opcao == 2)
                {
                    operacao[k,l] = mat1[k,l] - mat2[k,l];
                    Console.Write("{0,5}", operacao[k,l]);
                }

                else if (opcao == 4)
                {
                    operacao[k,l] = mat1[k,l] * mat2[k,l];
                    Console.Write("{0,5}", operacao[k,l]);
                }
            }
            Console.WriteLine();
        }
    }
}