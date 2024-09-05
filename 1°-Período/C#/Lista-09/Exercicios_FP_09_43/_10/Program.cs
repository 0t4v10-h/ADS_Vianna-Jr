/* Faça um programa que leia os dados de 10 ingressos. As informações
que deverão ser lidas de cada ingresso são: preço, local e atração. Ao
final, informe os eventos de ingresso mais barato e mais caros. */

class Program
{
    static void Main(string[] args)
    {
        Ingresso[] vet = new Ingresso [5];
        Ingresso maisBarato, maisCaro;
        int i;

        for (i = 0; i < vet.Length; i++)
        {
            Console.WriteLine("Ingresso {0} de {1}: ", i+1, vet.Length);       
            vet[i] = new Ingresso(); 
            lerIngressos(vet[i]);
        }

        maisBarato = vet[0];
        maisCaro = vet[0];
        for (i = 0; i < vet.Length; i++)
        {
            if (vet[i].Preco < maisBarato.Preco)
            {
                maisBarato = vet[i];
            }

            else if (vet[i].Preco > maisCaro.Preco)
            {
                maisCaro = vet[i];
            }
        }
        Console.WriteLine("Ingresso mais barato: {0} - {1} - {2} ", maisBarato.Local, maisBarato.Atracao, maisBarato.Preco);
        Console.WriteLine("Ingresso mais caro: {0} - {1} - {2} ", maisCaro.Local, maisCaro.Atracao, maisCaro.Preco);
    }

    static void lerIngressos(Ingresso obj)
    {        
        Console.Write("Preço: ");
        obj.Preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Local: ");
        obj.Local = Console.ReadLine();

        Console.Write("Atração: ");
        obj.Atracao = Console.ReadLine();       
    }
}