/* Faça uma função que receba dois números reais, a e b, e 
retorne o valor de ( A2 + B2)1/2. 
Obs: Para calcular a raiz quadrada será preciso utilizar 
a função Math.Sqrt().*/

class Program
{
    static double RetornaValores(double numA, double numB)
    {
        double total;
        total = Math.Sqrt(Math.Pow (numA , 2) + Math.Pow (numB , 2));
        return total;
    }
    static void Main(string [] args)
    {
        double num1, num2;
        Console.Write("Digite o primeiro numero: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o segundo numero: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        double valor = RetornaValores(num1, num2);
        Console.Write("{0:N}", valor);
    }
}        
