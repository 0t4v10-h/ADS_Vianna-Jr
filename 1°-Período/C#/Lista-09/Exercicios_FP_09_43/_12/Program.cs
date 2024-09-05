/* Faça um programa que avalie o preço de um eletrodoméstico em
diferentes lojas. Faça a leitura das informações das lojas, que
contenham os seguintes campos: nome da loja, telefone e preço do
eletrodoméstico. Ao final, informe os dados de todas as lojas. Informe
também a média dos preços cadastrados e uma relação contendo o
nome e o telefone das lojas cujo preço estava abaixo da média. Utilize
funções para realizar operações de leitura e escrita e faça um menu
que possibilite ler todas as informações das lojas, ler uma loja com um
endereço específico, caso ela esteja cadastrada, e imprimir as
informações citadas anteriormente. */

class Program
{
    static void Main(string[] args)
    {
        Loja[] vet = new Loja[3];
        int i;
        string produto;
        Console.Write("Qual eletrodomestico voce esta interessado: ");
        produto = Console.ReadLine();

        for (i = 0; i < vet.Length; i++)
        {
            Console.WriteLine("Loja {0}", i+1);
            vet[i] = new Loja();
            lerLoja(vet[i]);
            Console.WriteLine();
        }
        dadosLoja(vet, produto);
        calcularMedia(vet);
    }
    static void lerLoja(Loja obj)
    {
        Console.Write("Nome da loja: ");
        obj.Nome = Console.ReadLine();

        Console.Write("Telefone: ");
        obj.Telefone = Console.ReadLine();

        Console.Write("Preço do eletrodomestico: ");
        obj.Preco = Convert.ToDouble(Console.ReadLine());
    }
    static void dadosLoja(Loja[] dados, string produto)
    {
        int i;
        Console.WriteLine("___________________________________________________");
        Console.WriteLine("Dados das lojas: ");
        for (i = 0; i < dados.Length; i++)
        {
            Console.WriteLine("Loja {0}: Telefone - {1} \nValor {2}: {3:n2}",dados[i].Nome, dados[i].Telefone, produto, dados[i].Preco);
            Console.WriteLine();
        }
    }
    static void calcularMedia(Loja[] vetor)
    {
        int i;
        double arma = 0;
        double media = 0;

        for (i = 0; i < vetor.Length; i++)
        {
            arma += vetor[i].Preco;
        }
        media = arma / vetor.Length;
        Console.Write("Media de preços: {0:n2}", media);
        Console.WriteLine("\nLoja com o preço abaixo da media: ");

        for (i = 0; i < vetor.Length; i++)
        {
            if (vetor[i].Preco < media)
            {
                Console.Write("Loja {0}, telefone {1}", vetor[i].Nome, vetor[i].Telefone);
            }
        }
    }
}