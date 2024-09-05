/* Faça um procedimento que receba um número n inteiro e positivo. O procedimento deve
imprimir todos os números do intervalo entre 0 e n que são divisíveis por 2 e por 3
(simultaneamente). Restrição: não utilize comandos de repetição. */

public class Program
{
    public static void Main(string[] args)
    {
        int numero = 50;

        RetornaDivisivel(numero, 0);
    }

    public static void RetornaDivisivel(int num, int i)
    {
        if(i <= num)
        {
            if(i % 2 == 0 && i % 3 == 0 && i != 0)
            {
                Console.Write(i + " ");
            }
            RetornaDivisivel(num, i+1);
        }
    }
} 

