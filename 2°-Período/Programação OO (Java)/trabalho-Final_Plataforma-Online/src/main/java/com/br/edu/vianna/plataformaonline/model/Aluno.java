package com.br.edu.vianna.plataformaonline.model;

public class Aluno extends Usuario{
    private String matricula;

    public Aluno(){}
    
    public Aluno(int id, String nome, String email, String login, String senha, String matricula){
        super(id, nome, email, login, senha);
        this.matricula = matricula;
    }

    public String getMatricula() {
        return matricula;
    }

    public void setMatricula(String matricula) {
        this.matricula = matricula;
    }
}
