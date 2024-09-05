/* 6) Considerando o critério de aprovação de uma disciplina 
que determina que um aluno está aprovado se a média 
ponderada de suas três provas for maior ou igual a 5.0, onde 
a média é dada pela fórmula:

Média = (P1 + P2 + 2.0 * P3) / 4.0

(a) Escreva uma função que receba como parâmetros as notas das 
duas primeiras provas de um aluno (P1 e P2) e retorne a nota 
mínima que o aluno precisa tirar na terceira prova para que seja 
aprovado.

(b) Escreva um programa em C# completo que leia do teclado as duas 
primeiras notas de um aluno, calcule e imprima a nota mínima que 
o aluno precisa tirar na P3 para que seja aprovado. Este programa 
deve fazer uso da função do item anterior. */

class Program
{
    static double CalculaMedia(double p1, double p2)
    {
        double media = 5, p3;
        p3 = (media * 4.0 - (p1 + p2)) / 2.0;
        return p3;
    }
    static void Main(string [] args)
    {
        double prova1, prova2;
        Console.Write("Informe a nota da primeira prova: ");
        prova1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a nota da segunda prova: ");
        prova2 = Convert.ToDouble(Console.ReadLine());
        double media;
        media = CalculaMedia(prova1, prova2);
        Console.Write("Voce precisa tirar {0:} pontos para ser aprovado.", media);
    }
}
