/* Faça uma função que leia caracteres informados pelo usuário enquanto
o caractere não for uma vogal. Assim que for lida uma vogal, a função deve retornála. Note que esta função não recebe parâmetros. No método Main, use a sua função
para ler uma vogal. */

class Program
{
    static char lerVogal()
    {
        char vogal;
        Console.Write("Informe um vogal: ");
        vogal = Convert.ToChar(Console.ReadLine());

      while (vogal != 'a' && vogal != 'A' &&
             vogal != 'e' && vogal != 'E' &&
             vogal != 'i' && vogal != 'I' &&
             vogal != 'o' && vogal != 'O' &&
             vogal != 'u' && vogal != 'U')
      {
        Console.WriteLine("Caractere Invalido.");
        Console.Write("Informe uma vogal: ");
        vogal = Convert.ToChar(Console.ReadLine());
      }
      return vogal;
    }             
    
    static void Main(string [] args)
    {
        char recebe;
        recebe = lerVogal();
        Console.WriteLine("");
        Console.Write("Vogal informada: {0}", recebe);
    }
}