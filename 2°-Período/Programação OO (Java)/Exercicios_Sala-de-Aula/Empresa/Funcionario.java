
public class Funcionario
{
    private String nome;
    private double salario;
    private String funcao;
    private boolean noturno;
    private int filhos;
    private boolean valeTrans;
    private int totalVendas;
    //private Empresa empresa;
    
    public Funcionario() {}
    
    public Funcionario (String nome, double salario, String funcao, boolean noturno, 
                        int filhos, boolean valeTrans, int totalVendas){
        this.nome = nome;
        this.salario =  salario;
        this.funcao = funcao;
        this.noturno = noturno;
        this.filhos = filhos;
        this.valeTrans = valeTrans;
        this.totalVendas = totalVendas;
    }
    
    public double inss(){
        return salario * 0.13;
    }
    
    public double bonusGerente(){
        return (funcao.toUpperCase().equals("GERENTE")) ? salario * 0.1 : 0;
    }
    
    public double bonusVendedor(){
        return (funcao.toUpperCase().equals("VENDEDOR")) ? totalVendas * 0.02 : 0;
    }
    
    public double descontoValeTrans(){
        return (valeTrans) ? (salario * 0.03) : 0;
    }
    
    public double addNoturno(){
        return (noturno) ? (salario * 0.02) : 0;
    }
    
    public double bonusPorFilho(){
        return (filhos < 3) ? filhos * 50 : 150;
    }
    
    public double salarioLiquido(){
        
        return salario - inss() + bonusGerente() + bonusVendedor() 
        - descontoValeTrans() + addNoturno() + bonusPorFilho();
    }
    
    public String getNome(){
        return this.nome;
    }
    public void setNome(String nome){
        if(nome != null || !nome.equals("")){
            this.nome = nome;
        }
    }
    
    public double getSalario(){
        return this.salario;
    }
    public void setSalario(double salario){
        this.salario = salario;
    }
    
    public String getFuncao(){
        return this.funcao;
    }
    public void setFuncao(String funcao){
        if(funcao != null || !funcao.equals("")){
            this.funcao = funcao;
        } 
    }
    
    public boolean getNoturno(){
        return this.noturno;
    }
    public void setNoturno(boolean noturno){
        this.noturno = noturno;
    }
    
    public int getFilhos(){
        return this.filhos;
    }
    public void setFilhos(int filhos){
        this.filhos = filhos;
    }
    
    public boolean getValeTrans(){
        return this.valeTrans;
    }
    public void setValeTrans(boolean valeTrans){
        this.valeTrans = valeTrans;
    }
    
    public int getTotalVendas(){
        return this.totalVendas;
    }
    public void setTotalVendas(int totalVendas){
        this.totalVendas = totalVendas;
    }
}
