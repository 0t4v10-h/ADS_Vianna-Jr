/* Faça um programa para ler um caractere e 
imprimir as seguintes mensagens, segundo o 
caso:
• “Sinal de menor”
• “Sinal de maior”
• “Sinal de igual”
• “Outro caractere” */

class Program
{
    static void Main(string [] args)
    {
        char sinal;
        Console.Write("Digite o caractere: ");
        sinal = Convert.ToChar(Console.ReadLine());
        
        switch (sinal)
        {
            case '<':
                Console.Write("Sinal de menor");
                break;
            case '>':
                Console.Write("Sinal de maior");
                break;
            case '=':
                Console.Write("Sinal de igual");
                break;
            default:
                Console.Write("Outro caractere");
                break;
        }
    }
}
