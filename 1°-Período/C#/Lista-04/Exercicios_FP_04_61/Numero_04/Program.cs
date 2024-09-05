/* Faça um programa que leia 3 comprimentos 
(x, y e z) e responda se eles formam um 
triângulo, ou seja, se 
x < y + z   ;   y < x + z   ;   z < x + y. */

class Program
{
    static void Main(string [] args)
    {
        int x, y, z;
        Console.Write("Informe a medida do comprimento X: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe a medida do comprimento Y: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe a medida do comprimento Z: ");
        z = Convert.ToInt32(Console.ReadLine());

        if (x < y + z && y < x + z && z < x + y)
        {
            Console.Write("Eles formam um triângulo.");
        }
        else
        {
            Console.Write("Não formam um triângulo.");
        }
    }
}
