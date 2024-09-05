/* Faça um procedimento que receba por parâmetro um número inteiro e
escreva “par” se o número recebido por parâmetro for par. Caso contrário, o
procedimento deve escrever “ímpar”. No método principal (Main), leia um número
inteiro e passe-o por parâmetro para o procedimento criado. */

class Program
{
    static void lerNumeros(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.Write("Seu número é PAR.");
        }
        else
        {
            Console.Write("Seu número é ÍMPAR.");
        }
    }
    static void Main(string [] args)
    {
        int num;
        Console.Write("Informe um número inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());

        lerNumeros(num);
    }
}
