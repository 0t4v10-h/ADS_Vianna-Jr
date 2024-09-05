/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.br.edu.vianna.plataformaonline;

import com.br.edu.vianna.plataformaonline.dao.implementos.AdministradorDAO;
import com.br.edu.vianna.plataformaonline.dao.implementos.AlunoDAO;
import com.br.edu.vianna.plataformaonline.dao.implementos.CursoDAO;
import com.br.edu.vianna.plataformaonline.dao.implementos.MaterialDAO;
import com.br.edu.vianna.plataformaonline.dao.implementos.ProfessorDAO;

import com.br.edu.vianna.plataformaonline.model.Administrador;
import com.br.edu.vianna.plataformaonline.model.Aluno;
import com.br.edu.vianna.plataformaonline.model.Professor;
import com.br.edu.vianna.plataformaonline.model.escola.Curso;
import com.br.edu.vianna.plataformaonline.model.escola.Material;

import java.sql.SQLException;

/**
 *
 * @author aluno
 */

public class PlataformaOnline {

    public static void main(String[] args) {
        
        CursoDAO cursoDAO = new CursoDAO();
        Curso c1 = new Curso("Matematica", "Presencial");
        try{
            cursoDAO.inserir(c1);
        }catch (SQLException | ClassNotFoundException e){
            System.out.println("Curso - Não conseguiu salvar no banco: " +e.getMessage());
        }
        
        Curso c2 = new Curso("Historia", "Presencial");
        try{
            cursoDAO.inserir(c2);
        }catch (SQLException | ClassNotFoundException e){
            System.out.println("Curso - Não conseguiu salvar no banco: " +e.getMessage());
        }
        
        Curso c3 = new Curso("Geografia", "EAD");
        try{
            cursoDAO.inserir(c3);
        }catch (SQLException | ClassNotFoundException e){
            System.out.println("Curso - Não conseguiu salvar no banco: " +e.getMessage());
        }
        
        
        
        ProfessorDAO professorDAO = new ProfessorDAO();
        Professor p1 = new Professor(1, "Zé", "ze@mail.com", "ze", "111", c1);
        try{
            professorDAO.inserir(p1);
        }catch (SQLException | ClassNotFoundException e){
            System.out.println("Professor - Não conseguiu salvar no banco: " +e.getMessage());
        }
        
        Professor p2 = new Professor(2, "Jão", "jao@mail.com", "jao", "111", c2);
        try{
            professorDAO.inserir(p2);
        }catch (SQLException | ClassNotFoundException e){
            System.out.println("Professor - Não conseguiu salvar no banco: " +e.getMessage());
        }       
        
        Professor p3 = new Professor(3, "Chico", "chico@mail.com", "chico", "111", c3);
        try{
            professorDAO.inserir(p3);
        }catch (SQLException | ClassNotFoundException e){
            System.out.println("Professor - Não conseguiu salvar no banco: " +e.getMessage());
        }
        
        
        
        AlunoDAO alunoDAO =  new AlunoDAO();
        Aluno a1 = new Aluno(4,"Monkey D. Luffy","luffy@mail.com","luffy",
                "123","1234");
        try {
            alunoDAO.inserir(a1);
        } catch (SQLException | ClassNotFoundException e) {
            System.out.println("Aluno - Não conseguiu salvar no banco: "+e.getMessage());
        }
        
        Aluno a2 = new Aluno(5,"Roronoa Zoro","zoro@mail.com","zoro",
                "123","2345");
        try {
            alunoDAO.inserir(a2);
        } catch (SQLException | ClassNotFoundException e) {
            System.out.println("Aluno - Não conseguiu salvar no banco: "+e.getMessage());
        }
        
        Aluno a3 = new Aluno(6,"Vinsmoke Sanji Perna Negra","sanji@mail.com","sanji",
                "123","3456");
        try {
            alunoDAO.inserir(a3);
        } catch (SQLException | ClassNotFoundException e) {
            System.out.println("Aluno - Não conseguiu salvar no banco: "+e.getMessage());
        }
        
        Aluno a4 = new Aluno(7,"Nami Zo","nami@mail.com","nami",
                "123","4567");
        try {
            alunoDAO.inserir(a4);
        } catch (SQLException | ClassNotFoundException e) {
            System.out.println("Aluno - Não conseguiu salvar no banco: "+e.getMessage());
        }
        
        Aluno a5 = new Aluno(8,"God Usopp","usopp@mail.com","usopp",
                "123","5678");
        try {
            alunoDAO.inserir(a5);
        } catch (SQLException | ClassNotFoundException e) {
            System.out.println("Aluno - Não conseguiu salvar no banco: "+e.getMessage());
        }
        
     
        
        AdministradorDAO admDAO = new AdministradorDAO();
        Administrador adm = new Administrador(9, "Lele da Cuca", "cuca@mail.com", "lele", "000");
        try{
            admDAO.inserir(adm);
        }catch (SQLException | ClassNotFoundException e){
            System.out.println("Administrador - Não conseguiu salvar no banco: " +e.getMessage());
        }
    
        
        MaterialDAO materialDAO = new MaterialDAO();
        Material m1 = new Material(c1, "Vetor", "slides");
        try{
            materialDAO.inserir(m1);
        }catch (SQLException | ClassNotFoundException e){
            System.out.println("Material - Não conseguiu salvar no banco: " +e.getMessage());
        }
        
        Material m2 = new Material(c2, "Brasil Imperio", "slides");
        try{
            materialDAO.inserir(m2);
        }catch (SQLException | ClassNotFoundException e){
            System.out.println("Material - Não conseguiu salvar no banco: " +e.getMessage());
        }
        
        Material m3 = new Material(c3, "Chuva Acida", "Exercicios");
        try{
            materialDAO.inserir(m3);
        }catch (SQLException | ClassNotFoundException e){
            System.out.println("Material - Não conseguiu salvar no banco: " +e.getMessage());
        }
    }
}
