class ListaContigua
{
    public int Tamanho {get => fim - inicio + 1;}

    private int fim;
    private int inicio;
    private double[] valores;


    public ListaContigua() : this(100) {}

    public ListaContigua(int tamanho)
    {
        inicio = tamanho / 2;
        fim = inicio - 1;
        valores = new double[tamanho];
    }

    public void AdicionarInicio(double valor)
    {
        if(inicio == 0)
        {
            throw new Exception("Nao é possivel adicionar no incio!");
        }

        valores[--inicio] = valor;
    }

    public void AdicionarFinal(double valor)
    {
        if(fim == valores.Length - 1)
        {
            throw new Exception("Nao é possivel adicionar no inicio!");
        }

        valores[++fim] = valor;
    }

    public void RemoverInicio()
    {
        if(Tamanho == 0)
        {
            throw new Exception("Nao existe elemento a ser removido");
        }

        inicio++;
    }

    public void RemoverFinal()
    {
        if(Tamanho == 0)
        {
            throw new Exception("Nao existe elemento a ser removido");
        }

        fim--;
    }

    public double Get(int indice)
    {
        if(indice < 0 || indice >= Tamanho)
        {
            throw new Exception("Indice invalido!");
        }

        return valores[inicio + indice];
    }
}