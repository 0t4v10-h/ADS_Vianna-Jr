/* Dado um array de inteiros e o seu número de elementos, inverta a posição dos seus elementos. */

public class Program
{
    public static void Main(string[] args)
    {
        int[] numero = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

        InvertePosicao(numero, 0, numero.Length-1);
        
        foreach (int num in numero)
        {
            Console.Write(num + " ");
        }
    }

    public static void InvertePosicao(int[] num, int i, int j)
    {
        if(i < j)
        {
            int aux = num[i];
            num[i] = num[j];
            num[j] = aux;
            InvertePosicao(num, i+1, j-1);
        }
    }
}