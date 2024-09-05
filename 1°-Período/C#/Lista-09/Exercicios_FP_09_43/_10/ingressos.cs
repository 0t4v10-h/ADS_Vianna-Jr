class Ingresso
{    
    public double Preco
    {
        get { return preco; }
        set { preco = value; }
    }
    
    public string Local
    {
        get { return local; }
        set { local = value; }
    }
    
    public string Atracao
    {
        get { return atracao; }
        set { atracao = value; }
    }

    private double preco;
    private string local;
    private string atracao;
}