/* Faça uma função que receba por parâmetro um número inteiro e
retorne “par” se o número recebido por parâmetro for par. Caso contrário, a função
deve retornar “ímpar”. No método principal (Main), leia um número inteiro e passeo por parâmetro para a função criada, imprimindo em seguida o seu retorno. */

class Program
{
    static string lerNumeros(int numero)
    {       
        if (numero % 2 == 0)
        {
            return "Par";
        }
        else 
        {
            return "Impar";
        }       
    }
    static void Main(string [] args)
    {
        int num;
        Console.Write("Informe um número inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());
       
        Console.Write("{0} é {1}", num, lerNumeros(num));
    }
}