public class Program
{
    public static void Main(string[] args)
    {
        var vetor = new int[] { 7, 3, 5, 2, 8, 4 , 0, 9, 1, 6};
        OrdenarPorSelecao(vetor);
        Imprime(vetor);
    }

    public static void OrdenarPorSelecao(int[] vet)
    {
        int indiceMenor, aux;

        for(int i = 0; i < vet.Length - 1; i++)
        {
            indiceMenor = i;

            for(int j = i + 1; j < vet.Length; j++)
            {
                if(vet[j] < vet[indiceMenor])
                {
                    indiceMenor = j;
                }
            }

            if(indiceMenor != i)
            {
                aux = vet[i];
                vet[i] = vet[indiceMenor];
                vet[indiceMenor] = aux;
            }
        }
    }

    public static void Imprime(int[] vet)
    {
        for (int i = 0; i < vet.Length; i++)
        Console.Write($"{vet[i]} ");

        Console.WriteLine();
    }
}