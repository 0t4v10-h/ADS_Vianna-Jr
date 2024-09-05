/* Ler um número inteiro e positivo e verificar se este é ou 
não um número primo. */

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine();
        int num;    
        int divisor = 0;    
        Console.Write("Informe um numero: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
         
        if (num < 0)
        {
            num *= -1;
            Console.WriteLine("O sinal de negativo foi desconsiderado.");
        }

        for (int cont = 1; num >= cont; cont++)
        {
           
            if (num % cont == 0)
            {
                divisor++;
            }
        }

        if (divisor == 2)
        {
             Console.Write("{0} é primo.", num);
        }     
        else
        {
            Console.Write("{0} não é primo.", num);
        }
    }
}

