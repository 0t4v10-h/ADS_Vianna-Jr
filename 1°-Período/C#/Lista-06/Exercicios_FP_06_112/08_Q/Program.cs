/* Faça um programa que leia um vetor G[13] que é o
gabarito de um teste da loteria esportiva, contendo os valores
1 quando for coluna 1, 0 quando for coluna do meio e 2
quando for coluna 2.
Ler a seguir, para 5 apostadores, seu cartão de apostas
(R[13]) e depois da leitura imprimir quantos acertos o
apostador teve.
Faça o teste através de funções.  */

using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    const int TAM = 13;
    static void Main(string [] args)
    {
        int [] G = new int [TAM] {1, 0, 2, 1, 0, 2, 1, 0, 2, 1, 0, 2, 1};
        int resultado;

        for (int i = 0; i < 5; i++)
        {
            resultado = imprimirAcertos(G);
            Console.WriteLine("Apostador {0} teve {1} acertos.", i+1, resultado);
        }
        }
      
    static int imprimirAcertos(int [] G)
    {
        Console.WriteLine("Digite 13 numeros de apostas (Numeros validos 0, 1 e 2).");

        int [] R = new int [TAM];
        int cont = 0;

        for (int i = 0; i < R.Length; i++)
        {
            Console.Write("Numero {0} de {1}: ", i + 1, R.Length);
            R[i] = Convert.ToInt32(Console.ReadLine());

            if (R[i] == G[i])
            {
                cont++;
            }
        }
        return cont;
    }
}
