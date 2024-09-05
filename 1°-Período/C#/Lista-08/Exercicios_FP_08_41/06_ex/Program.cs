/* Crie uma função que receba uma matriz de números reais 
e retorne a soma dos elementos desta matriz. */

class Program
{
    const int TAM = 3;

    static void Main(string[] args)
    {
        double [,] mat = new double [TAM,TAM];

        imprimeSoma(mat);
    }

    static void imprimeSoma(double[,] m)
    {
        int i, j;

        for (i = 0; i < m.GetLength(0); i++)
        {
            for (j = 0; j < m.GetLength(1); j++)
            {
                m[i,j] = i + j;
                Console.Write("{0,5}", m[i,j]);
            }
            Console.WriteLine();
        }
    }
}