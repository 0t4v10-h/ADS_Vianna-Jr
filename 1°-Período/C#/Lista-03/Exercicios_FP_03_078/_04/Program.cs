/* Escreva um procedimento que recebe dois
números inteiros e imprime, a soma, o produto, a
diferença, o quociente e o resto entre esses dois
números. */

class Program
{

    static void ImprimeInteiros (int n1, int n2)
    { 
         
        int valor1;
        int valor2;
        int valor3;
        int valor4;
        int valor5;

        valor1 = n1 + n2;
        valor2 = n1 * n2;
        valor3 = n1 - n2;
        valor4 = n1 / n2;
        valor5 = n1 % n2;
        Console.Write("A soma, o produto, a diferenca, o quociente e o resto do seu numero e: {0}, {1}, {2}, {3} e {4}.", valor1, valor2, valor3, valor4, valor5);
       

    }

    static void Main(string [] args)
    {

        int n1, n2;
        Console.Write("Informe o valor de um numero: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o valor de outro numero: ");    
        n2 = Convert.ToInt32(Console.ReadLine());

        ImprimeInteiros(n1, n2);
        Console.ReadKey();
    }

}
