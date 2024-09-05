/* Crie um procedimento que receba uma frase e a exiba na 
tela de forma soletrada, ou seja, cada letra deve ser 
exibida na tela separada por hífen. */

class Program
{
    static void soletrar(string palavra)
    {
        if (palavra.Length > 0)
        {
            Console.Write("{0}", palavra[0]);
        }
        for (int i = 1; i < palavra.Length; i++)
        {
            if ()
        }
    }
}



/*//(https://dontpad.com/camillo/fp)

//Run -> Add Configuration -> .Net ?  .Net Core:
//            No launch.json: vá em "configurations" -> "console"
//                 altere de "internalConsole" para "integratedTerminal"

static bool EhLetraOuDigito(char caractere)
{
    if (caractere >= 'A' && caractere <= 'Z')
        return true;
    
    if (caractere >= 'a' && caractere <= 'z')
        return true;

    if (caractere >= '0' && caractere <= '9')
        return true;

    return false;
}

static void Soletrar(string palavra)
{
    if (palavra.Length > 0)
    {
        Console.Write("{0}", palavra[0]);
    }

    for (int i = 1; i < palavra.Length; i++)
    {
        if (EhLetraOuDigito(palavra[i]) && EhLetraOuDigito(palavra[i - 1]))
        {
            Console.Write("-{0}", palavra[i]);
        }
        else
        {
            Console.Write("{0}", palavra[i]);
        }
    }
}

Soletrar("Teste isso aqui tambem 123.");
*/