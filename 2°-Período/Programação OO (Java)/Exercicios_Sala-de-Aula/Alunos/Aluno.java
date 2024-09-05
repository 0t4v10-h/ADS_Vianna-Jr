
public class Aluno {
    // declarar atributos
    private String nome;
    private double nota;
    
    /* metodo construtor (nao tem retorno e obrigatoriamente 
       precisa ter o mesmo nome da classe */ 
    public Aluno(String nNome, double nNota) {
        nome = nNome;
        nota = nNota;
    }
    
    // declarar metodos
    public boolean aprovado() {
        if (nota >= 7) {
            return true;
        } else {
            return false;
        }
    }
    
    // encapsulamento
    public String getNome() {
        return nome;
    }
    
    public void setNome(String nome) {
        if (nome != null || !nome.equals("")){
            this.nome = nome;
        }
    }
    
    public double getNota() {
        return nota;
    }
    
    public void setNota(double nota) {
        if (nota > 0 && nota <= 10){
            this.nota = nota;
        }
    }
}