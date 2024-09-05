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

public class Program 
{
     static double DistanciaPontos(double n1, double num1, double n2, double num2) 
    {
            //Funcao para calcular a distancia entre dois pontos
        double dis;
        dis = Math.Sqrt(Math.Pow(n2 - n1, 2)) + (Math.Pow(num2 - num1, 2));
        return dis;
    }

    static void Main(string [] args)
    {
        Console.WriteLine("Calculadora de distancia e perimetro de triangulo");
              // Captura das codernadas dos vertices
        double x1, y1, x2, y2, y3, x3;

        Console.Write("Digite a coordenada x do vertice 1: ");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a coordenada y do vertice 1: ");
        y1 = Convert.ToDouble(Console.ReadLine());
    
        Console.Write("Digite a coorcenada x do vertice 2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a coordenada y do vertice 2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a coordenada x do vertice 3: ");
        x3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a coordenada y do vertice 3: ");
        y3 = Convert.ToDouble(Console.ReadLine());


            // Calculo do perimetro 
        double lado1 = DistanciaPontos (x1, y1, x2, y2);
        double lado2 = DistanciaPontos (x2, y2, x3, y3);
        double lado3 = DistanciaPontos (x3, y3, x1, y1);

        double perimetro = lado1 + lado2 + lado3;


            // Resultado
        Console.Write("O perimetro do seu triangulo e: {0}", perimetro);
    }
}
