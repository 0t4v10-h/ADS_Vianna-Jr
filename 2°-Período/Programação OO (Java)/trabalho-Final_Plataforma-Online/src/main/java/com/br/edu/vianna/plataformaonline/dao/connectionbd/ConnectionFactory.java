/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.br.edu.vianna.plataformaonline.dao.connectionbd;

import java.sql.Connection;
import java.sql.Driver;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author otavi
 */
public class ConnectionFactory {
    
    public static final String url = "jdbc:mysql://localhost:3306/plataformaonline";
    public static final String user = "root";
    public static final String PASSWORD = "1010";

    public static Connection getConnection() throws ClassNotFoundException, SQLException {
            Class.forName("com.mysql.cj.jdbc.Driver");
            return DriverManager.getConnection(url,
                    user,
                    PASSWORD);
    }
    
    public static void main(String[] args) {
        try {
            Connection c = getConnection();
            System.out.println("connectou");
        } catch (ClassNotFoundException | SQLException e) {
            System.out.println("ERRO");
        }
    }
}

