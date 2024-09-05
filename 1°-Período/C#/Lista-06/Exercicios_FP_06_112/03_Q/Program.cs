/* Faça um programa que leia um vetor com 15 valores reais.
A seguir, encontre o menor elemento do vetor e a sua
posição dentro do vetor, mostrando: "O menor elemento do
vetor está na posição XXXX e tem o valor YYYYY."  */

class Program
{
    static void Main(string [] args)
    {
        int [] vetor;
        vetor = new int [15];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Valor {0} de {1}: ", i + 1, vetor.Length);
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }
        lerMenor (vetor);
    }

    static void lerMenor(int [] vet)
    {
        int menor = vet[0], posicao = 1;

        for (int i = 0; i < vet.Length; i++)
        {
            if (menor > vet[i])
            {
                menor = vet[i];
                posicao = i + 1;
            }
        }
        Console.Write("O menor elemento do vetor está na posição {0} e tem o valor {1}. ", posicao, menor);
    }
}
