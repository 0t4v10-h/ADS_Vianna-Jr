/* Faça um programa que leia um conjunto de 20 valores e 
armazene-os num vetor V. Particione-o em dois outros 
vetores, P e I, conforme os valores de V forem pares ou 
ímpares. No final, imprima os valores dos 3 vetores. */

class Program
{
    static int TAM = 20;
    static void Main(string [] args)
    {
        int [] valores = new int [TAM];

        for (int i = 0; i < valores.Length; i++)
        {
            Console.Write("Valor {0} de {1}: ", i + 1, valores.Length);
            valores[i] = Convert.ToInt32(Console.ReadLine());
        }

        imprimeValores(valores);
    }

    static void imprimeValores(int [] v)
    {
        int [] p = new int [TAM];
        int [] i = new int [TAM];
        int j = 0;

        for (j = 0; j < v.Length; j++)
        {
            if (v[j] % 2 == 0)
            {
               p[j] = v[j]; 
            }
            else
            {
                i[j] = v[j];
            }       
        }

            Console.WriteLine("Valores: ");
            for (int k = 0; k < v.Length; k++)
            {
                Console.Write("{0}, ", v[k]);
            }
            Console.WriteLine("\nPares: ");
            for (int k = 0; k < p.Length; k++)
            {
                Console.Write("{0}, ", p[k]);
            }
            Console.WriteLine("\nÍmpares: ");
            for (int k = 0; k < i.Length; k++)
            {
                Console.Write("{0}, ", i[k]);
            }
    }
}