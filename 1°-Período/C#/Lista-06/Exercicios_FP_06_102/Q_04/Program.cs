/*  Faça um algoritmo para ler e somar dois vetores
de 10 elementos inteiros. Imprima ao final os valores
dessa soma, elemento a elemento.  */

class Program
{
    static void Main(string [] args)
    {
        int i, j;
        int [] vetor1;
        vetor1 = new int [10];
        
        for (i = 0; i < vetor1.Length; i++)
        {
            Console.Write("Valor {0} de {1} do 1° Vetor: ", i + 1, vetor1.Length);
            vetor1[i] = Convert.ToInt32(Console.ReadLine());
        }

        int [] vetor2;
        vetor2 = new int [10];

        for (j = 0; j < vetor2.Length; j++)
        {
            Console.Write("Valor {0} de {1} do 2° Vetor: ", j + 1, vetor2.Length);
            vetor2[j] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();
        int cont, soma;

        for (cont = 0; cont < vetor1.Length; cont++)
        {
            soma = vetor1[cont] + vetor2[cont];
            Console.WriteLine("Soma dos valores {0} de {1}: {2}", cont + 1, vetor1.Length, soma);
        }
    }
}