/* Chico tem 1,50 metros e cresce 2 centímetros por ano, enquanto Zé tem 1,40 
metros e cresce 3 centímetros por ano. Construa um algoritmo que calcule e 
imprima quantos anos serão necessários para que Zé seja maior que Chico. */ 

class Program
{
    static double calcularAltura(double altura1, double altura2, double dif1, double dif2)
    {
        int cont;

        for (cont = 1; altura1 > altura2; cont++)
        {
            altura1 += dif1;
            altura2 += dif2;
        }
        Console.Write("Serão necessários {0} anos para Zé ser maior que Chico.", cont);
        return cont;
    }
    static void Main(string [] args)
    {
        double alt1, alt2, diferenca1, diferenca2;

        Console.Write("Informe a primeira altura: ");
        alt1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe quantos centimetros ele cresce ao ano: ");
        diferenca1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a segunda altura: ");
        alt2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe quantos centimetros ele cresce ao ano:: ");
        diferenca2 = Convert.ToDouble(Console.ReadLine());

        calcularAltura (alt1, alt2, diferenca1, diferenca2);
    }
}