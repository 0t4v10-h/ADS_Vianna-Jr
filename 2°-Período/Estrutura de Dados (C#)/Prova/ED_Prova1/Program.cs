/* Questão 2) Faça um procedimento que receba um vetor de números reais e ordene-o utilizando para isso o método da inserção. Para esta questão, não é permitido o uso de nenhum outro método de ordenação que não seja o da inserção. */
public class Program
{
    public static void Main(string[] args)
    {
        double[] vetor = new double[]{2, 5, 8, 1, 4, 9, 3, 7, 1, 5, 8};
        MetodoInsercao(vetor);

        foreach (double num in vetor)
        {
            Console.WriteLine(num + " ");
        }

    }
    public static void MetodoInsercao(int[] vet)
{
    for(int i = 1; i < vet.Length; i++)
    {
        int chave = vet[i];
        int j = i-1;
        while(j >= 0 && chave < j)
        {
            vet[j] = vet[j+1];
            j--;
        }
        vet[j+1] = vet[j];
    }
}
}

