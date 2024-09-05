/* Fazer um procedimento para receber uma string do
usuário e imprimir uma estatística dos caracteres
digitados. Isto é, imprimir o número de vogais, consoantes
e outros caracteres. */

using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string str;
        char car;

        Console.Write("Informe uma string: ");
        str = Console.ReadLine();

        Console.Write("1 - VOGAIS \n2 - CONSOANTES \n3 - OUTROS CARACTERES \nInforme o caractere que você quer saber: ");
        car = Convert.ToChar(Console.ReadLine());

        string strConv = converterMinuscula(str);
        contarCaractere(car, strConv);
    }

    static string converterMinuscula(string str)
    {
        StringBuilder strConv = new StringBuilder(); 

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'A' && str[i] <= 'Z')
            {
                strConv.Append(Convert.ToChar(str[i] + 32));
            }
            else 
            {
                strConv.Append(Convert.ToChar(str[i]));
            }
        }
        return strConv.ToString();
    }

    static void contarCaractere(char car, string str)
    {
        int i;
        int contVogais = 0, contConsoantes = 0, contOutros = 0;

        for (i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'a' && str[i] <= 'z')
            {
                if (str[i]=='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i]=='u')
                {
                    contVogais++;
                }

                else
                {
                    contConsoantes++;
                }
            }

            else 
            {
                contOutros++;
            }
        }
        if (car == '1')
        {
            Console.Write("Numero de vogais: {0}", contVogais);
        }
        else if (car == '2')
        {
            Console.Write("Numero de consoantes: {0}", contConsoantes);
        }
        else
        {
            Console.Write("Numero de outros caracteres: {0}", contOutros);
        }
    }
}
    