

public class Main {
    public static void main(String[] args) {
    
        Aluno a1, a2;
        
        a1 = new Aluno("Otavio", 9);
        a2 = new Aluno("Ze", 5);
        
        if (a1.aprovado() ) {
            System.out.println(a1.nome+" esta aprovado");
        } else {
            System.out.println(a1.nome+" esta reprovado");
        }
        
        if (a2.aprovado() ) {
            System.out.println(a2.nome+" esta aprovado");
        } else {
            System.out.println(a2.nome+" esta reprovado");
        }
    
    }   
}
