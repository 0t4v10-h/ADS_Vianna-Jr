/* Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e 
escreve o valor de E.
E = 1 + 1/2 + 1/3 + ... + 1/N */

class Program
{
    static void calcularValor(int numero)
    {        
        double e = 0;
        int cont;
        for(cont = 1; cont <= numero; cont++)
        {
            e += (1.0 / cont);
        }
        Console.Write("E = {0:n}", e);
    }
    static void Main(string [] args)
    {
        int num;
        Console.Write("Informe um número: ");
        num = Convert.ToInt32(Console.ReadLine());

        calcularValor(num);
    }
}
