class Loja
{
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }
    public double Preco
    {
        get { return preco; }
        set { preco = value; }
    }
    private string nome;
    private string telefone;
    private double preco;
}