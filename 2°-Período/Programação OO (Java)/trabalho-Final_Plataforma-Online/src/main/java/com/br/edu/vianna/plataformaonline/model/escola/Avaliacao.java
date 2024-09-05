package com.br.edu.vianna.plataformaonline.model.escola;

import com.br.edu.vianna.plataformaonline.model.Aluno;
import com.br.edu.vianna.plataformaonline.model.Professor;

public class Avaliacao {
    private int id;
    private Professor professor;
    private Aluno aluno;
    private int nota;

    public Avaliacao(){}
    
public Avaliacao(Professor professor, Aluno aluno, int nota) {
        this.professor = professor;
        this.aluno = aluno;
        this.nota = nota;
    }
    
    public Avaliacao(int id,Professor professor, Aluno aluno, int nota) {
        this.id = id;
        this.professor = professor;
        this.aluno = aluno;
        this.nota = nota;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Professor getProfessor() {
        return professor;
    }

    public void setProfessor(Professor professor) {
        this.professor = professor;
    }

    public Aluno getAluno() {
        return aluno;
    }

    public void setAluno(Aluno aluno) {
        this.aluno = aluno;
    }

    public int getNota() {
        return nota;
    }

    public void setNota(int nota) {
        this.nota = nota;
    }
}
