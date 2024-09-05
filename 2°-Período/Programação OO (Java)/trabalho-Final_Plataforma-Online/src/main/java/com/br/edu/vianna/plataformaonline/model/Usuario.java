package com.br.edu.vianna.plataformaonline.model;

import java.util.ArrayList;

public abstract class Usuario {
    private int id;
    private String nome;
    private String email;
    private String login;
    private String senha;
    private static ArrayList<Administrador> administradores = new ArrayList<>();
    private static ArrayList<Professor> professores = new ArrayList<>();
    private static ArrayList<Aluno> alunos = new ArrayList<>();

    public Usuario(){}
    
    public Usuario(int id, String nome, String email, String login, String senha) {
        this.id = id;
        this.nome = nome;
        this.email = email;
        this.login = login;
        this.senha = senha;
    }

    public static void adicionarUsuario(Usuario usuario){
        if(usuario instanceof Administrador){
            administradores.add((Administrador) usuario);
        } else if(usuario instanceof Professor){
            professores.add((Professor) usuario);
        } else if(usuario instanceof Aluno){
            alunos.add((Aluno) usuario);
        }
    }

    public static ArrayList<Administrador> getAdministradores() {
        return administradores;
    }

    public static ArrayList<Professor> getProfessores() {
        return professores;
    }

    public static ArrayList<Aluno> getAlunos() {
        return alunos;
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

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getLogin() {
        return login;
    }

    public void setLogin(String login) {
        this.login = login;
    }

    public String getSenha() {
        return senha;
    }

    public void setSenha(String senha) {
        this.senha = senha;
    }
}
