

public class Despesa
{
    private int mesAno;
    private String descricao;
    private double valor;
    private boolean taxaExtra;
    
    public Despesa(){
    
    }
    
    public String getDescricao(){
        return this.descricao;
    }
    public void setDescricao(String descricao){
        this.descricao = descricao;
    }
    
    public int getMesAno(){
        return this.mesAno;
    }
    public void setMesAno(int mesAno){
        this.mesAno = mesAno;
    }
    
    public double getValor(){
        return this.valor;
    }
    public void setValor(double valor){
        this.valor = valor;
    }
}
