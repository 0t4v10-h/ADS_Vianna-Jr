/* Altere o algoritmo anterior para que seja 
informado se o número é divisível por 2 e 
por 3, mas que não seja divisível por 5.*/

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine();
        Console.WriteLine("Vamos ver se seu numero e divisivel\n por 2 e por 3, e que nao seja por 5");
        Console.WriteLine();
        int numero;
        Console.Write("Informe o valor de um numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0 && numero % 3 == 0  && numero % 5 != 0)
        {
            Console.Write("Seu numero se enquadra na questao.");           
        }
        else 
        {
            Console.Write("Nao se enquadra na questao.");
        }
    }
}
