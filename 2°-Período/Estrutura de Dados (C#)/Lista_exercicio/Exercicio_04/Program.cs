/* Faça uma função que ordene um vetor de inteiros passado por parâmetro utilizando o
método bolha e retorne o número de trocas realizadas. */

public class Program
{
    public static void Main(string[] args)
    {
        int[] vet = new int[] {7, 1, 5, 0, 9, 6, 3, 2, 8, 4};
        int trocas = RetornaTrocas(vet);

        Imprime(vet, trocas);
    }

    public static int RetornaTrocas(int[] vetor)
    {
        int aux; 
        int contador = 0;
        bool houveTroca;

        do
        {
            houveTroca = false;
            for(int i = 0; i < vetor.Length-1; i++)
            {
                if(vetor[i] > vetor[i+1])
                {
                    aux = vetor[i];
                    vetor[i] = vetor[i+1];
                    vetor[i+1] = aux;
                    contador++;
                    houveTroca = true;
                }
            }

        }while(houveTroca);
        return contador;
    }

    public static void Imprime(int[] vet, int trocas)
    {
        Console.Write("Vetor ordenado: ");
        for(int i = 0; i < vet.Length; i++)
        {
            Console.Write(vet[i] + " ");
        }
        Console.WriteLine("\nNumero de trocas: {0}", trocas);
    }
}