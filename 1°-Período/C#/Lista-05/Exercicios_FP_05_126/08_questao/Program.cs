/* Elabore um programa que calcule N! (fatorial de N), sendo que o valor inteiro de 
N é fornecido pelo usuário. Sabendo que:
N! = N x (N-1) x (N-2) x ... x 3 x 2 x 1;
0! = 1, por definição.   */

class Program
{
    static int calcularFatorial(int num)
    {
        int fatorial = 1;
        for (int i = 1; i <= num; i++)
        {        
            fatorial *= i; 
        }
        return fatorial;
    }
    static void Main(string [] args)
    {
        int numero;
        double recebe;

        Console.Write("Informe um número inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());

        recebe = calcularFatorial(numero);
        Console.Write("N! de {0} é: {1}", numero, recebe);
    }
}
