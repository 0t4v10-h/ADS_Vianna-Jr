/* Desenvolva um programa que leia um vetor de números
reais, um escalar e imprima o resultado da multiplicação do
vetor pelo escalar. */

class Program
{
    static void Main(string [] args)
    {
        double [] vetor = new double [5];
        double escalar, mult = 0;
        int i;

        for (i = 0; i < vetor.Length; i++)
        {
            Console.Write("Valor {0} de {1}: ",i + 1, vetor.Length);
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.Write("Valor do escalar: ");
        escalar = Convert.ToDouble(Console.ReadLine());

        for (int j = 0; j < vetor.Length; j++)
        {
            mult = vetor[j] * escalar;
            Console.WriteLine("Multiplicação entre {0}° valor e {1}: {2} ",j + 1, escalar, mult);
        }
    }
}