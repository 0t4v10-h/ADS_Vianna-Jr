/* Crie uma classe chamada ponto contendo apenas as
coordenadas x e y (inteiros) do ponto. Declare 2 pontos, leia
as coordenadas x e y de cada um e calcule a distância entre
eles. Apresente no final a distância entre os dois pontos. */

class Program
{
    static void Main(string[] args)
    {
        Ponto ponto1 = new Ponto();

        Console.Write("Valor X do ponto 1: ");
        ponto1.X = Convert.ToInt32(Console.ReadLine());

        Console.Write("Valor Y do ponto 1: ");
        ponto1.Y = Convert.ToInt32(Console.ReadLine());

        Ponto ponto2 = new Ponto();

        Console.Write("Valor X do ponto 2: ");
        ponto2.X = Convert.ToInt32(Console.ReadLine());

        Console.Write("Valor Y do ponto 2: ");
        ponto2.Y = Convert.ToInt32(Console.ReadLine());

        calcularDistancia(ponto1, ponto2);
    }

    static void calcularDistancia(Ponto pt1, Ponto pt2)
    {
        double distancia;
        distancia = Math.Sqrt(Math.Pow(pt2.X - pt1.X, 2) + Math.Pow(pt2.Y - pt1.Y, 2)); 

        Console.Write("A distancia entre os dois pontos: {0:n2}", distancia);
    }
}