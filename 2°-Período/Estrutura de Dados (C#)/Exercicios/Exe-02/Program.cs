
/* Faça uma função recursiva que receba um vetor de inteiros por 
parâmetro e retorne a soma dos elementos pertencentes á este vetor.*/
 

internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor = new int[] {1, 2, 3, 4, 5};

        Console.WriteLine(retornaSoma(vetor));
    }
    
    static int retornaSoma(int[] vet, int i = 0, int soma = 0)
    {
        if(i >= vet.Length)
            return soma;
        
        soma += vet[i];
        return retornaSoma(vet, i + 1, soma);
    }
}