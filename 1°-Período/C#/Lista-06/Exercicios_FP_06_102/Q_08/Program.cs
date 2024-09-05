/* Refaça o exercício anterior criando um 
procedimento que receba como parâmetro o vetor e 
imprima o menor valor e seu índice no vetor.
 */

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

        imprimirMenor (num);
    }

    static void imprimirMenor(int [] vetor)

    {
        int indice = 0;
        int menor = vetor [0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
                indice = i;
            }
        }
        Console.Write("Menor valor: {0} \nNo indice: {1}", menor, indice);
    }
}

