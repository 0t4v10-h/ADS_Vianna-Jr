/*  Fazer um programa para calcular e mostrar os N primeiros termos da série de 
Fibonacci. O número N é fornecido pelo usuário. A série de Fibonacci é gerada 
da seguinte forma:
f1 = f2 = 1;
f3 = f1 + f2 = 2;
f4 = f2 + f3 = 3;....
O primeiro e segundo termos valem 1 e os seguintes são calculados somando 
os dois termos anteriores.   */

class Program
{
    static int calcularFibonacci(int num)
    {
        Console.WriteLine("A série de Fibonacci com os primeiros {0} termos é:", num);
        int primeiro = 1, segundo = 1;
        Console.Write("1   1   ");
        int proximoTermo = 1;
        
        for (int i = 3; i <= num; i++)
        {
            proximoTermo = primeiro + segundo;
            Console.Write("{0}   ", proximoTermo);

            primeiro = segundo;
            segundo = proximoTermo;  
        }
        return proximoTermo;
    }
    static void Main(string [] args)
    {
        int num; 
        Console.Write("Informe o número de termos da séria de Fibonacci você quer ver: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        int recebe = calcularFibonacci(num);
    }
}

