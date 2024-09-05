/* Faça um programa que leia um vetor de valores inteiros e
imprima-o na ordem crescente. O vetor deve ter tamanho N
(declare e utilize uma constante N). */

class Program
{
    const int N = 5;
    static void Main(string [] args)
    {
        int [] valores = new int [N];

        for (int i = 0; i < valores.Length; i++)
        {
            Console.Write("Valor {0} de {1}: ", i+1, N);
            valores[i] = Convert.ToInt32(Console.ReadLine());
        }
        lerValores(valores);
    }
    static void lerValores(int [] vetor)
    {
        
        for (int i = 0; i < N - 1; i++)
        {
           for (int j = i + 1; j < N; j++)
           {
                if (vetor[i] > vetor[j])
                {
                    int aux = vetor[i];
                    vetor[i] = vetor[j];
                    vetor[j] = aux;
                }
           }
        }

        Console.WriteLine("Valores em ordem crescentes:");
        for (int k = 0; k < N; k++)
        {
            Console.Write("{0}   ", vetor[k]);
        }
    }
}
