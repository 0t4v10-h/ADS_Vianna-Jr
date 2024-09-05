/* Dada a sequência de números: 3 4 9 2 5 8 2 1 7 4 6 2 9 8 5 1, ordene-a em ordem não
decrescente segundo os seguintes algoritmos, apresentando a sequência obtida após
cada passo do algoritmo: */

public class Program
{
    public static void Main(string[] args)
    {
        int[] numero = new int[] {3, 4, 9, 2, 5, 8, 2, 1, 7, 4, 6, 2, 9, 8, 5, 1};
        //int trocas = OrdenarMetodoBolha(numero);
        //int trocas = OrdenarMetodoInsercao(numero);
        int trocas = OrdenarMetodoSelecao(numero);


        Console.WriteLine("Numero de trocas: " + trocas);
        Console.Write("Vetor organizado: ");

        foreach(int num in numero)
        {
            Console.Write(num + " ");
        }

    }
    public static int OrdenarMetodoBolha(int[] num)
    {
        int trocas = 0;
        for(int i = 0; i < num.Length; i++)
        {
            for(int j = 0; j < num.Length-1-i; j++)
            {
                int aux;
                if(num[j] > num[j+1])
                {
                    aux = num[j];
                    num[j] = num[j+1];
                    num[j+1] = aux;
                    trocas++;
                }
            }
        }
        return trocas;
    }
    public static int OrdenarMetodoInsercao(int[] num)
    {
        int trocas = 0;
        for(int i = 1; i < num.Length; i++)
        {
            int chave = num[i];
            int j = i-1;
            while(j >= 0 && chave < num[j])
            {
                num[j+1] = num[j];
                j--;
                trocas++;
            }
            num[j+1] = chave;
        }
        return trocas;
    }

    public static int OrdenarMetodoSelecao(int[] num)
    {
        int trocas = 0;
        for(int i = 0; i < num.Length-1; i++)
        {
            int menor = i;
            for(int j = i+1; j < num.Length; j++)
            {
                if(num[j] < num[menor])
                {
                    menor = j;
                    trocas++;
                }
            }
            if(i != menor)
            {
                int aux = num[i];
                num[i] = num[menor];
                num[menor] = aux;
                trocas++;
            }
        }
        return trocas;
    }
}