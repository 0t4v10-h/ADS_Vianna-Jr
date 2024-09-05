import java.util.ArrayList;

public class Turma
{
   private int ano;
   private String dataVotacao;
   private ArrayList<Aluno> alunos;
   
   public Turma(){
       alunos = new ArrayList<>();
   }
   
   public ArrayList<Aluno> getAlunos(){
       return alunos;
   }
   public void addAluno(Aluno a){
       alunos.add( a );
   }
   
   public Aluno representante(){
       Aluno maisVotado = alunos.get(0);
       for (Aluno a : alunos){
           if (a.getVotos() > maisVotado.getVotos()){
              maisVotado = a; 
           }
       }
       return maisVotado;
   }
    
    public void setDataVotacao(String nome){
        this.dataVotacao = nome;
    }
    public String getDataVotacao(){
        return dataVotacao;
    }
   
}
