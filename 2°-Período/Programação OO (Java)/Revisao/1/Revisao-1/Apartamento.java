
public class Apartamento extends Imovel
{
    private int numeroQuartos;
    
    public Apartamento(){
        super(0,0,"");
    }
    public Apartamento (int numero, int metros, 
    String proprietario,int numeroQuartos){
        super(0,0,"");
        this.numeroQuartos = numeroQuartos;
    }
    
    @Override
    public double valorVenal(){
        return super.valorVenal() + (numeroQuartos * 500);
    }
    
    public int getNumeroQuartos(){
        return this.numeroQuartos;
    }
    public void setNumeroQuartos(int numeroQuartos){
        this.numeroQuartos = numeroQuartos;
    }
}