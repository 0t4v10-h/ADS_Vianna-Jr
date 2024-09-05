/* Faça um programa que receba três nomes de no máximo 100
caracteres cada e as idades das respectivas pessoas em um
vetor de objetos. Após o recebimento, listar os três nomes
armazenados neste vetor por ordem crescente de idades. */ 

class Program
{
    static void Main(string[] args)
    {
        Pessoas[] vet_pessoas = new Pessoas [3];
        int i;

        for (i = 0; i < vet_pessoas.Length; i++)
        {
            vet_pessoas[i] = new Pessoas();
            Console.Write("\nInforme o {0}º nome: ", i+1);
            vet_pessoas[i].Nome = Console.ReadLine();

            Console.Write("Informe a {0}° idade: ", i+1);
            vet_pessoas[i].Idade = Convert.ToInt32(Console.ReadLine());
        }

        Pessoas armazenar;

        if (vet_pessoas[0].Idade > vet_pessoas[1].Idade)
        {
            armazenar = vet_pessoas[0];
            vet_pessoas[0] = vet_pessoas[1];
            vet_pessoas[1] = armazenar;
        }

        if (vet_pessoas[1].Idade > vet_pessoas[2].Idade)
        {
            armazenar = vet_pessoas[1];
            vet_pessoas[1] = vet_pessoas[2];
            vet_pessoas[2] = armazenar;
        }

        if (vet_pessoas[0].Idade > vet_pessoas[1].Idade)
        {
            armazenar = vet_pessoas[0];
            vet_pessoas[0] = vet_pessoas[1];
            vet_pessoas[1] = armazenar;
        }
        
        Console.WriteLine("Pessoas em ordem crescente de idade:");

        for (i = 0; i < vet_pessoas.Length; i++)
        {
            Console.WriteLine("{0} ({1})", vet_pessoas[i].Nome, vet_pessoas[i].Idade);
        }
    }
}