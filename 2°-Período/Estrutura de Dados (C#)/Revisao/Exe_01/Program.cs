public class Program
{
    /*    OUTRA FORMA
    public static int SomaParesEntre(int min, int max)
    {
        if (min > max)
            return 0;
            
        return (min % 2 == 0 ? min : 0) + SomaParesEntre(min + 1, max);
    }
    */

    public static int SomaParesEntre(int min, int max)
    {
        return SomaParesEntre(min, max, 0);
    }

    public static int SomaParesEntre(int min, int max, int soma)
    {
        if (min > max)
            return soma;

        if (min % 2 == 0)
            soma += min;
        
        return SomaParesEntre(min + 1, max, soma);
    }
    

    public static void Main(string[] args)
    {
        Console.WriteLine(SomaParesEntre(1, 5));
    }
}


