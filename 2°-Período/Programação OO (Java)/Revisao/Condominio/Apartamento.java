

public class Apartamento extends Imovel
{
    private int numeroQuartos;
    
    public double valorVenal(){
        return (metrosQuadrados * 1000) + (numeroQuartos + 500);
    }
    
    public Apartamento(){
        super(0, 0, "");
    }
}
