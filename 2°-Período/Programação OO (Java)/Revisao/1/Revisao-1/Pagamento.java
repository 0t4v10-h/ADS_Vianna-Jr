

public class Pagamento
{
    private int mesAno;
    private double valorPago;
    private Imovel imovel;
    private Condominio condominio;
    
    public Pagamento(){}
    public Pagamento(int mesAno, double valorPago, Imovel imovel, Condominio condominio){
        this.mesAno = mesAno;
        this.valorPago = valorPago;
        this.imovel = imovel;
        this.condominio = condominio;
    }
    
    public int getMesAno(){
        return this.mesAno;
    }
    public void setMesAno(int mesAno){
        this.mesAno = mesAno;
    }
    
    public double getValorPago(){
        return this.valorPago;
    }
    public void setValorPago(double valorPago){
        this.valorPago = valorPago;
    }
    
    public Imovel getImovel(){
        return this.imovel;
    }
    public void setImovel(Imovel imovel){
        this.imovel = imovel;
    }
    
    public Condominio getCondominio(){
        return this.condominio;
    }
    public void setCondominio(Condominio condominio){
        this.condominio = condominio;
    }
}
