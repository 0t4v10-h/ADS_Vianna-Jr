/* Faça um procedimento que faça a leitura um vetor de 10
elementos inteiros e imprima somente os valores
armazenados nos índices pares. */

class Program
{
    static void Main(string [] args)
    {
        int [] vetor = new int [10];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Valor {0} de {1}: ", i + 1, vetor.Length);
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }
        indicePares (vetor);
    }

    static void indicePares(int [] vet)
    {
        for (int i = 0; i < vet.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Indice {0} valor: {1} ", i, vet[i]);
            }
        }
    }
}

