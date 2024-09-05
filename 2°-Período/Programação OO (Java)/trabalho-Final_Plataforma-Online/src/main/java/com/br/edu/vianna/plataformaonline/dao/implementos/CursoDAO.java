/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.br.edu.vianna.plataformaonline.dao.implementos;

import com.br.edu.vianna.plataformaonline.dao.GenericsDAO;
import com.br.edu.vianna.plataformaonline.dao.connectionbd.ConnectionFactory;
import com.br.edu.vianna.plataformaonline.model.escola.Curso;
import com.br.edu.vianna.plataformaonline.model.Professor;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author otavi
 */
public class CursoDAO  implements GenericsDAO<Curso, Integer> {
    private Connection c;

    @Override
    public void inserir(Curso curso) throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "INSERT INTO plataformaonline.curso (nome, descricao) VALUES (?, ?)";
        PreparedStatement pst = c.prepareStatement(sql, PreparedStatement.RETURN_GENERATED_KEYS);
        pst.setString(1, curso.getNome());
        pst.setString(2, curso.getDescricao());
        pst.executeUpdate();

        ResultSet rs = pst.getGeneratedKeys();
        if (rs.next()) {
            curso.setId(rs.getInt(1));
        }
    }

    @Override
    public void alterar(Curso curso) throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "UPDATE plataformaonline.curso SET nome=?, descricao=? WHERE id=?";
        PreparedStatement pst = c.prepareStatement(sql);
        pst.setString(1, curso.getNome());
        pst.setString(2, curso.getDescricao());
        pst.setInt(3, curso.getId());
        pst.execute();
    }

    @Override
    public void apagar(Curso curso) throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "DELETE FROM plataformaonline.curso WHERE id=?";
        PreparedStatement pst = c.prepareStatement(sql);
        pst.setInt(1, curso.getId());
        pst.execute();
    }
    
    public boolean inscreverAlunoNoCurso(int alunoId, int cursoId) throws SQLException, ClassNotFoundException {
        Connection c = null;
        PreparedStatement pst = null;
        boolean sucesso = false;

        try {
            c = ConnectionFactory.getConnection();
            String sql = "INSERT INTO plataformaonline.curso_aluno (aluno_id, curso_id) VALUES (?, ?)";
            pst = c.prepareStatement(sql);
            pst.setInt(1, alunoId);
            pst.setInt(2, cursoId);

            int rowsAffected = pst.executeUpdate();
            sucesso = rowsAffected > 0;
        } finally {
            if (pst != null) {
                pst.close();
            }
            if (c != null) {
                c.close();
            }
        }
        return sucesso;
    }


    @Override
    public Curso buscarUm(Integer id) throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "SELECT c.id, c.nome, c.descricao, c.professor_id, u.nome AS professor_nome " +
                     "FROM plataformaonline.curso c " +
                     "INNER JOIN plataformaonline.usuario u ON c.professor_id = u.id " +
                     "WHERE c.id = ?;";
        PreparedStatement pst = c.prepareStatement(sql);
        pst.setInt(1, id);

        ResultSet rs = pst.executeQuery();
        Curso curso = null;
        if (rs.next()) {
            Professor professor = null;
            if (rs.getInt("professor_id") != 0) {
                professor = new Professor();
                professor.setId(rs.getInt("professor_id"));
                professor.setNome(rs.getString("professor_nome"));
            }
            
            curso = new Curso(rs.getString("nome"), rs.getString("descricao"));
            curso.setId(rs.getInt("id"));
            curso.setProfessor(professor);
        }
        return curso;
    }
    
    public ArrayList<Curso> buscarCursoPorNome(String nome) throws SQLException, ClassNotFoundException {
        Connection c = null;
        PreparedStatement pst = null;
        ResultSet rs = null;
        ArrayList<Curso> listaCurso = new ArrayList<>();

        
            c = ConnectionFactory.getConnection();
            String sql = "SELECT c.id, c.nome, c.descricao " +
                         "FROM plataformaonline.curso c " +
                         "WHERE c.nome LIKE ?";

            pst = c.prepareStatement(sql);
            pst.setString(1, nome + "%");

            rs = pst.executeQuery();

            while (rs.next()) {
                Curso curso = new Curso();
                curso.setId(rs.getInt("id"));
                curso.setNome(rs.getString("nome"));
                curso.setDescricao(rs.getString("descricao"));

                listaCurso.add(curso);
            }

        
        return listaCurso;
    }

    @Override
    public ArrayList<Curso> buscarTodos() throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "SELECT * " +
                     "FROM plataformaonline.curso;";
        PreparedStatement pst = c.prepareStatement(sql);

        ResultSet rs = pst.executeQuery();
        ArrayList<Curso> cursos = new ArrayList<>();
        while (rs.next()) {
            Professor professor = null;
            if (rs.getInt("professor_id") != 0) {
                professor = new Professor();
                professor.setId(rs.getInt("professor_id"));
                professor.setNome(rs.getString("professor_nome"));
            }

            Curso curso = new Curso(rs.getString("nome"), rs.getString("descricao"));
            curso.setId(rs.getInt("id"));
            curso.setProfessor(professor);
            cursos.add(curso);
        }
        return cursos;
    }

    @Override
    public int count() throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "SELECT count(*) as qtde FROM plataformaonline.curso";
        PreparedStatement pst = c.prepareStatement(sql);

        ResultSet rs = pst.executeQuery();
        rs.next();
        int count = rs.getInt("qtde");

        return count;
    }
}
