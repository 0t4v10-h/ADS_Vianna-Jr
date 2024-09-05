/* Altere o algoritmo anterior para que seja 
informado se o número é divisível por 2 e 
por 3 simultaneamente. */

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("Vamos ver se seu numero e divisivel por 2 e por 3.");
        int numero;
        Console.Write("Informe o valor de um numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0 && numero % 3 ==0)
        {
            Console.Write("E divisivel.");            
        }
        else
        {
            Console.Write("Nao e divisivel.");
        }
    }
}
