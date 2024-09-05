/* Faça um procedimento que receba o montante reservado para a aposentadoria de uma
pessoa e a quantia que ela pretende retirar por mês. O montante reservado é corrigido a
cada mês com a taxa de 0,55%, aplicada logo após a retirada. O procedimento deve
imprimir o montante (após a retirada e a correção), mês a mês. O procedimento também
deve imprimir o número de meses em que a pessoa conseguirá fazer a sua retirada.
Restrição: não utilize comandos de repetição. */

public class Program
{
    public static int ImprimeMontante(double montante, double retirada)
    {
        return ImprimeMontante(montante, retirada, 0);
    }

    public static int ImprimeMontante(double montante, double retirada, int contador)
    {
        if(montante >= retirada)
        {
            contador++;
            montante = (montante - retirada) + (montante * 0.0055);
            Console.WriteLine("Valor após o {0}° mês: {1:n2}", contador, montante);
            return ImprimeMontante(montante, retirada, contador);
        }
        return contador;
    }

    public static void Main(string[] args)
    {
        double montante = 20000;
        double retirada = 4500;
        
        int meses = ImprimeMontante(montante, retirada); 

        Console.WriteLine("\nNumero de meses que foi possivel fazer a retirada: {0}", meses);
    }
}