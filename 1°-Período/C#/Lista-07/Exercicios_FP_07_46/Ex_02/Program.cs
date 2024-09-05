/* Fazer um procedimento para imprimir uma string recebida
como parâmetro sem os espaços em branco. */

using System.Text;

class Program
{
    static void Main(string [] args)
    {
        string str;

        Console.Write("Digite uma string: ");
        str = Console.ReadLine();

        retiraEspacos(str);
    }

    static void retiraEspacos(string recebe)
    {
        char espaco = ' ';
        StringBuilder resultado = new StringBuilder();
        for (int i = 0; i < recebe.Length; i++)
        {
            if (recebe[i] != espaco)
            {
                resultado.Append (recebe[i]);
            }
            /*/if (recebe[i] == espaco)
            {
                resultado.Append (Convert.ToChar(recebe[i] - espaco));
            }
            else
            {
                resultado.Append (recebe[i]);
            }*/
        }
        Console.Write(resultado.ToString());
    } 
}