

public class Cobertura extends Imovel
{
    private boolean duplex;
    private boolean triplex;
    
    public Cobertura(){
        super(0,0,"");
    }
    public Cobertura (int numero, int metros, 
    String proprietario){
        super(0,0,"");
    }
    
    @Override
    public double valorVenal(){
        return super.valorVenal() * (duplex ? 2 : 1) * (triplex ? 3 : 1);
    }
    
    public boolean getDuplex(){
        return this.duplex;
    }
    public void setDuplex(boolean duplex){
        this.duplex = duplex;
    }
    
    public boolean getTriplex(){
        return this.triplex;
    }
    public void setTriplex(boolean triplex){
        this.triplex = triplex;
    }
}
