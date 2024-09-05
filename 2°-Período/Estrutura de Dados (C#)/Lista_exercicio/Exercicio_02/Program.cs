/* Faça uma função que receba um vetor de números inteiros por parâmetro e multiplique
por -1 todos os elementos negativos desse vetor. A função deve retornar o número de
elementos negativos encontrados. Restrição: não utilize comandos de repetição. */

public class Program
{
    public static void RetornaNegativo(int[] vetor)
    {
        RetornaNegativo(vetor, 0, 0);
    }

    public static int RetornaNegativo(int[] vetor, int contador, int i)
    {
        if(i < vetor.Length)
        {
            if(vetor[i] < 0)
            {
                vetor[i] *= -1;
                contador ++;
            }
            return RetornaNegativo(vetor, contador, i+1);
        }
        return contador;
    }

    public static void Main(string[] args)
    {
        int[] vet = new int[] {5, -6, -2, 9, 8, 1, -7, 0, -3, 4};

        int negativos = RetornaNegativo(vet, 0, 0);
        Console.WriteLine("Quantidade de numeros negativos: {0}", negativos);
    }
}