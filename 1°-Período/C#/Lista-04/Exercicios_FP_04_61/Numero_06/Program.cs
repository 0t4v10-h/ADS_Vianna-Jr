/* Elabore um programa que, dada a idade 
de um nadador, classifique-o em uma 
das seguintes categorias:
• infantil A = 5 – 7 anos
• infantil B = 8 – 10 anos
• juvenil A = 11 – 13 anos
• juvenil B = 14 – 17 anos
• adulto = 18 – 30 anos
• sênior = maiores de 30 anos */

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine();
        Console.Write("Vamos descobrir em qual categoria você está.");
        Console.WriteLine();
        Console.Write("Informe sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 5)
            Console.Write("Não é permitido");
        else if (idade <= 7)
            Console.Write("Infantil A");
        else if (idade <= 10)
            Console.Write("Infantil B");
        else if (idade <= 13)
            Console.Write("Juvenil A");
        else if (idade <= 17)
            Console.Write("Juvenil B");
        else if (idade >= 18 && idade <= 30)
            Console.Write("Adulto");
        else 
            Console.Write("Sênior");
    }
}