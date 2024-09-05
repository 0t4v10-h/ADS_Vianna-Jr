

public class Candidata extends Pessoa
{
    private double altura;
    private double peso;
    private double quadril;
    private double busto;
    private boolean ehDeficiente;
    private Estado estado;
    
    public Candidata(double altura, double peso, double quadril, double busto, boolean ehDeficiente, Estado estado){
        super("");
        this.altura = altura;
        this.peso = peso;
        this.quadril = quadril;
        this.busto = busto;
        this.ehDeficiente = ehDeficiente;
        this.estado = estado;
    }
    
    public double getAltura(){
        return this.altura;
    }
    public void setAltura(double altura){
        this.altura = altura;
    }
    
    public double getPeso(){
        return this.peso;
    }
    public void setPeso(double peso){
        this.peso = peso;
    }
    
    public double getQuadril(){
        return this.quadril;
    }
    public void setQuadril(double quadril){
        this.quadril = quadril;
    }
    
    public double getBusto(){
        return this.busto;
    }
    public void setBusto(double busto){
        this.busto = busto;
    }
    
    public boolean getEhDeficiente(){
        return this.ehDeficiente;
    }
    public void setHhDeficiente(boolean ehDeficiente){
        this.ehDeficiente = ehDeficiente;
    }
    
    public Estado getEstado(){
        return this.estado;
    }
    public void setEstado(Estado estado){
        this.estado = estado;
    }
}
