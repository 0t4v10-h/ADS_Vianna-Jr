/* Faça uma função que leia números reais informados pelo usuário
enquanto o número lido for negativo. Assim que for lido um número não negativo, a
função deve retornar o número lido. Note que esta função não recebe parâmetros.
No método Main, use a sua função para ler um número real não negativo. */

class Program
{
    static double retornaPositivos()
    {
        double numero;
        Console.Write("Infome um número real não negativo: ");
        numero = Convert.ToDouble(Console.ReadLine());

        for (int cont = 0; numero < 0; cont++)
        {            
            Console.WriteLine("Número invalido.");
            Console.Write("Infome um número real não negativo: ");
            numero = Convert.ToDouble(Console.ReadLine());    
        }
        return numero;
    }
    static void Main(string [] args)
    {
        double recebe;   
        recebe = retornaPositivos();
        Console.Write("Número real não negativo {0}", recebe);       
    }
}