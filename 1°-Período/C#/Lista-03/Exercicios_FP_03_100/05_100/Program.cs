/* ) Considere as equações de movimento para calcular a 
posição (s) e velocidade (v) de uma partícula em um 
determinado instante t, dado sua aceleração a, posição inicial 
s0 e velocidade inicial v0, de acordo com as fórmulas:
s = s0 + v0*t + (a * t * t)/2
v = v0 + a*t 
Escreva um programa C# completo que capture os valores 
de s0, v0, a e t, fornecidos pelo usuário via teclado, e calcule 
e imprima os valores de s e v. */

class Program
{
    static void Main(string [] args)
    {
        double posicao, velocidade, acele, temp;
        Console.Write("Informe a posicao inicial: ");
        posicao = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a velocidade inicial: ");
        velocidade = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a aceleracao: ");
        acele = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe o tempo: ");
        temp = Convert.ToDouble(Console.ReadLine());
        ImprimeFormula(posicao, velocidade, acele, temp);

    }
    static void ImprimeFormula(double s0, double v0, double acelerar, double tempo)
    {
        double s;
        s = s0 + v0 * tempo + (acelerar * tempo * tempo) / 2;
        double v;
        v = v0 + acelerar * tempo;

        Console.Write("A sua posicao e a sua velocidade e: {0} e {1}.", s, v);
    }
}
