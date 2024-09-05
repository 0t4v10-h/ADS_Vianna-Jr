/* Faz um procedimento que le 10 nomes e pede 
ao usuario uma letra, no final imprima os nomes
que inicia com a letra que o usuario informou.*/

class Program
{
    static void Main(string[] args)
    {
        Pessoa[] pessoa = new Pessoa [10];
        int i, cont = 0;
        string entrada; 

        for (i = 0; i < pessoa.Length; i++)
        {
            Console.Write("Nome {0} de {1}: ", i+1, pessoa.Length);
            pessoa[i] = new Pessoa();
            lerNomes(pessoa[i]);
        }
        Console.Write("Digite uma letra: ");
        entrada = Console.ReadLine();
        char letra = entrada[0];

        for (i = 0; i < pessoa.Length; i++)
        {
            if (pessoa[i].Nome[0] == letra)
            {
                cont++;
            }
        }
        Console.Write("{0} nomes iniciam com a letra {1}.", cont, letra);
    }

    static void lerNomes(Pessoa obj)
    {
        Console.Write(" ");
        obj.Nome = Console.ReadLine();
    }
}
