/*  Dada uma tabela com as notas de uma turma de 20 
alunos, faça funções que retornem:
a) A média da turma.
b) a quantidade de alunos aprovados (>=60)
c) a quantidade de alunos reprovados.(< 60) */

class Program
{
    const int alunos = 20;
    static void Main(string[] args)
    {
        double[] notas = new double [alunos];
        double med, aprov, reprov;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write("Nota do aluno {0}: ", i + 1);
            notas[i] = Convert.ToDouble(Console.ReadLine());
        }
        med = retornaMedia(notas);
        aprov = retornaAprovados(notas);
        reprov = retornaReprovados(notas);

        Console.Write("\nMédia da turma: {0} \nAlunos aprovados: {1} \nAlunos reprovados: {2} ", med, aprov, reprov);
    }

    static double retornaMedia(double[] not)
    {
        double media = 0.0;

        for (int i = 0; i < not.Length; i++)
        {
            media += not[i];
        }
        return media / (double)alunos;
    }

    static double retornaAprovados(double[] not1)
    {
        double aprovados = 0.0;
        for (int i = 0; i < not1.Length; i++)
        {
            if (not1[i] >= 60)
            {
                aprovados++;
            }
        }
        return aprovados;
    }

    static double retornaReprovados(double[] not2)
    {
        double reprovados = 0.0;
        for (int i = 0; i < not2.Length; i++)
        {
            if (not2[i] < 60)
            {
                reprovados++;
            }
        }
        return reprovados;
    }
}