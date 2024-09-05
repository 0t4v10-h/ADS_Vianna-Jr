public class Program
{
    public static void Main(string[] args)
    {
        var vet = new int[] {  7, 3, 5, 2, 8, 4 , 0, 9, 1, 6};
        OrdenarPeloMetodoBolha(vet);
        Imprime(vet);
    }

    public static void OrdenarPeloMetodoBolha(int[] vetor)
    {
        int aux;
        bool houveTroca;

        do
        {
            houveTroca = false;
            for ((int i = 0; i < vetor.Length - 1; i++))         //   int i = 0; i < vetor.Length - 1 - i; i++
            {
                if (vetor[i] > vetor[i + 1])
                {
                    aux = vetor[i];
                    vetor[i] = vetor[i + 1];
                    vetor[i + 1] = aux;
                    houveTroca = true;
                }
            }
        } while (houveTroca);
    }

    /*
    MELHOR VERSÃO

    public static void OrdenarPeloMetodoBolha(int[] vetor)
    {
        int aux;
        int fim = vetor.Length - 1;
        int ultimaTroca;

        do
        {
            ultimaTroca = 0;

            for (int i = 0; i < fim; i++)
            {
                if (vetor[i] > vetor[i + 1])
                {
                    aux = vetor[i];
                    vetor[i] = vetor[i + 1];
                    vetor[i + 1] = aux;
                    ultimaTroca = i;
                }
            }

            fim = ultimaTroca;
        } while (fim > 0);
    }
    */

    public static void Imprime(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        Console.Write($"{vetor[i]} ");

        Console.WriteLine();
    }
}
