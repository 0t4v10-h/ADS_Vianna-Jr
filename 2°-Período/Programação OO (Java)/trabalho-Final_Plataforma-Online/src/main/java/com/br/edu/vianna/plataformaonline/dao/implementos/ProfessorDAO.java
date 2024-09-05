/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.br.edu.vianna.plataformaonline.dao.implementos;

import com.br.edu.vianna.plataformaonline.dao.GenericsDAO;
import com.br.edu.vianna.plataformaonline.dao.connectionbd.ConnectionFactory;
import com.br.edu.vianna.plataformaonline.model.Professor;
import com.br.edu.vianna.plataformaonline.model.escola.Curso;
import com.br.edu.vianna.plataformaonline.utils.CryptoUtils;

import java.security.NoSuchAlgorithmException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;

/**
 *
 * @author otavi
 */
public class ProfessorDAO implements GenericsDAO<Professor, Integer> {
    private Connection c;

    @Override
    public void inserir(Professor professor) throws SQLException, ClassNotFoundException {

        c = ConnectionFactory.getConnection();

        String sqlUsuario = "INSERT INTO plataformaonline.usuario\n" +
                "(nome, email, login, senha) " +
                "VALUES(?, ?, ?, ?);";

        PreparedStatement pstU = c.prepareStatement(sqlUsuario, PreparedStatement.RETURN_GENERATED_KEYS);
        pstU.setString(1, professor.getNome());
        pstU.setString(2, professor.getEmail());
        pstU.setString(3, professor.getLogin());
        try{
            pstU.setString(4, CryptoUtils.md5(professor.getSenha()));
        }catch (NoSuchAlgorithmException e){
            throw new SQLException("Erro ao gerar a senha!");
        }
        pstU.execute();
        
        ResultSet rs = pstU.getGeneratedKeys();
        int userId = 0;
        if (rs.next()) {
           userId = rs.getInt(1);
        }
        
        String sqlProfessor = "INSERT INTO plataformaonline.professor\n" +
                "(id, curso_id) \n" +
                "VALUES (?, ?);";
        
        PreparedStatement pstP = c.prepareStatement(sqlProfessor);
        pstP.setInt(1, userId);
        pstP.setInt(2, professor.getCurso().getId());
        pstP.execute();
    }

    @Override
    public void alterar(Professor professor) throws SQLException, ClassNotFoundException {

        c = ConnectionFactory.getConnection();

        String sqlUsuario = "UPDATE plataformaonline.usuario\n" +
                "SET nome=?, email=?, login=?, senha=? " +
                "WHERE id=?;";

        PreparedStatement pstU = c.prepareStatement(sqlUsuario);
        pstU.setString(1, professor.getNome());
        pstU.setString(2, professor.getEmail());
        pstU.setString(3, professor.getLogin());
        try{
            pstU.setString(4, CryptoUtils.md5(professor.getSenha()));
        }catch (NoSuchAlgorithmException e){
            throw new SQLException("Erro ao gerar a senha!");
        }
        pstU.setInt(5, professor.getId());
        pstU.execute();
        
        String sqlProfessor = "UPDATE plataformaonline.professor SET curso_id=? WHERE id=?";
        PreparedStatement pstP = c.prepareStatement(sqlProfessor);
        pstP.setInt(1, professor.getCurso().getId());
        pstP.setInt(2, professor.getId() );
        pstP.execute();
    }

    @Override
    public void apagar(Professor professor) throws SQLException, ClassNotFoundException {

        c = ConnectionFactory.getConnection();

        String sqlProfessor = "DELETE FROM plataformaonline.professor " +
                "WHERE id=?;";

        PreparedStatement pstP = c.prepareStatement(sqlProfessor);
        pstP.setInt(1, professor.getId());
        pstP.execute();
        
        String sqlUsuario = "DELETE FROM plataformaonline.usuario WHERE id=?";
        PreparedStatement pstU = c.prepareStatement(sqlUsuario);
        pstU.setInt(1, professor.getId());
        pstU.executeUpdate();
    }

