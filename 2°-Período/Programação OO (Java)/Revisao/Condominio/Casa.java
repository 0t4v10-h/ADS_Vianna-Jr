

public class Casa extends Imovel implements CondominioFechado
{
    private int metragemTerreno;
    
    public double valorVenal(){
        return (metrosQuadrados * 1500);
    }
    
    public double valorTerreno(){
        return metragemTerreno * 350;
    }
    
    public Casa(){
        super(0, 0, "");
    }
    
    public double valorVenda(){
        return super.valorVenda() + valorTerreno();
    }
}
