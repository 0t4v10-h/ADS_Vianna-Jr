/* Dada uma dívida de 10000 reais que cresce a juros de 
2,5% ao mês e uma aplicação de 1500 reais com 
rendimento de 4% ao mês, escrever um algoritmo que 
determina o número de meses necessários para pagar 
a dívida. */

class Program
{
    static void Main(string [] args)
    {
        double valorDivida= 10000.0;
        double valorAplicacao= 1500.0;
        double jurosDivida= 0.025;
        double rendimento= 0.040;   
        Console.Write("Vamos ver quantos meses você vai lavar para pagar sua dívida.");            
        double dividaTotal = valorDivida;
        double aplicacaoTotal = valorAplicacao;       
        int cont = 0;
        
        while (dividaTotal >= aplicacaoTotal )
        {                                                             
            dividaTotal += (dividaTotal * jurosDivida);

            aplicacaoTotal += (aplicacaoTotal * rendimento);   
            cont++;
        }  
        Console.Write("Você levará {0} meses para pagar sua dívida.", cont);
        Console.ReadKey();              
    }
}