    @Override
    public Professor buscarUm(Integer id) throws SQLException, ClassNotFoundException {

        c = ConnectionFactory.getConnection();

        String sql = "SELECT u.id, u.nome, u.email, u.login, u.senha, p.curso_id " +
                     "FROM plataformaonline.usuario u " +
                     "INNER JOIN plataformaonline.professor p ON u.id = p.id " +
                     "WHERE u.id = ?;";

        PreparedStatement pst = c.prepareStatement(sql);
        pst.setInt(1, id);

        ResultSet rs = pst.executeQuery();

        Professor p = null;
        if(rs.next()){
            p = new Professor();
            p.setId(rs.getInt("id"));
            p.setNome(rs.getString("nome"));
            p.setEmail(rs.getString("email"));
            p.setLogin(rs.getString("login"));
            p.setSenha(rs.getString("senha"));
            
            Curso curso = new Curso();
            curso.setId(rs.getInt("curso_id"));
            p.setCurso(curso);
        }

        return p;
    }
    
    public ArrayList<Professor> buscarProfessorPorNome(String nome) throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();
    
        String sql = "SELECT u.id, u.nome, u.email, u.login, u.senha, p.curso_id " +
                     "FROM plataformaonline.usuario u " +
                     "INNER JOIN plataformaonline.professor p ON u.id = p.id " +
                     "WHERE u.nome LIKE ?;";  

        PreparedStatement pst = c.prepareStatement(sql);
        pst.setString(1, nome+ "%");  

        ResultSet rs = pst.executeQuery();

        ArrayList<Professor> listaProfessores = new ArrayList<>();
        while(rs.next()){            
            Professor p = new Professor();
            p.setId(rs.getInt("id"));
            p.setNome(rs.getString("nome"));
            p.setEmail(rs.getString("email"));
            p.setLogin(rs.getString("login"));
            p.setSenha(rs.getString("senha"));

            Curso curso = new Curso();
            curso.setId(rs.getInt("curso_id"));
            p.setCurso(curso);

            listaProfessores.add(p);
        }

        return listaProfessores;
    }

    public Professor buscarProfessorByLoginAndSenha(String login, String senha) throws SQLException, ClassNotFoundException {

        c = ConnectionFactory.getConnection();
        String sql = "SELECT u.id, u.nome, u.email, u.login, u.senha, p.curso_id " +
                     "FROM plataformaonline.usuario u " +
                     "INNER JOIN plataformaonline.professor p ON u.id = p.id " +
                     "WHERE u.login = ? AND u.senha = ?;";

        PreparedStatement pst = c.prepareStatement(sql);

        pst.setString(1, login);
        try {
            pst.setString(2, CryptoUtils.md5(senha) );
        } catch (NoSuchAlgorithmException e) {
            throw new SQLException("Erro na Criptografia");
        }

        ResultSet rs = pst.executeQuery();

        Professor p = null;
        if (rs.next()) {
            p = new Professor();
            p.setId(rs.getInt("id"));
            p.setNome(rs.getString("nome"));
            p.setEmail(rs.getString("email"));
            p.setLogin(rs.getString("login"));
            p.setSenha(rs.getString("senha"));
            
            Curso curso = new Curso();
            curso.setId(rs.getInt("curso_id"));
            p.setCurso(curso);
        }

        return p;
    }

    @Override
    public ArrayList<Professor> buscarTodos() throws SQLException, ClassNotFoundException {

        c =ConnectionFactory.getConnection();

        String sql = "SELECT * FROM plataformaonline.usuario u INNER JOIN plataformaonline.professor p ON u.id = p.id;";

        PreparedStatement pst = c.prepareStatement(sql);

        ResultSet rs = pst.executeQuery();

        ArrayList<Professor> listaProfessores = new ArrayList<>();
        while(rs.next()){            
            Professor p = new Professor();
            p.setId(rs.getInt("id"));
            p.setNome(rs.getString("nome"));
            p.setEmail(rs.getString("email"));
            p.setLogin(rs.getString("login"));
            p.setSenha(rs.getString("senha"));

            Curso curso = new Curso();
            curso.setId(rs.getInt("curso_id"));
            p.setCurso(curso);

            listaProfessores.add(p);
        }

        return listaProfessores;
    }

    @Override
    public int count() throws SQLException, ClassNotFoundException {

        c = ConnectionFactory.getConnection();

        String sql = "SELECT count(*) as qtde " +
                "FROM plataformaonline.professor;";

        PreparedStatement pst = c.prepareStatement(sql);

        ResultSet rs = pst.executeQuery();

        rs.next();

        return rs.getInt("qtde");
    }
}
