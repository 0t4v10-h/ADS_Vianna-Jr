
/* 1)Faça um procedimento recursivo que receba um vetor
de inteiros e imprima todos os elementos desse vetor 

2) Faça uma função recursiva que receba um vetor de inteiros por 
parâmetro e retorne a soma dos elementos pertencentes á este vetor.*/
 

internal class Program
{
    private static void Main(string[] args)
    {
        var vetor = new int[] {1, 2, 3, 4, 5};

        retornaSoma(vetor[], 0);
    }
    
    public int retornaSoma(int[] vet, int i)
    {
        int soma = 0;
        if(i <= vet.Length)
        {
            soma += vet[i];
            return retornaSoma(vet[], i + 1);
        }
        return soma;
    }
}