/* Crie uma matriz tridimensional onde as linhas indicam as 
notas de matemática, história e geografia em três provas de 
10 alunos e crie uma função que verifique quantos alunos 
passaram, ou seja, os que tenham média aritmética > 60 nas 
3 disciplinas. */

class Program
{
    const int TAM = 3;
    static void Main(string[] args)
    {
        double [,,] mat = new double [10,TAM,TAM];
        int i, j, k;

        for (i = 0; i < mat.GetLength(0); i++)
        {            
            Console.WriteLine("\nVamos ver a nota do aluno {0}.", i+1);

            for (j = 0; j < mat.GetLength(1); j++)
            {
                if (j == 0)
                {
                    Console.WriteLine("MATEMÁTICA: ");
                }
                else if (j == 1)
                {
                    Console.WriteLine("HISTÓRIA: ");
                }
                else 
                {
                    Console.WriteLine("GEOGRAFIA: ");
                }

                for (k = 0; k < mat.GetLength(2); k++)
                {
                   Console.Write("{0}° prova: ", k+1);
                   mat[i,j,k] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        calcularMedia(mat);
    }
    static void calcularMedia(double[,,] matriz)
    {
        int i, j, k;
        int qtPorDisciplina = 0;
        int qtdePassaram = 0;
        double armazena = 0.0;
        

        for (i = 0; i < matriz.GetLength(0); i++)
        {
            double media = 0.0;
            qtPorDisciplina = 0;
            for (j = 0; j < matriz.GetLength(1); j++)
            {                       
                for (k = 0; k < matriz.GetLength(2); k++)
                {
                    armazena += matriz[i,j,k];  
                }

                media = 0;
                media = armazena / matriz.GetLength(2); 
                armazena = 0;
                if (media > 60)
                {
                    qtPorDisciplina++;
                }       
                
                if (qtPorDisciplina == 3)
                {
                    qtdePassaram++;
                }     
            } 
        }
        
        Console.Write("Número de alunos que passaram: {0}", qtdePassaram);
    }
   
}