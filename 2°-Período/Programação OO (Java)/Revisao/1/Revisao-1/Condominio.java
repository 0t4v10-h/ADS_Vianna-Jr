import java.util.ArrayList;

public class Condominio
{
    private String nome;
    private String endereco;
    private ArrayList<Despesa> despesas;   
    private ArrayList<Imovel> imoveis;
    private ArrayList<Pagamento> pagamentos;
    
    public Condominio(){
        this("","");
        // ou 
        //despesas = new ArrayList<>();
        //imoveis = new ArrayList<>();
        //pagamentos = new ArrayList<>();
    }
    public Condominio(String nome, String endereco){
        this.nome = nome;
        this.endereco = endereco;
        despesas = new ArrayList<>();
        imoveis = new ArrayList<>();
        pagamentos = new ArrayList<>();
    }
    
    public double valorCondominio(int mesAno){
        double total = 0;   
        for(Despesa d : despesas){
            if(d.getMesAno() == mesAno){
                total += d.getValor();
            }
        }
        return total;
    }
    
    private int totalPago(int mesAno){
        int totPago = 0;
        for(Pagamento p : pagamentos){
            if(p.getMesAno() == mesAno){
                totPago += p.getValorPago();
            }
        }
        return totPago;
    }
    
    public String relatorio(){
        int mes = 1;
        String resultado = "";
        
        resultado += "Mes : " +mes+ " - 2023";
        
        int totPg = totalPago(Integer.parseInt(mes+"2023"));
        double vc = valorCondominio(Integer.parseInt(mes+"2023"));
        
        resultado += imoveis.size()+ " apartamentos ("+totPg+ " pagos - "
                +(imoveis.size()-totPg)+ " não pagos";
        
        resultado += "Valor arrecadado R$ " +(totPg * vc) +" R$ " 
                +((imoveis.size()-totPg) * vc);
        
        return resultado;
    }
    
    public void pagarCondominio(Imovel imovel, int mesAno){
        
        Pagamento p = new Pagamento(mesAno, valorCondominio(mesAno), imovel, this);
                      
        // ou 
        // Pagamento p = ne Pagamento();
        // p.setMesAno(mesAno);
        // p.setValor(valorCondominio(mesAno));
        // p.setImovel(imovel);
        // p.setCondominio(this);
        
        pagamentos.add(p); 
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
    public void addDespesa(Despesa desp){
        this.despesas.add(desp);
    }
    
    public ArrayList<Imovel> getImovel(){
        return this.imoveis;
    }
    public void addImoveis(Imovel imov){
        this.imoveis.add(imov);
    }
    
    public ArrayList<Pagamento> getPagamento(){
        return this.pagamentos;
    }
    public void addPagamento(Pagamento pag){
        this.pagamentos.add(pag);
    }
}
