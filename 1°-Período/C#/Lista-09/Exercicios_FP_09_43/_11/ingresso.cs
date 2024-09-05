class Ingresso
{
    public string Local
    {
        get { return local; }
        set {local = value; }
    }   
    public double Preco
    {
        get { return preco; }
        set {preco = value; }
    }
    public string Atracao
    {
        get { return atracao; }
        set { atracao = value; }
    }
    private string local;
    private double preco;
    private string atracao;
}