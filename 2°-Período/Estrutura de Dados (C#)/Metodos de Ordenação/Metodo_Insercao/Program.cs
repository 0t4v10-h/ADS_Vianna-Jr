public class Program
{
    public static void Main(string[] args)
    {
        var vetor = new int[] {  7, 3, 5, 2, 8, 4 , 0, 9, 1, 6};

        OrdenarPorInsercao(vetor);
        Imprime(vetor);
    }

    public static void OrdenarPorInsercao(int[] vet)
    {
        int atual;
        int i;

        for(int ultimoOrdenado = 0; ultimoOrdenado < vet.Length - 1; ultimoOrdenado++)
        {
            atual = vet[ultimoOrdenado + 1];

            for(i = ultimoOrdenado; i >= 0 && vet[i] > atual; i--)
                vet[i + 1] = vet[i];
            
            vet[i + 1] = atual;
        }
    }

    public static void Imprime(int[] vet)
    {
        for (int i = 0; i < vet.Length; i++)
        Console.Write($"{vet[i]} ");

        Console.WriteLine();
    }
}
