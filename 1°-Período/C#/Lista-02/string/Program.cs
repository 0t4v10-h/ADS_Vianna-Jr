/* using System.Text;

static string ConverterParaMaiusculas(string str)
{
    StringBuilder resultado = new StringBuilder();

    for (int i = 0; i < str.Length; i++)
        if (str[i] >= 'a' && str[i] <= 'z')
            resultado.Append(Convert.ToChar(str[i] - 'a' + 'A'));
        else
            resultado.Append(str[i]);

    return resultado.ToString();
}

string texto = "Teste isso";
string maiusculas = ConverterParaMaiusculas(texto);
Console.WriteLine(maiusculas); */

using System.Text;

static string ConverterParaMinusculas(string str)
{
    StringBuilder resultado = new StringBuilder();

    for (int i = 0; i < str.Length; i++)
        if (str[i] >= 'A' && str[i] <= 'Z')
            resultado.Append(Convert.ToChar(str[i] - 'A' + 'a'));
        else
            resultado.Append(str[i]);

    return resultado.ToString();
}

string texto = "TESTE ISSO";
string minusculas = ConverterParaMinusculas(texto);
Console.WriteLine(minusculas);
