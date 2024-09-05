package com.br.edu.vianna.plataformaonline.model.escola;

import com.br.edu.vianna.plataformaonline.model.Aluno;
import com.br.edu.vianna.plataformaonline.model.Professor;

import java.util.ArrayList;

public class Curso {
    private int id;
    private String nome;
    private String descricao;
    private Professor professor;
    private ArrayList<Aluno> alunos;
    private ArrayList<Material> materiais;
    private ArrayList<Avaliacao> avaliacoes;

    public Curso(){};
    
    public Curso(String nome, String descricao) {
        this.nome = nome;
        this.descricao = descricao;
    }
    
    public Curso(String nome, String descricao, Professor professor) {
        this.nome = nome;
        this.descricao = descricao;
        this.professor = professor;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public Professor getProfessor() {
        return professor;
    }

    public void setProfessor(Professor professor) {
        this.professor = professor;
    }

    public ArrayList<Aluno> getAlunos() {
        return alunos;
    }

    public void setAlunos(ArrayList<Aluno> alunos) {
        this.alunos = alunos;
    }

    public ArrayList<Material> getMateriais() {
        return materiais;
    }

    public void setMateriais(ArrayList<Material> materiais) {
        this.materiais = materiais;
    }

    public ArrayList<Avaliacao> getAvaliacoes() {
        return avaliacoes;
    }

    public void setAvaliacoes(ArrayList<Avaliacao> avaliacoes) {
        this.avaliacoes = avaliacoes;
    }
}
