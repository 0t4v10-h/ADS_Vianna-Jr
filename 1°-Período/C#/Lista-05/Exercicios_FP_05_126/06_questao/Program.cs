/* Faça um programa que, dado um conjunto de valores inteiros e positivos 
(fornecidos um a um pelo usuário), determine qual o menor valor do conjunto. O 
final do conjunto de valores é conhecido através do valor zero, que não deve ser 
considerado.  */

class Program
{
    static void Main(string [] args)
    {
        int num; 
        Console.Write("Informe um número inteiro: ");
        num = Convert.ToInt32(Console.ReadLine());

        int menor = num;

        for (int i = 1; num > 0; i++)
        {
            Console.Write("Informe um número inteiro (digite 0 para sair): ");
            num = Convert.ToInt32(Console.ReadLine());

           
            if (num < menor)
            {
               if (num != 0)
               { 
                menor = num;
               }
            }         
        }
        Console.Write("Menor número: {0}", menor);
    }
}
