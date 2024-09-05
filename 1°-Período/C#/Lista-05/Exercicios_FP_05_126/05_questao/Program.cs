/* Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e 
escreve o valor de E.
E = 1 + 1/1! + 1/2! + 1/3! + ... + 1/N!   */

class Program
{
    static double lerValores(int num)
    {
        double e = 1.0;
        double dividir = 1.0;

        for (int cont = 1; cont <= num; cont++)
        {
            dividir *= cont;
            e += 1.0 / dividir;
        }
        Console.Write("Valor de E = {0:n}", e);
        return e;
    }
    static void Main(string [] args)
    {
        int numero;
        Console.Write("Informe o valor de um número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        lerValores (numero);
    }
}
