/* Escreva um programa para ler uma string (com mais de 
uma palavra) e imprimi-la de forma que a primeira letra de 
cada palavra fique em maiúscula. Para isso, basta subtrair 
32 do elemento que deseja alterar para maiúsculo. */

class Program
{
    static void Main(string[] args)
    {
        string str;
        Console.Write("Informe um texto (com mais de uma palavra): ");
        str = Console.ReadLine();

        imprimeMaiusculo(str);
    }

    static void converteMaiuscula(char maiuscula)
    {
        if (maiuscula >= 'a' || maiuscula <= 'z')
        return Convert.ToChar(maiuscula - 'a' + 'A');
    }

    static void imprimeMaiusculo(string texto)
    {
        Console.Write(converteMaiuscula(texto[0]));

        for (int i = 1; i < texto.Length; i++)
        {
            if (texto[i - 1] == ' ')
            {
                Console.Write("{0}", converteMaiuscula(texto[i]));
            }
            else
            {
                Console.Write("{0}", texto[i]);
            }
        }
    }
}
