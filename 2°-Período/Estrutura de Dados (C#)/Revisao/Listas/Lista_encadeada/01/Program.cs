class Program
{
    static void Main(string[] args)
    {
        var lista = new ListaEncadeada<int>();

        lista.AdicionarInicio(3);
        lista.AdicionarFinal(5);
        lista.AdicionarFinal(7);
        lista.AdicionarInicio(1);

        lista.RemoverInicio();
        lista.RemoverFinal();

        lista.ParaCada(x => Console.Write($"{x} "));
        Console.WriteLine();

        int soma = 0;
        lista.ParaCada(x => soma += x);
        Console.WriteLine($"Soma: {soma}");
    }
}