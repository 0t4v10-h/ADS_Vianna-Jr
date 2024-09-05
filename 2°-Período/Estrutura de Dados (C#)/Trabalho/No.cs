class No
{
    public char Valor
    {
        get{ return valor; }
        set{ valor = value; }
    }

    public No Esquerda
    {
        get{ return esquerda; }
        set{ esquerda = value; }
    }

    public No Direita
    {
        get{ return direita; }
        set{ direita = value; }
    }

    private char valor;
    private No esquerda = null;
    private No direita = null;

    public No(char item)
    {
        valor = item;
    }
}