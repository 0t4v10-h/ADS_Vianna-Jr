class Program
{
    static void Main(string[] args)
    {
        var fila = new Fila<int>();

        fila.Adicionar(3);
        fila.Adicionar(2);
        fila.Adicionar(1);

        while (fila.Inicio != null)
        {
            Console.WriteLine(fila.Inicio.Valor);
            fila.Remover();
        }
    }
}