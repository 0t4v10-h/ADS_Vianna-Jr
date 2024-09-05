/* Escreva as funções recursivas que unem dois (arrays), sem elementos repetidos,
classificadas considerando que as duas listas não têm elementos em comum */

public class Program
{
    public static void Main(string[] args)
    {
        int[] vet1 = new int[] {0, 2, 4, 6, 8};
        int[] vet2 = new int[] {1, 3, 5, 7, 9};
        int[] juncao = new int[vet1.Length + vet2.Length]; 

        UnirVetores(vet1, vet2, juncao, 0, 0, 0);

        foreach (int num in juncao)
        {
            Console.Write(num + " ");
        }
    }

    public static void UnirVetores(int[] vet1, int[] vet2, int[] juncao, int i, int j, int k)
    {
        if(i < vet1.Length && j < vet2.Length)
        {
            if(vet1[i] < vet2[j])
            {
                juncao[k] = vet1[i];
                UnirVetores(vet1, vet2, juncao, i+1, j, k+1);
            }
            else if(vet2[j] < vet1[i])
            {
                juncao[k] = vet2[j];
                UnirVetores(vet1, vet2, juncao, i, j+1, k+1);
            }
            else
            {
                juncao[k] = vet1[i];
                UnirVetores(vet1, vet2, juncao, i+1, j+1, k+1);
            }
        }
        else if(i < vet1.Length)
        {
            juncao[k] = vet1[i];
            UnirVetores(vet1, vet2, juncao, i+1, j, k+1);
        }
        else if(j < vet2.Length)
        {
            juncao[k] = vet2[j];
            UnirVetores(vet1, vet2, juncao, i, j+1, k+1);
        }
    }
}