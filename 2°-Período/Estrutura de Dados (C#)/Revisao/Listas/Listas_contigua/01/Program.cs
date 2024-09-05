using System;

class Program
{

    static void Main(string[] args)
    {
        var lista = new ListaContigua();

        lista.AdicionarInicio(6);
        lista.AdicionarFinal(4);
        lista.AdicionarFinal(2);
        lista.AdicionarInicio(8);

        Imprimir(lista);

        lista.RemoverFinal();
        lista.RemoverInicio();

        Imprimir(lista);
    }

    static void Imprimir(ListaContigua lista)
    {
        for(int i = 0; i < lista.Tamanho; i++)
        {
            Console.Write("{0} ", lista.Get(i));
        }
        Console.WriteLine();
    }
}

