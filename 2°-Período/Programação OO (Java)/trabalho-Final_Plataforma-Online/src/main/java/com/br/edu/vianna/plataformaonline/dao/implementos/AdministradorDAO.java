/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.br.edu.vianna.plataformaonline.dao.implementos;

import com.br.edu.vianna.plataformaonline.dao.GenericsDAO;
import com.br.edu.vianna.plataformaonline.dao.connectionbd.ConnectionFactory;
import com.br.edu.vianna.plataformaonline.model.Administrador;
import com.br.edu.vianna.plataformaonline.utils.CryptoUtils;

import java.security.NoSuchAlgorithmException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author otavi
 */
public class AdministradorDAO implements GenericsDAO<Administrador, Integer>{
    private Connection c;

    @Override
    public void inserir(Administrador adm) throws SQLException, ClassNotFoundException {

        c = ConnectionFactory.getConnection();

        String sqlUsuario = "INSERT INTO plataformaonline.usuario\n" +
                "(nome, email, login, senha) " +
                "VALUES(?, ?, ?, ?);";

        PreparedStatement pstU = c.prepareStatement(sqlUsuario, PreparedStatement.RETURN_GENERATED_KEYS);
        pstU.setString(1, adm.getNome());
        pstU.setString(2, adm.getEmail());
        pstU.setString(3, adm.getLogin());
        try{
            pstU.setString(4, CryptoUtils.md5(adm.getSenha()));
        }catch (NoSuchAlgorithmException e){
            throw new SQLException("Erro ao gerar a senha!");
        }
        pstU.execute();
        
        ResultSet rs = pstU.getGeneratedKeys();
        int userId = 0;
        if (rs.next()) {
           userId = rs.getInt(1);
        }
        
        String sqlAdm = "INSERT INTO plataformaonline.administrador\n" +
                "(id) \n" +
                "VALUES (?);";
        
        PreparedStatement pstA = c.prepareStatement(sqlAdm);
        pstA.setInt(1, userId);
        pstA.execute();
    }

    @Override
    public void alterar(Administrador adm) throws SQLException, ClassNotFoundException {

        c = ConnectionFactory.getConnection();

        String sqlUsuario = "UPDATE plataformaonline.usuario\n" +
                "SET nome=?, email=?, login=?, senha=? " +
                "WHERE id=?;";

        PreparedStatement pstU = c.prepareStatement(sqlUsuario);
        pstU.setString(1, adm.getNome());
        pstU.setString(2, adm.getEmail());
        pstU.setString(3, adm.getLogin());
        try{
            pstU.setString(4, CryptoUtils.md5(adm.getSenha()));
        }catch (NoSuchAlgorithmException e){
            throw new SQLException("Erro ao gerar a senha!");
        }
        pstU.setInt(5, adm.getId());
        pstU.execute();
        
        String sqlAdm = "UPDATE plataformaonline.administrador SET id=? WHERE id=?";
        PreparedStatement pstA = c.prepareStatement(sqlAdm);
        pstA.setInt(1, adm.getId() );
        pstA.execute();
    }

    @Override
    public void apagar(Administrador adm) throws SQLException, ClassNotFoundException {

        c = ConnectionFactory.getConnection();

        String sqlAdm = "DELETE FROM plataformaonline.administrador " +
                "WHERE id=?;";

        PreparedStatement pstA = c.prepareStatement(sqlAdm);
        pstA.setInt(1, adm.getId());
        pstA.execute();
        
        String sqlUsuario = "DELETE FROM plataformaonline.usuario WHERE id=?";
        PreparedStatement pstU = c.prepareStatement(sqlUsuario);
        pstU.setInt(1, adm.getId());
        pstU.executeUpdate();
    }

    @Override
    public Administrador buscarUm(Integer id) throws SQLException, ClassNotFoundException {

        c = ConnectionFactory.getConnection();

        String sql = "SELECT u.id, u.nome, u.email, u.login, u.senha " +
                     "FROM plataformaonline.usuario u " +
                     "INNER JOIN plataformaonline.administrador a ON u.id = a.id " +
                     "WHERE u.id = ?;";

        PreparedStatement pst = c.prepareStatement(sql);
        pst.setInt(1, id);

        ResultSet rs = pst.executeQuery();

        Administrador a = null;
        if(rs.next()){
            a = new Administrador();
            a.setId(rs.getInt("id"));
            a.setNome(rs.getString("nome"));
            a.setEmail(rs.getString("email"));
            a.setLogin(rs.getString("login"));
            a.setSenha(rs.getString("senha"));
        }

        return a;
    }

    public Administrador buscarAdministradorByLoginAndSenha(String login, String senha) throws SQLException, ClassNotFoundException {

        c = ConnectionFactory.getConnection();
        String sql = "SELECT u.id, u.nome, u.email, u.login, u.senha " +
                     "FROM plataformaonline.usuario u " +
                     "INNER JOIN plataformaonline.administrador a ON u.id = a.id " +
                     "WHERE u.login = ? AND u.senha = ?;";

        PreparedStatement pst = c.prepareStatement(sql);

        pst.setString(1, login);
        try {
            pst.setString(2, CryptoUtils.md5(senha) );
        } catch (NoSuchAlgorithmException e) {
            throw new SQLException("Erro na Criptografia");
        }

        ResultSet rs = pst.executeQuery();

        Administrador a = null;
        if (rs.next()) {
            a = new Administrador();
            a.setId(rs.getInt("id"));
            a.setNome(rs.getString("nome"));
            a.setEmail(rs.getString("email"));
            a.setLogin(rs.getString("login"));
            a.setSenha(rs.getString("senha"));
        }

        return a;
    }

    @Override
    public ArrayList<Administrador> buscarTodos() throws SQLException, ClassNotFoundException {

        c =ConnectionFactory.getConnection();

        String sql = "SELECT u.id, u.nome, u.email, u.login, u.senha " +
                     "FROM plataformaonline.usuario u " +
                     "INNER JOIN plataformaonline.administrador a ON u.id = a.id;";

        PreparedStatement pst = c.prepareStatement(sql);

        ResultSet rs = pst.executeQuery();

        ArrayList<Administrador> listaAdministradores = new ArrayList<>();
        while(rs.next()){            
            Administrador a = new Administrador(rs.getInt("id"),
                    rs.getString("nome"),
                    rs.getString("email"),
                    rs.getString("login"),
                    rs.getString("senha"));
            listaAdministradores.add(a);
        }

        return listaAdministradores;
    }

    @Override
    public int count() throws SQLException, ClassNotFoundException {

        c = ConnectionFactory.getConnection();

        String sql = "SELECT count(*) as qtde " +
                "FROM plataformaonline.administrador;";

        PreparedStatement pst = c.prepareStatement(sql);

        ResultSet rs = pst.executeQuery();

        rs.next();

        return rs.getInt("qtde");
    }
}
