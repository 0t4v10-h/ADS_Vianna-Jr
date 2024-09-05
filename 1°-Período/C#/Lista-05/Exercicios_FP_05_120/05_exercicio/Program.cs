/* Calcular o valor de S:
S = 2/50 + 2²/48 + 2³/ 46 +...+ 2(elevado a 25)/2 */

class Program
{
    static void Main(string [] args)
    {
        double s = 0;
        int expoente, divisor = 50;

        for (expoente = 1; expoente <= 25; expoente++)
        {
            s += Math.Pow(2,expoente) / divisor;
            divisor -= 2;
        }
        Console.WriteLine("S = {0:n}", s);
        
    }
}

