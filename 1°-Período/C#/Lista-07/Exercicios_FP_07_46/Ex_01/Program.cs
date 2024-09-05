/* Faça um programa que leia duas strings e crie uma
terceira string que será a concatenação das duas outras
strings lidas. */

using System.Text;

class Program
{
    static void Main(string [] args)
    {
        
        string str1 = " maior";
        string str3 = " Minas";

        StringBuilder sb = new StringBuilder ();
        sb.Append("Cruzeiro");
        sb.Append(str1);
        sb.Append(' ');
        sb.Append('d');
        sb.Append('e');
        sb.Append(str3);
        Console.Write("{0}", sb.ToString());
    }
}
