/* Fazer um algoritmo que imprima todos os números 
pares no intervalo de 1 a 100. */

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine();
        for (int num = 1; num <= 100; num++)
        {
            if (num % 2 == 0)
            {
            Console.Write("{0} ", num);
            }
        }        
    }
}

