/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.br.edu.vianna.plataformaonline.dao.implementos;

import com.br.edu.vianna.plataformaonline.dao.GenericsDAO;
import com.br.edu.vianna.plataformaonline.dao.connectionbd.ConnectionFactory;
import com.br.edu.vianna.plataformaonline.model.escola.Curso;
import com.br.edu.vianna.plataformaonline.model.escola.Material;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author otavi
 */
public class MaterialDAO implements GenericsDAO<Material, Integer>{
    private Connection c;

    @Override
    public void inserir(Material material) throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "INSERT INTO plataformaonline.material (titulo, conteudo) VALUES (?, ?);";
        PreparedStatement pst = c.prepareStatement(sql, PreparedStatement.RETURN_GENERATED_KEYS);
        pst.setString(1, material.getTitulo());
        pst.setString(2, material.getConteudo());

        pst.execute();
        ResultSet rs = pst.getGeneratedKeys();
        if (rs.next()) {
            material.setId(rs.getInt(1));
        }
    }

    @Override
    public void alterar(Material material) throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "UPDATE plataformaonline.material SET titulo = ?, conteudo = ? WHERE id = ?;";
        PreparedStatement pst = c.prepareStatement(sql);
        pst.setString(1, material.getTitulo());
        pst.setString(2, material.getConteudo());
        pst.setInt(3, material.getId());

        pst.execute();   
    }

    @Override
    public void apagar(Material material) throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "DELETE FROM plataformaonline.material WHERE id = ?;";
        PreparedStatement pst = c.prepareStatement(sql);
        pst.setInt(1, material.getId());

        pst.execute();
    }

    @Override
    public Material buscarUm(Integer id) throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "SELECT * FROM plataformaonline.material WHERE id = ?;";
        PreparedStatement pst = c.prepareStatement(sql);
        pst.setInt(1, id);

        ResultSet rs = pst.executeQuery();
        Material material = null;
        if (rs.next()) {
            material = new Material(rs.getString("titulo"), rs.getString("conteudo"));
            material.setId(rs.getInt("id"));
        }
        return material;
    }

    @Override
    public ArrayList<Material> buscarTodos() throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "SELECT * FROM plataformaonline.material;";
        PreparedStatement pst = c.prepareStatement(sql);

        ResultSet rs = pst.executeQuery();
        
        ArrayList<Material> materiais = new ArrayList<>();
        
        while (rs.next()) {
            Material material = new Material(rs.getString("titulo"), rs.getString("conteudo"));
            material.setId(rs.getInt("id"));
            materiais.add(material);
        }
        return materiais;
    }

    @Override
    public int count() throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "SELECT COUNT(*) AS qtde FROM plataformaonline.material;";
        PreparedStatement pst = c.prepareStatement(sql);

        ResultSet rs = pst.executeQuery();
        rs.next();
        int count = rs.getInt("qtde");

        return count;
    }
}
