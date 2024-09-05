/* Faça uma função que receba o valor de um produto 
e um percentual de desconto. A função deve retornar 
o valor do produto após a aplicação do desconto. */

class program
{

    static double percentualDesconto (double valor)

    {
        double desconto;
        desconto = valor - (valor * 15) / 100;
        return desconto;

    }

    static void Main (string [] args)
    
    {
        double valor, pagar;
        Console.Write("Informe o preco do produto: ");
        valor = Convert.ToDouble(Console.ReadLine());
        pagar = percentualDesconto (valor);
        Console.Write("O valor a pagar e {0}", pagar);
    }

}