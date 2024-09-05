/* Fazer um algoritmo para ler dois números e 
um dos símbolos das operações: +, -, * e /. 
Imprimir o resultado da operação efetuada 
sobre os números lidos. */

class Program 
{
    static void Main(string [] args)
    {
        double num1, num2; char op;
        Console.Write("informe o valor do primeiro numero: ");
        num1 = Convert.ToDouble(Console.ReadLine()); 
        Console.Write("Informe o valor do segundo numero: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe o operador: ");
        op = Convert.ToChar(Console.ReadLine());
        double resultado = 0.0;

        if (op == '+')
        resultado = num1 + num2;
        
        else if (op == '-')
        resultado = num1 - num2;
        
        else if (op == '*')
        resultado = num1 * num2;

        else if (op == '/')
        resultado = num1 / num2;

        Console.Write("O resultado da operação com o símbolo que voce escolheu é {0}", resultado);
    }
}
