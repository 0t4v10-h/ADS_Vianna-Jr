/* Fazer um programa para contar o número de espaços em 
branco de uma string. */

class Program
{
    static void Main(string[] args)
    {
        string str;

        Console.WriteLine("Digite uma string:");
        str = Console.ReadLine();

        contarEspaco(str);
    }
      
    static void contarEspaco(string texto)
    {
        char espaco = ' ';
        int j = 0;
        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] == espaco)
            {
                j++;
            }
        }
        Console.Write("{0} espaços em branco.", j);
    }
} 
