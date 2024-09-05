internal class Program
{
    static bool EhPrimo(int numero)
    {
        int qtdeDivisores = 0;

        for (int divisor = 1; divisor <= numero; divisor++)
        {
            if (numero % divisor == 0)
            {
                qtdeDivisores++;
            }
        }

        return qtdeDivisores == 2;
    }

    private static void Main(string[] args)
    {
        int numero;

        Console.Write("Informe um inteiro positivo: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 0)
        {
            numero *= -1; //numero = numero * -1;
            Console.WriteLine("O sinal de negativo foi desconsiderado.");
        }

        if (EhPrimo(numero))
        {
            Console.WriteLine("{0} é primo!", numero);
        }
        else
        {
            Console.WriteLine("{0} NÃO é primo!", numero);
        }

    }
}

