

public class Cobertura extends Imovel
{
    private boolean duplex;
    private boolean triplex;
    
    public double valorVenal(){
        int multiplicadorDuplex = (duplex) ? 2 : 1;
        int multiplicadorTriplex = (triplex) ? 3 : 1;
        return (metrosQuadrados * 1000) * multiplicadorDuplex * multiplicadorTriplex;
    }
    
    public Cobertura(){
        super(0, 0, "");
    }
}
