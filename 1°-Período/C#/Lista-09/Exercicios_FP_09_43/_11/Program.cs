/* Utilizando a classe definida no exercício anterior. Faça um
procedimento que recebe um parâmetro do tipo ingresso e outro
contendo um novo preço que atualiza o preço do ingresso para o novo
valor. E um procedimento que recebe um parâmetro do tipo ingresso e
mostra na tela os valores de seus campos. */

class Program
{    
    static void Main(string[] args)
    {
        Ingresso[] vet = new Ingresso[3];
        int i;

        for (i = 0; i < vet.Length; i++)
        {
            Console.Write("Ingresso {0} de {1}: ", i+1, vet.Length);
            vet[i] = new Ingresso();
            lerIngressos(vet[i]);
            Console.WriteLine();
        }
        mudarPreco(vet);
    }
    static void lerIngressos(Ingresso obj)
    {
        Console.Write("Local: ");
        obj.Local = Console.ReadLine();

        Console.Write("Preço: ");
        obj.Preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Atração: ");
        obj.Atracao = Console.ReadLine();
    }
    static void mudarPreco(Ingresso[] objMudar)
    {
        int mudar,armazenar, i;
        Console.Write("Informe qual ingresso mudara de preço: ");
        mudar = Convert.ToInt32(Console.ReadLine());

        Console.Write("Qual o novo valor do ingresso: ");
        armazenar = Convert.ToInt32(Console.ReadLine());

        if (mudar == 1)
        {
            objMudar[0].Preco = armazenar;
            Console.Write("Ingresso 1 -> Local: {0} - Preço: {1:n2} - Atração: {2}", objMudar[0].Local, objMudar[0].Preco, objMudar[0].Atracao);
        }
        else if (mudar == 2)
        {
            objMudar[1].Preco = armazenar;
            Console.Write("Ingresso 2 -> Local: {0} - Preço: {1:n2} - Atração: {2}", objMudar[1].Local, objMudar[1].Preco, objMudar[1].Atracao);
        }
        else 
        {
            objMudar[2].Preco = armazenar;
            Console.Write("Ingresso 3 -> Local: {0} - Preço: {1:n2} - Atração: {2}", objMudar[2].Local, objMudar[2].Preco, objMudar[2].Atracao);
        }
    }
}