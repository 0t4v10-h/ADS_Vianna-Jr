/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package com.br.edu.vianna.plataformaonline.dao;

import com.br.edu.vianna.plataformaonline.model.Usuario;

import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author otavi
 */
public interface GenericsDAO<C,K> {
    
    public void inserir( C obj) throws SQLException, ClassNotFoundException;
    public void alterar( C obj) throws SQLException, ClassNotFoundException;
    public void apagar( C obj) throws SQLException, ClassNotFoundException;
    public C buscarUm( K id) throws SQLException, ClassNotFoundException;
    public ArrayList<C> buscarTodos( ) throws SQLException, ClassNotFoundException;
    public int count( ) throws SQLException, ClassNotFoundException;
}
