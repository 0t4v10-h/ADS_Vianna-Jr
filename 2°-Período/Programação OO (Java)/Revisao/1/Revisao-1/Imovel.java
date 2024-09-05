

public class Imovel
{
    private int numero;
    protected int metrosQuadrados;
    private String proprietario;
    private Condominio condominio;
    
    public Imovel(int numero, int metros, String proprietario){
        this.numero = numero;
        this.metrosQuadrados = metros;
        this.proprietario = proprietario;
    }
    
    public double valorVenal(){
        return metrosQuadrados * 1000;
    }
    
    public double valorVenda(){
        return valorVenal() * 0.85;
    }
    
    public int getNumero(){
        return this.numero;
    }
    public void setNumero(int numero){
        this.numero = numero;
    }
    
    public int getMetrosQuadrados(){
        return this.metrosQuadrados;
    }
    public void setMetrosQuadrados(int metrosQuadrados){
        this.metrosQuadrados = metrosQuadrados;
    }
    
    public String getProprietario(){
        return this.proprietario;
    }
    public void setProprietario(String proprietario){
        this.proprietario = proprietario;
    }
    
    public Condominio getCondominio(){
        return this.condominio;
    }
    public void setCondominio(Condominio condominio){
        this.condominio = condominio;
    }
}
