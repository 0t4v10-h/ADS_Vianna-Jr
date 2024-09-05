import java.util.ArrayList;

public class MisBrasil
{
    private String descricao;
    private String dataEvento;
    private String local;
    private double premio;
    private Pessoa organizador;
    private ArrayList<Estado> estado;
    
    public MisBrasil(String descricao, String dataEvento, String local, double premio, Pessoa organizador){
        this.descricao = descricao;
        this.dataEvento = dataEvento;
        this.local = local;
        this.premio = premio;
        this.organizador = organizador;
        this.estado = new ArrayList<>();
    }
    
    public String resultadoFinal(String sigla){
        
        String resul = "Concurso: " +getDescricao()+ " " +getLocal()+ " - " +sigla+ "\n";
        resul += estado.size()+ " Candidatas\n";
        resul += "R$ " +valorArrecadado()+ " Arrecadado, " +qtdDeficiente()+ " isençoes\n";
        resul += "Vencedora: " +vencedor(sigla);
        return resul;
    }
    
    private double qtdDeficiente(){
        double qtd = 0;       
        for(Estado e : estado){
            qtd += e.valorInscricao();
        }
        qtd = estado.size() - (valorArrecadado() / qtd);
        return qtd;
    }
    
    public double valorArrecadado(){
        double valorTotal = 0.0;
        
        for(Estado e : estado){
            valorTotal += e.valorInscricao();
        }
        return valorTotal;
    }
    
    public Candidata vencedor(String sigla){
       Candidata vencedora = null;
       
       for(Estado e : estado){
           if(e.getSigla() == sigla){
                vencedora = e.getVencedora();
            }
       }
       return vencedora; 
    }
    
    public int inscricaoPorEstado(String sigla){
        int qtdInscritos = 0;
        
        for(Estado e : estado){
            if(e.getSigla() == sigla){
                qtdInscritos++;
            }
        }
        return qtdInscritos;
    }
    
    public String getDescricao(){
        return this.descricao;
    }
    public void setDescricao(String descricao){
        this.descricao = descricao;
    }
    
    public String getDataEvento(){
        return this.dataEvento;
    }
    public void setDataEvento(String dataEvento){
        this.dataEvento = dataEvento;
    }
    
    public String getLocal(){
        return this.local;
    }
    public void setLocal(String local){
        this.local = local;
    }
    
    public double getPremio(){
        return this.premio;
    }
    public void setPremio(double premio){
        this.premio = premio;
    }
    
    public Pessoa getOrganizador(){
        return this.organizador;
    }
    public void setOrganizador(Pessoa organizador){
        this.organizador = organizador;
    }
    
    public ArrayList<Estado> getEstado(){
        return this.estado;
    }
    public void addEstado(Estado est){
        this.estado.add(est);
    }
}
