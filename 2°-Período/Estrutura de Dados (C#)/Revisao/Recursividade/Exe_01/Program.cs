/*  Usando recursividade, calcule a soma de todos os valores de um array de reais. */

public class Program
{
    public static void Main(string[] args)
    {
        double[] numero = new double[] {7, 49.7, 2, 57, 29.5, 4, 12, 1, 22, 10.3};

        Console.Write(SomaReais(numero, 0, 0));
    }
    
    public static double SomaReais(double[] num, int i, double soma)
    {
        if(i == num.Length)
        {
            return soma;
        }
        else
        {
            soma += num[i];
            return SomaReais(num, i+1, soma);
        }
    }
}