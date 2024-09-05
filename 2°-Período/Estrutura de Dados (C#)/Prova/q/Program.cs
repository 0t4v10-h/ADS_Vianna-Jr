﻿/* Questão 2) Faça um procedimento que receba um vetor de números reais e ordene-o utilizando para isso o método da inserção. Para esta questão, não é permitido o uso de nenhum outro método de ordenação que não seja o da inserção. */
namespace q;
/*
public class Program
{
    public static void Main(string[] args)
    {
        double[] vetor = new double[]{6, 3, 8, 4, 5, 9, 1, 7};
        MetodoInsercao(vetor);

        foreach (double num in vetor)
        {
            Console.Write(num + " ");
        }

    }
    public static void MetodoInsercao(double[] vet)
    {
        for(int i = 1; i < vet.Length; i++)
        {
            double chave = vet[i];
            int j = i-1;
            while(j >= 0 && chave < vet[j])
            {
                vet[j+1] = vet[j];
                j--;
            }
            vet[j+1] = chave;
        }
    }
} */

/* Questão 1) Faça um procedimento que receba um vetor de inteiros por parâmetro e imprima a soma dos números divisíveis por 5 que não são divisíveis por 3 existentes neste vetor. O procedimento deve ser recursivo e nenhum uso de comando de repetição é permitido nesta questão. */


public class Program
{
    public static void Main(string[] args)
    {
        int[] vetor = new int[]{20, 5, 9, 35, 4, 10};

        ImprimeSoma(vetor, 0, 0);
    }

    public static void ImprimeSoma(int[] vet, int i, int soma)
    {
        if(vet[i] % 5 == 0)
        {
            if(vet[i] % 3 == 1)
            {
                soma += vet[i];
            }
        }
        
        if(i == vet.Length-1)
        {
            Console.WriteLine("Soma: " + soma);
        } 
 
        ImprimeSoma(vet, i+1, soma);
    }
} 