/* Faça uma função que receba por parâmetro um inteiro N, leia N
números inteiros e retorne a média aritmética dos números positivos lidos. No
método principal (Main), peça para o usuário informar quantos números ele deseja
ler, passe essa informação por parâmetro para a função criada e imprima o retorno
da função com 3 casas decimais. */

class Program
{
    static double retornaMedia(int numero)
    {
        int media = 0;
        int cont = 0;
        for (cont = 0; cont < numero; cont++)
        {
            int soma;
            Console.Write("Inteiro {0} de {1}: ", cont + 1, numero);
            soma = Convert.ToInt32(Console.ReadLine());
            media += soma;
        }
        return Convert.ToDouble(media) / cont;
    }
    static void Main(string [] args)
    {
        int num;
        double passar;
        Console.Write("Quantos números voce deseja ler: ");
        num = Convert.ToInt32(Console.ReadLine());

        passar = retornaMedia(num);
        Console.Write("Media: {0:n3}", passar);
    }
}
