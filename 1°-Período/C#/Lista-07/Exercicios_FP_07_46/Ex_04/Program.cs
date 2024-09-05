/* Fazer um programa para ler uma string e transferir as
consoantes para uma string e as vogais para outra. Depois
mostre cada uma das strings. */

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string str;

        Console.Write("Informe uma string: ");
        str = Console.ReadLine();

        separarVogaisEConsoantes(str);
        
    }

    static void separarVogaisEConsoantes(string str)
    {
        StringBuilder strVogais = new StringBuilder();
        StringBuilder strConso = new StringBuilder();
        int i;

        for (i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
            {
                if (str[i]=='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i]=='u' || str[i]=='A' || str[i]=='E' || str[i]=='I' || str[i]=='O' || str[i]=='U')
                {
                    strVogais.Append(str[i]);
                }
                else
                {
                    strConso.Append(str[i]);
                }
            }
        }
        Console.WriteLine("Vogais da string: {0}", strVogais.ToString());
        Console.Write("Consoantes da string: {0}", strConso.ToString());
    }
}