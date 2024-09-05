/* Ler um número inteiro e informar se ele é 
divisível por 2. */

class Program
{
    static void Main(string [] args)
    {
        int numero;
        Console.Write("Informe o valor de um numero: ");
        numero = Convert.ToInt32(Console.ReadLine());
        bool resto = numero % 2 == 0;                
  
        if (resto)
        {
            Console.Write("O seu numero e divisivel por 2");
        }    
        else 
        {
            Console.Write("Seu numero nao e divisivel por 2");
        }
    }
}
