/* Utilizando a classe ponto definida no exercício anterior, faça
um programa que leia 4 pontos. Em seguida imprima qual o
ponto mais próximo do primeiro ponto lido. */

class Program
{
    static void Main(string[] args)
    {
        Pontos[] ponto = new Pontos[4];
        int i;

        for (i = 0; i < ponto.Length; i++)
        {
            Console.WriteLine("\nPONTO {0}:", i+1);
            ponto[i] = new Pontos();
            Console.Write("Valor X do ponto {0}: ", i+1);
            ponto[i].X = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor Y do ponto {0}: ", i+1);
            ponto[i].Y = Convert.ToInt32(Console.ReadLine());
        }
        maisProximo(ponto);
    }
    static void maisProximo(Pontos[] obj)
    {
        int i, cont = 1;
        double distancia = Math.Sqrt(Math.Pow(obj[1].X - obj[0].X, 2) + Math.Pow(obj[1].Y - obj[0].Y, 2));
        double aux;

        for (i = 1; i < obj.Length; i++)
        {
            aux = Math.Sqrt(Math.Pow(obj[i].X - obj[0].X, 2) + Math.Pow(obj[i].Y - obj[0].Y, 2));
            if (aux < distancia)
            {
                distancia = aux;
                cont = i+1;
            }
        }
        Console.Write("O ponto mais proximo do ponto 1: {0} \nCom a distancia: {1}", cont, distancia);
    }
}