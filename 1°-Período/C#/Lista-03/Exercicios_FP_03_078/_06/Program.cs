/* -Considerando a fórmula para o cálculo da distância 
entre dois pontos (x1, y1) e (x2,y2):

a) Escreva uma função que receba como 
parâmetros as coordenadas de dois pontos e 
retorne a distância entre eles.

b) Escreva um programa C# (função principal) que 
capture do teclado as coordenadas dos 3 
vértices de um triângulo, calcule e imprima o 
perímetro deste triângulo. Este programa deve 
utilizar a função do item anterior. */

class Proram 
{
     static double DistanciaPontos(double x1, double y1, double x2, double y2) 
        {
        double dis;
        dis = Math.Sqrt(Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2));
        return dis;
        }

    static void Main(string [] args)
    {
        Console.WriteLine("Calculadora de distancia e perimetro de triangulo");
              
        double x1 = 5, y1 = 5, x2 = 4, y2 = 4, y3 = 3, x3 = 3;
             
        double lado1 = DistanciaPontos (x1, y1, x2, y2);
        double lado2 = DistanciaPontos (x2, y2, x2, y2);
        double lado3 = DistanciaPontos (x3, y3, x1, y1);

        double perimetro = lado1 + lado2 + lado3;

        Console.Write("O perimetro do seu triangulo e: {0}", perimetro);
        }
}