

public class Casa extends Imovel
{
    private int metragemTerreno;
    
    public Casa(){
        super(0,0,"");
    }
    public Casa (int numero, int metros, 
    String proprietario){
        super(0,0,"");
    }
    
    @Override
    public double valorVenal(){
        return metrosQuadrados * 1500;
    }
    
    public int getMetragemTerreno(){
        return this.metragemTerreno;
    }
    public void setMetragemTerreno(int metragemTerreno){
        this.metragemTerreno = metragemTerreno;
    }
}
