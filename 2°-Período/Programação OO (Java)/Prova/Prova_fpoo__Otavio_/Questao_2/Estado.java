import java.util.ArrayList;

public class Estado
{
    private String sigla;
    private MisBrasil misEstado;
    private Candidata vencedora;
    private ArrayList<Candidata> candidata;
 
    public Estado(String sigla, MisBrasil misEstado, Candidata vencedora){
        this.sigla = sigla;
        this.misEstado = misEstado;
        this.vencedora = vencedora;
        this.candidata = new ArrayList<>();
    }
    
    public double valorInscricao(){
     
        for(Candidata c : candidata){
            return (c.getEhDeficiente()) ? 0.0 : 5000.0;
        }
        return 0.0;
    }
    
    public String getSigla(){
        return this.sigla;
    }
    public void setSigla(String sigla){
        this.sigla = sigla;
    }
    
    public MisBrasil getMisEstado(){
        return this.misEstado;
    }
    public void setMisEstado(MisBrasil misEstado){
        this.misEstado = misEstado;
    }
    
    public Candidata getVencedora(){
        return this.vencedora;
    }
    public void setVencedora(Candidata vencedora){
        this.vencedora = vencedora;
    }
    
    public ArrayList<Candidata> getCandidata(){
        return this.candidata;
    }
    public void addCandidata(Candidata cand){
        this.candidata.add(cand);
    }
}
