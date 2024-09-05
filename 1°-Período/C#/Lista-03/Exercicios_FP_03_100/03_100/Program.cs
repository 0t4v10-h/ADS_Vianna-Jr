/* ) Faça uma função que receba a idade de uma 
pessoa em anos, meses e dias e retorne essa idade 
expressa em dias. */

class Program
{
    static int ConverteIdade(int anos, int meses, int dias)
    {
        int idade1, idade2, total;
        idade1 = anos * 365;
        idade2 = meses * 30;
        total = idade1 + idade2 + dias;
        return total;
    }

    static void Main(string [] args)
    {
        int idade, anos, meses, dias;
        Console.Write("Informe sua idade em anos: ");
        anos = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe sua idade em meses: ");
        meses = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe sua idade em dias: ");
        dias = Convert.ToInt32(Console.ReadLine());
        idade = ConverteIdade(anos, meses, dias);

        Console.Write("Sua idade em dias e: {0}", idade);
    }
}