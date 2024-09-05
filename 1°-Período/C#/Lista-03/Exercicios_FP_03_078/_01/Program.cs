/* Faça um procedimento que receba três valores
reais e imprima a média aritmética desses valores. */

using System.Diagnostics.Contracts;

class Program 
{
   
   
      static void ImprimeMedia(double n1, double n2, double n3)
    {
        double media;
        media = (n1 + n2 + n3) / 3.0;

    Console.Write("Media: {0}", media);
       
    }

    static void Main(string[] args) 
    {
        double valor1, valor2, valor3;
        
        Console.Write("Digite o valor de um numero: ");
        valor1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o segundo valor: ");
        valor2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o terceiro valor: ");
        valor3 = Convert.ToDouble(Console.ReadLine());
        
        ImprimeMedia(valor1, valor2, valor3);
    }

}
 