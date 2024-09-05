class Program
{
    static void Main(string[] args)
    {
        var pilha = new Pilha<int>();

        pilha.Empilhar(3);
        pilha.Empilhar(2);
        pilha.Empilhar(1);

        while(pilha.Topo != null)
        {
            Console.WriteLine(pilha.Topo.Valor);
            pilha.Desempilhar();
        }
    }
}