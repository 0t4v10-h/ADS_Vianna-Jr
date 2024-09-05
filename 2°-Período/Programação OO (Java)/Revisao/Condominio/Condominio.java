import java.util.ArrayList;

public class Condominio
{
    private String nome;
    private String endereco;
    private ArrayList<Despesa> despesas;
    private ArrayList<Imovel> imoveis;
    private ArrayList<Pagamento> pagamentos;
    
    public Condominio(){
        this("","");             // Chama o outro construtor
    }
    public Condominio(String nome, String endereco){
        this.nome = nome;
        this.endereco = endereco;
        despesas = new ArrayList<>();
        imoveis = new ArrayList<>();
        pagamentos = new ArrayList<>();
    }
    
    public double valorCondominio(int mesAno){
        double valorCond = 0;
        for(Despesa d : despesas){
            if(d.getMesAno() == mesAno){
                valorCond += d.getValor();
            }
        }
        return valorCond / imoveis.size();
    }
    
    public String relatorio(int mesAno){
        int totPg = totalPagamentos(mesAno);
        double valorCond = valorCondominio(mesAno);
        String relat = "MES :: " +mesAno+ "\n";
        
        relat += imoveis.size()+ "apartamentos ("+totPg+
                " pagos - " +(imoveis.size() - totPg)+ " nao pagos)";
        
        relat += "Valor arrecadados: R$ " +(totPg * valorCond)+
                "valor a ser pago R$ " +(imoveis.size() - totPg) * valorCond;
        
        return relat;
    }
    
    private int totalPagamentos(int mesAno){
        int totalPagos = 0;
        for(Pagamento p : pagamentos){
            if(p.getMesAno() == mesAno){
                totalPagos++;
            }
        }
        return totalPagos;
    }
    
    public void pagarCondominio(Imovel imovel, int mesAno){
        Pagamento pg = new Pagamento(mesAno, valorCondominio(mesAno), imovel, this);
        addPagamento(pg);           
    //ou pagamentos.add(pg);
    }
    
    public String getNome(){
        return this.nome;
    }
    public void setNome(String nome){
        this.nome = nome;
    }
    
    public String getEndereco(){
        return this.endereco;
    }
    public void setEndereco(String endereco){
        this.endereco = endereco;
    }
    
    public ArrayList<Despesa> getDespesa(){
        return this.despesas;
    }
    public void addDespesas(Despesa desp){
        despesas.add(desp);  
    }
    
    public ArrayList<Imovel> getImovel(){
        return this.imoveis;
    }
    public void addImovel(Imovel imo){
        imoveis.add(imo);
    }
    
    public ArrayList<Pagamento> getPagamentos(){
        return this.pagamentos;
    }
    public void addPagamento(Pagamento pag){
        this.pagamentos.add(pag);
    }
}
