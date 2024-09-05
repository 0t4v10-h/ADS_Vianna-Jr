/* Desenvolver um algoritmo para ler o valor 
inteiro da idade de uma pessoa e imprimir 
uma das mensagens: Se idade < 13: Criança;
Se 13 ≤ idade < 20: Adolescente; 
Se 20 ≤ idade < 60: Adulto;
Se idade ≥ 60: Idoso. */

class Program
{
    static void Main(string [] args)
    {
        int idade;
        Console.Write("Informe sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());        
  
        if (idade < 13)
            Console.Write("Criança");
        else if (idade < 20)
            Console.Write("Adolescente");
        else if (idade < 60)
            Console.Write("Adulto");
        else
            Console.Write("Idoso");
    }
}
