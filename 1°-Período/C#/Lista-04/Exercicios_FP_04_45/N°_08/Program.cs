/* Elaborar um algoritmo para ler o código 
de um produto e informar a sua origem:
a) Código do produto entre 1 e 20: Europa
b) Código do produto entre 21 e 40: Ásia
c) Código do produto entre 41 e 60: América
d) Código do produto entre 61 e 80: África
e) Código do produto maior que 80: Paraguai */

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine();
        Console.WriteLine("Vamos descobrir a origem do seu produto.");
        Console.WriteLine();
        int codigo;
        Console.Write("Informo o código do produto: ");
        codigo = Convert.ToInt32(Console.ReadLine());

        if (codigo > 1 && codigo < 20)
            Console.Write("Europa");
        else if (codigo < 40)
            Console.Write("Àsia");
        else if (codigo < 60)
            Console.Write("América");
        else if (codigo < 80)
            Console.Write("Àfrica");
        else 
            Console.Write("Paraguai");
    }
}
