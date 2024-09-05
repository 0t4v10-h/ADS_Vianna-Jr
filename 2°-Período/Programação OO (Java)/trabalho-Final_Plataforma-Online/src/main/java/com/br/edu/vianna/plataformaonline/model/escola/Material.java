package com.br.edu.vianna.plataformaonline.model.escola;

public class Material {
    private int id;
    private Curso curso;
    private String titulo;
    private String conteudo;

    public Material(){}
    
    public Material(String titulo, String conteudo){
        this.titulo = titulo;
        this.conteudo = conteudo;
    }
    
    public Material(Curso curso, String titulo, String conteudo) {
        this.curso = curso;
        this.titulo = titulo;
        this.conteudo = conteudo;
    }

    public Curso getCurso() {
        return curso;
    }

    public void setCurso(Curso curso) {
        this.curso = curso;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public String getConteudo() {
        return conteudo;
    }

    public void setConteudo(String conteudo) {
        this.conteudo = conteudo;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
}
