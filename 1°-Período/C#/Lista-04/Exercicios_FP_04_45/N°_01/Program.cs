/* Ler dois números inteiros e informar se o 
primeiro valor lido é maior, menor ou igual 
ao segundo. */

class Program 
{
    static void Main(string [] args)
    {
        int num1, num2;
        Console.Write("Informe um numero inteiro: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe outro numero inteiro: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2)
        {
            Console.WriteLine("Os numeros sao iguais");
        }
        else 
        {
            if (num1 > num2)        
            Console.WriteLine("O numero {0} e maior que {1}", num1, num2);

            else
            Console.WriteLine("O numero {0} e menor que {1}", num1, num2);
        }
    }
}
