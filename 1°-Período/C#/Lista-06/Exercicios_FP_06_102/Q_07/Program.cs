/* Faça um algoritmo que leia, via teclado, 20 
valores do tipo inteiro e determine qual o menor 
valor existente no vetor e imprima esse valor e seu 
índice no vetor. */

class Program
{
    static void Main(string [] args)
    {
        int [] num = new int [20];
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write("Valor {0} de {1}: ", i + 1, num.Length);
            num[i] = Convert.ToInt32(Console.ReadLine());
        }

        int indice = 0;
        int menor = num [0];
        for (int j = 1; j < num.Length; j++)
        {
            if (num[j] < menor)
            {
                menor = num[j];
                indice = j;
            }
        }
        Console.Write("Menor valor: {0} \nNo indice: {1}", menor, indice);
    }
}
