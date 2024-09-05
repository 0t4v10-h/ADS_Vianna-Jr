/* Para auxiliar os vendedores de uma loja na 
orientação aos clientes sobre as diversas 
formas de pagamento, desenvolver um 
algoritmo para:
49
a) Imprimir o seguinte menu:
Forma de pagamento:
- À vista.
- Cheque para trinta dias.
- Em duas vezes.
- Em três vezes.
- Em quatro vezes.
- A partir de cinco vezes.
Entre com sua opção:

b) Ler o código da opção de pagamento.

c) Imprimir uma das mensagens de acordo com 
a opção lida:
Opção = 1: Desconto de 20%
Opção = 2, 3 ou 4: Mesmo preço a vista
Opção = 5: Juros de 3% ao mês
Opção = 6: Juros de 5% ao mês
Opção <1 ou opção >6: Opção inválida */

class Program 
{
    static void Main(string [] args)
    {
        Console.WriteLine();
        Console.WriteLine("Forma de pagamento:");
        Console.WriteLine();
        Console.WriteLine("Opção 1 - À vista.");
        Console.WriteLine("Opção 2 - Cheque para trinta dias.");
        Console.WriteLine("Opção 3 - Em duas vezes.");
        Console.WriteLine("Opção 4 - Em três vezes.");
        Console.WriteLine("Opção 5 - Em quatro vezes.");
        Console.WriteLine("Opção 6 - A partir de cinco vezes.");
        Console.WriteLine();
        int opcao;
        Console.Write("Entre com sua opção: ");
        opcao = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        if (opcao == 1)
            Console.Write(" Desconto de 20%");
        else if (opcao == 2 || opcao == 3 || opcao == 4)
            Console.Write("Mesmo preço a vista.");
        else if (opcao == 5)
            Console.Write("Juros de 3% ao mês.");
        else if (opcao == 6)
            Console.Write("Juros de 5% ao mÊs.");
        else 
            Console.Write("Opção inválida");
    }
}

