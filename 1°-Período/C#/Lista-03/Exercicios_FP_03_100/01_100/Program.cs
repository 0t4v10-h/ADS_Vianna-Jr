
/* Faça um procedimento que receba por parâmetro 
o tempo de duração de um experimento expresso 
em segundos e imprima na tela esse mesmo tempo 
em horas, minutos e segundos. */

internal class Program
{
    static void ImprimeSegundos (int tempo)
    {
        int h, m, s, resto;

        h = tempo / 3600;
        resto = tempo % 3600;
        m = resto / 60;
        s = resto % 60;
        
        Console.Write("{0} de segundos corresponde a: {1} horas, {2} minutos e {3} segundos.", tempo, h,m,s);
    }
    static void Main (string [] args)
    {

        Console.Write("Informe o total de segundos: ");

        int seg;
        seg = Convert.ToInt32(Console.ReadLine());
        ImprimeSegundos (seg);
    }
}