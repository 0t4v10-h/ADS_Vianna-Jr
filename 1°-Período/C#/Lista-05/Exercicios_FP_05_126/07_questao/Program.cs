/* A conversão de graus Fahrenheit para Centígrados é obtida pela fórmula 
C = 5/9(F – 32). Escreva um programa que calcule e escreva uma tabela de 
graus centígrados em função de graus Fahrenheit que variem de 50 a 150 de 1 
em 1.  */

class Program
{
    static double converterGraus(double f)
    {
        return 5.0 / 9.0 * (f - 32.0);
    }
    static void Main(string [] args)
    {
        Console.WriteLine("Fahrenheit | Celsius");
        Console.WriteLine("-----------|--------");

        double c = 0.0;
        for (int f = 50; f <= 150.0; f++)
        {
            c = converterGraus(f);

            Console.WriteLine($"{f,8}   |   {c,3:n}");
        }
    }
}
