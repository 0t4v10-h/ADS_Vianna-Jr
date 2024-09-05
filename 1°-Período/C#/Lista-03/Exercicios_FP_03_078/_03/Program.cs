/* Faça uma função que receba o valor de um produto 
e um percentual de acréscimo. A função deve retornar 
o valor do produto após a aplicação do acréscimo. */

class program
{

    static double percentualAcrescimo (double valor)
    {

        double acrescimo;
        acrescimo = valor + (valor * 15) / 100;
        return acrescimo;

    }

    static void Main (string [] args)
    {

        double valor, pagar;
        Console.Write("Informe o valor do produto: ");
        valor = Convert.ToDouble(Console.ReadLine());
        pagar = percentualAcrescimo (valor);

        Console.Write("O valor a pagar e {0} ", pagar);

    }
}
