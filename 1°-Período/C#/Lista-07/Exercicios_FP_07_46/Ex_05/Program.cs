/* Faça uma função que receba uma string do usuário (máx.
20 caracteres) e um caractere qualquer. A função deverá
criar uma nova string onde terão sido removidas todas as
ocorrências do caractere da string. A função deve retornar
o número de remoções. */

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string str;
        char caractere;
        int recebe;

        Console.Write("Informe uma string (no máx. 20 caractere): ");
        str = Console.ReadLine();

        Console.Write("Informe o caractere que deseja remover: ");
        caractere = Convert.ToChar(Console.ReadLine());

        recebe = removeCaractere(str, caractere);
        Console.Write("Numero de remoções: {0}", recebe);
    }
    static int removeCaractere(string str, char carac)
    {
        StringBuilder strConv = new StringBuilder();
        int i, cont = 0;

        for (i = 0; i < str.Length; i++)
        {
            if (str[i] == carac)
            {
                cont++;
            }
            else 
            {
                strConv.Append(str[i]);
            }
        }
        Console.WriteLine("String com a remoção do caractere {0}: {1}", carac, strConv.ToString());
        return cont;
    }
}