package com.br.edu.vianna.plataformaonline.model;

import com.br.edu.vianna.plataformaonline.model.escola.Curso;

public class Professor extends Usuario{
    
    private Curso curso;
    
    public Professor() {}
    public Professor(int id, String nome, String email, String login, String senha, Curso curso) {
        super(id, nome, email, login, senha);
        this.curso = curso;
    }
    
    public Curso getCurso() {
        return curso;
    }

    public void setCurso(Curso curso) {
        this.curso = curso;
    }
}
