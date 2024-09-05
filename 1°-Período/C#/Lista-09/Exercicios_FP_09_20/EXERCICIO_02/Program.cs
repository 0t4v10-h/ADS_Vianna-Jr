/* Defina uma classe para representar o peso e a altura de uma 
pessoa. Crie um programa que pergunte ao usuário o seu 
peso e a sua altura, atribuindo-os aos respectivos atributos de 
um objeto da classe criada. Imprima os atributos da classe 
criada. */

class Program
{
    static void Main(string[] args)
    {
        Peso_Altura pessoa = new Peso_Altura();

        Console.Write("Informe seu peso: ");
        pessoa.Peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe sua altura: ");
        pessoa.Altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nPeso: {0} \nAltura: {1:n2}", pessoa.Peso, pessoa.Altura);
    }
}