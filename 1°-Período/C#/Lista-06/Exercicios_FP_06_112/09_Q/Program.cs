/* Com relação ao exercício anterior, calcule e mostre o
percentual dos apostadores que fizeram de 10 a 13 pontos e
o percentual dos apostadores que fizeram menos do que 10
pontos. */
class Program
{
    const int TAM = 13;
    static void Main(string [] args)
    {
        int [] G = new int [TAM] {1, 0, 2, 1, 0, 2, 1, 0, 2, 1, 0, 2, 1};
        int resultado, mais = 0, menos = 0;

        for (int i = 0; i < 5; i++)
        {
            resultado = imprimirAcertos(G);
            if (resultado >= 10)
            {
                mais++;
            }
            else if (resultado < 10)
            {
                menos++;
            }
        }
        double porcent = (mais * 100) / 5;
        double porcentagem = (menos * 100) / 5;
        Console.WriteLine("{0}% dos apostadores teve MAIS de 10 acertos", porcent);
        Console.WriteLine("{0}% dos apostadores teve MENOS de 10 acertos", porcentagem);
        }
      
    static int imprimirAcertos(int [] G)
    {
        Console.WriteLine("Digite 13 numeros de apostas (Numeros validos 0, 1 e 2).");

        int [] R = new int [TAM];
        int cont = 0;

        for (int i = 0; i < R.Length; i++)
        {
            Console.Write("Numero {0} de {1}: ", i + 1, R.Length);
            R[i] = Convert.ToInt32(Console.ReadLine());

            if (R[i] == G[i])
            {
                cont++;
            }
        }
        return cont;
    }
}

