/* Escreva um algoritmo que leia 10 valores (usando a mesma variável) e 
encontre o maior e o menor deles. Mostre o resultado. */

class Program
{
    static void lerValores(int primeiro)
    {
        int menor = primeiro;
        int maior = primeiro;
        int cont;

        for (cont = 1; cont < 10; cont++)
        {
            Console.Write("Informe um valor: ");
            primeiro = Convert.ToInt32(Console.ReadLine());

            if (menor > primeiro)
            {
                menor = primeiro;
            }
            else if (maior < primeiro)
            {
                maior = primeiro;
            }

        }

        Console.Write("Menor : {0} \nMaior : {1}", menor, maior);
    }
    static void Main(string [] args)
    {
        int numero;
        Console.Write("Informe um valor: ");
        numero = Convert.ToInt32(Console.ReadLine());

        lerValores (numero);
    }
}