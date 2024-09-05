/* Faça um programa para ler dois números 
reais e verificar se ambos são maiores que 
zero. Caso positivo, informar “Valores são 
válidos”. Caso contrário, informar “Valores 
inválidos”.*/

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine();
        int num1, num2;
        Console.Write("Informe o valor de um numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Informe o valor de outro numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if (num1 > 0 && num2 > 0)
        {
            Console.Write("Valores são válidos");
        }
        else
        {
            Console.Write("Valores inválidos");
        }       
    }
}
