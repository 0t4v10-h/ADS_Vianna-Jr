/* Faça uma função que receba por parâmetro o raio 
de uma esfera e calcule o seu volume:
v = (4 * PI * R3
) /3. */

class Program
{

    static double CalcularVolume(double raio)
    {

        double pi = 3.14, volume;
        volume = (4 * pi * Math.Pow(raio, 3)) / 3;
        return volume;
    }
    static void Main(string[] args)
    {

        double r;
        Console.Write("Informe o raio de sua esfera: ");
        r = Convert.ToDouble(Console.ReadLine());
        double esfera = CalcularVolume(r);
        Console.Write("O volume da sua esfera e: {0:N}", esfera);
    }
}
