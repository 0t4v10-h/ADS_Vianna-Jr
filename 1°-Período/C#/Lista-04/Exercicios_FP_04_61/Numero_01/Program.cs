/* Faça um programa que leia dois números 
inteiros e faça a divisão do primeiro pelo 
segundo (se o segundo for diferente de 
zero). */

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine();
        double num1, num2;
        Console.Write("Digite um número inteiro: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite outro número intero: ");
        num2 = Convert.ToDouble(Console.ReadLine());
         if (num2 != 0)
         {
            double resultado = num1 / num2;
            Console.Write("A divisão dos seus numeros é {0}", resultado);
         }
         else
         {
            Console.Write("Número inválido, informe outro número diferente de 0.");
         }
    }
}
