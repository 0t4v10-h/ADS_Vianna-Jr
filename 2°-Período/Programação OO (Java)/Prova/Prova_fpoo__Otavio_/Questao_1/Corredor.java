import java.util.ArrayList;

public class Corredor
{
    private String nome;
    private ArrayList<Corrida> corrida;
    
    public Corredor(String nome){
        this.nome = nome;
        corrida = new ArrayList<>();
    }
    
    public double velMedia(){
        double vel = 0.0;
        for(Corrida c : corrida){
            if(vel < c.velocidadeMedia()){
                vel = c.velocidadeMedia();
            }
        }
        return vel;
    }
    
    public int maisRapida(){
        int rapida = 0;
        for(Corrida c : corrida){
            if(rapida < velMedia()){
                rapida = c.getNumero();
            }
        }
        return rapida;
    }
    
    public String getNome(){
        return this.nome;
    }
    public void setNome(String nome){
        this.nome = nome;
    }
    
    public ArrayList<Corrida> getCorrida(){
        return this.corrida;
    }
    public void addCorrida(Corrida crd){
        this.corrida.add(crd);
    }
}
