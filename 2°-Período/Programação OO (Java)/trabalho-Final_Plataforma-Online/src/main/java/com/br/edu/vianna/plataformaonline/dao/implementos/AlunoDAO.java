/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.br.edu.vianna.plataformaonline.dao.implementos;

import com.br.edu.vianna.plataformaonline.dao.GenericsDAO;
import com.br.edu.vianna.plataformaonline.dao.connectionbd.ConnectionFactory;
import com.br.edu.vianna.plataformaonline.model.Aluno;
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
public class AlunoDAO implements GenericsDAO<Aluno, Integer>{
    private Connection c;

    @Override
    public void inserir(Aluno aluno) throws SQLException, ClassNotFoundException {
        // 4 passos???
        // connectar
        c = ConnectionFactory.getConnection();
        // comando sql
        String sqlUsuario = "INSERT INTO plataformaonline.usuario\n" +
                "(nome, email, login, senha)\n" +
                "VALUES(?, ?, ?, ?);";
        //preparar execução
        PreparedStatement pstU = c.prepareStatement(sqlUsuario,  PreparedStatement.RETURN_GENERATED_KEYS);
        pstU.setString(1, aluno.getNome() );
        pstU.setString(2, aluno.getEmail() );
        pstU.setString(3, aluno.getLogin() );
        try {
            pstU.setString(4, CryptoUtils.md5(aluno.getSenha() ) );
        } catch (NoSuchAlgorithmException e) {
            throw new SQLException("erro ao gerar a senha");
        }
        pstU.execute();
        
        ResultSet rs = pstU.getGeneratedKeys();
        int userId = 0;
        if (rs.next()) {
           userId = rs.getInt(1);
        }
        
        String sqlAluno = "INSERT INTO plataformaonline.aluno\n" +
                "(id, matricula) \n" +
                "VALUES (?, ?);";
                
        PreparedStatement pstA = c.prepareStatement(sqlAluno);
        pstA.setInt(1, userId);
        pstA.setString(2, aluno.getMatricula() );
        pstA.execute();
    }

    @Override
    public void alterar(Aluno aluno) throws SQLException, ClassNotFoundException {
        // 4 passos???
        // connectar
        c = ConnectionFactory.getConnection();
        // comando sql
        String sqlUsuario = "UPDATE plataformaonline.usuario\n" +
                "SET nome=?, email=?, login=?, senha=? " +
                "WHERE id=?;";
        //preparar execução
        PreparedStatement pstU = c.prepareStatement(sqlUsuario);
        pstU.setString(1, aluno.getNome() );
        pstU.setString(2, aluno.getEmail() );
        pstU.setString(3, aluno.getLogin() );
        pstU.setString(4, aluno.getSenha());
        pstU.setInt(5, aluno.getId());
        pstU.execute();
        
        String sqlAluno = "UPDATE plataformaonline.aluno SET matricula=? WHERE id=?";
        PreparedStatement pstA = c.prepareStatement(sqlAluno);
        pstA.setString(1, aluno.getMatricula() );
        pstA.setInt(2, aluno.getId() );
        pstA.execute();
    }

    @Override
    public void apagar(Aluno aluno) throws SQLException, ClassNotFoundException {
        // 4 passos???
        // connectar
        c = ConnectionFactory.getConnection();
        // comando sql
        String sqlAluno = "DELETE FROM plataformaonline.aluno " +
                "WHERE id=?;";
        //preparar execução
        PreparedStatement pstA = c.prepareStatement(sqlAluno);

        pstA.setInt(1, aluno.getId() );
        //Execução
        pstA.execute();
        
        
        String sqlUsuario = "DELETE FROM plataformaonline.usuario WHERE id=?";
        PreparedStatement pstU = c.prepareStatement(sqlUsuario);
        pstU.setInt(1, aluno.getId());
        pstU.executeUpdate();
    }

    @Override
    public Aluno buscarUm(Integer id) throws SQLException, ClassNotFoundException {
        // 5 passos???
        // connectar
        c = ConnectionFactory.getConnection();
        // comando sql
        String sql = "SELECT u.id, u.nome, u.email, u.login, u.senha, a.matricula " +
                     "FROM plataformaonline.usuario u " +
                     "INNER JOIN plataformaonline.aluno a ON u.id = a.id " +
                     "WHERE u.id = ?;";
        //preparar execução
        PreparedStatement pst = c.prepareStatement(sql);

        pst.setInt(1, id);
        //Execução
        ResultSet rs = pst.executeQuery();
        // preencher o Objeto
        Aluno a = null;
        if (rs.next()) {
            a = new Aluno();
            a.setId(rs.getInt("id"));
            a.setMatricula(rs.getString("matricula"));
            a.setNome(rs.getString("nome"));
            a.setEmail(rs.getString("email"));
            a.setLogin(rs.getString("login"));
            a.setSenha(rs.getString("senha"));
        }

        return a;
    }

    public Aluno buscarAlunoByLoginAndSenha(String login, String senha) throws SQLException, ClassNotFoundException {

        c = ConnectionFactory.getConnection();
        String sql = "SELECT u.id, u.nome, u.email, u.login, u.senha, a.matricula " +
                     "FROM plataformaonline.usuario u " +
                     "INNER JOIN plataformaonline.aluno a ON u.id = a.id " +
                     "WHERE u.login = ? AND u.senha = ?;";
        //preparar execução
        PreparedStatement pst = c.prepareStatement(sql);

        pst.setString(1, login);
        try {
            pst.setString(2, CryptoUtils.md5(senha) );
        } catch (NoSuchAlgorithmException e) {
            throw new SQLException("Erro na Criptografia");
        }
        //Execução
        ResultSet rs = pst.executeQuery();
        // preencher o Objeto
        Aluno a = null;
        if (rs.next()) {
            a = new Aluno();
            a.setId(rs.getInt("id"));          
            a.setNome(rs.getString("nome"));
            a.setEmail(rs.getString("email"));
            a.setLogin(rs.getString("login"));
            a.setSenha(rs.getString("senha"));
            a.setMatricula(rs.getString("matricula"));
        }

        return a;
    }

    @Override
    public ArrayList<Aluno> buscarTodos() throws SQLException, ClassNotFoundException {
        // 5 passos???
        // connectar
        c = ConnectionFactory.getConnection();
        // comando sql
        String sql = "SELECT u.id, u.nome, u.email, u.login, u.senha, a.matricula " +
                     "FROM plataformaonline.usuario u " +
                     "INNER JOIN plataformaonline.aluno a ON u.id = a.id;";
        //preparar execução
        PreparedStatement pst = c.prepareStatement(sql);

        //Execução
        ResultSet rs = pst.executeQuery();
        // preencher o Objeto
        ArrayList<Aluno> listaAlunos = new ArrayList<>();
        while (rs.next()) {

            Aluno a = new Aluno(rs.getInt("id"),
                    rs.getString("nome"),
                    rs.getString("email"),
                    rs.getString("login"),
                    rs.getString("senha"),
                    rs.getString("matricula"));
            listaAlunos.add(a);
        }

        return listaAlunos;
    }

    @Override
    public int count() throws SQLException, ClassNotFoundException {
        // 5 passos???
        // connectar
        c = ConnectionFactory.getConnection();
        // comando sql
        String sql = "SELECT count(*) qtde " +
                " FROM plataformaonline.aluno ";
        //preparar execução
        PreparedStatement pst = c.prepareStatement(sql);

        //Execução
        ResultSet rs = pst.executeQuery();
        // preencher o Objeto
        rs.next();

        return rs.getInt("qtde");
    }
}
