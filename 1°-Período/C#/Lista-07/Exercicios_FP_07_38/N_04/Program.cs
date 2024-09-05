/* Fazer um programa para contar o número de vogais em 
uma string. */
class Program
{
    static void Main(string[] args)
    {
        string str;

        Console.Write("Informe um texto: ");
        str = Console.ReadLine();

        contarVogais(str); 
    }

    static void contarVogais(string texto)
    {
        char [] vogais = new char [10]{'a','A','e','E','i','I','o','O','u','U'};
        int cont = 0;

        for (int i = 0; i < texto.Length; i++)
        {
            for (int j = 0; j < vogais.Length; j++)
            if (texto[i] == vogais[j])
            {
                cont++;
            }            
        }

        Console.Write("\n{0} tem {1} vogais", texto, cont);
    }
}

