class Program
{
    public static void Main(string[] args)
    {
        Arvore arvore = new Arvore();

        arvore.raiz = new No('A');
        arvore.raiz.Esquerda = new No('B');
        arvore.raiz.Direita = new No('C');
        arvore.raiz.Direita.Esquerda = new No('D');
        arvore.raiz.Direita.Direita = new No('E');
        arvore.raiz.Direita.Esquerda.Esquerda = new No('G');
        arvore.raiz.Direita.Esquerda.Direita = new No('H');
        arvore.raiz.Direita.Direita.Direita = new No('I');

        Console.Write("Pré-Ordem: ");
        PreOrdem(arvore.raiz);

        Console.Write("\nIn-Ordem: ");
        InOrdem(arvore.raiz);

        Console.Write("\nPós-Ordem: ");
        PosOrdem(arvore.raiz);
    }

    public static void PreOrdem(No no)
    {
        if(no != null)
        {
            Console.Write(no.Valor + " ");
            PreOrdem(no.Esquerda);
            PreOrdem(no.Direita);
        }
    }

    public static void InOrdem(No no)
    {
        if(no != null)
        {
            InOrdem(no.Esquerda);
            Console.Write(no.Valor + " ");
            InOrdem(no.Direita);
        }
    }

    public static void PosOrdem(No no)
    {
        if(no != null)
        {
            PosOrdem(no.Esquerda);
            PosOrdem(no.Direita);
            Console.Write(no.Valor + " ");
        }
    }
}
