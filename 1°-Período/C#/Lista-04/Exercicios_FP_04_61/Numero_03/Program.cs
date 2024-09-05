/* Tendo como dados de entrada a altura e o 
sexo de uma pessoa, construa um 
programa que calcule seu peso ideal, 
utilizando as seguintes fórmulas:
para homens: (72.7*h)-58
para mulheres: (62.1*h)-44.7 */

class Program
{
    static void Main(string [] args)
    {
        double altura; char sexo;
        Console.Write("Informe o seu sexo: ");
        sexo = Convert.ToChar(Console.ReadLine());
        Console.Write("Informe sua altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        if (sexo == 'M' || sexo == 'm')
        {
            double peso = (72.7 * altura) - 58;
            Console.Write("Seu peso ideal é: {0:N}", peso);
        }
        else if (sexo == 'F' || sexo == 'f')
        {
            double peso = (62.1 * altura) - 44.7;
            Console.Write("O seu peso ideal é: {0:N}", peso);
        }
        else
        {
            Console.Write("Sexo inválido. Digite 'M' para masulino ou 'F' para feminino.");
            return;
        }
    }   
}