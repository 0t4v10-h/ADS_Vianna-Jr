/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.br.edu.vianna.plataformaonline.dao.implementos;

import com.br.edu.vianna.plataformaonline.dao.GenericsDAO;
import com.br.edu.vianna.plataformaonline.dao.connectionbd.ConnectionFactory;
import com.br.edu.vianna.plataformaonline.model.Aluno;
import com.br.edu.vianna.plataformaonline.model.Professor;
import com.br.edu.vianna.plataformaonline.model.escola.Avaliacao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author otavi
 */
public class AvaliacaoDAO implements GenericsDAO<Avaliacao, Integer> {
    private Connection c;

    @Override
    public void inserir(Avaliacao avaliacao) throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "INSERT INTO plataformaonline.avaliacao (professor_id, aluno_id, nota) VALUES (?, ?, ?);";
        PreparedStatement pst = c.prepareStatement(sql, PreparedStatement.RETURN_GENERATED_KEYS);
        pst.setInt(1, avaliacao.getProfessor().getId());
        pst.setInt(2, avaliacao.getAluno().getId());
        pst.setInt(3, avaliacao.getNota());

        pst.execute();
        ResultSet rs = pst.getGeneratedKeys();
        if (rs.next()) {
            avaliacao.setId(rs.getInt(1));
        }
    }
    
    public void saveAvaliacao(Avaliacao avaliacao) throws SQLException, ClassNotFoundException {
        Connection connection = null;
        PreparedStatement stmt = null;

        try {
            if (avaliacaoExists(avaliacao.getProfessor().getId(), avaliacao.getAluno().getId())) {
                throw new SQLException("Avaliação já existe para este aluno e professor.");
            }

            connection = ConnectionFactory.getConnection();
            String sql = "INSERT INTO avaliacao (professor_id, aluno_id, nota) VALUES (?, ?, ?)";
            stmt = connection.prepareStatement(sql);
            stmt.setInt(1, avaliacao.getProfessor().getId());
            stmt.setInt(2, avaliacao.getAluno().getId());
            stmt.setInt(3, avaliacao.getNota());

            stmt.executeUpdate();
        } catch (SQLException e) {
            e.printStackTrace();
            throw new SQLException("Erro ao salvar avaliação.");
        } finally {
            if (stmt != null) {
                stmt.close();
            }
            if (connection != null) {
                connection.close();
            }
        }
    }

    private boolean avaliacaoExists(int professorId, int alunoId) throws SQLException, ClassNotFoundException {
        Connection connection = null;
        PreparedStatement stmt = null;
        ResultSet rs = null;

        try {
            connection = ConnectionFactory.getConnection();
            String sql = "SELECT COUNT(*) FROM avaliacao WHERE professor_id = ? AND aluno_id = ?";
            stmt = connection.prepareStatement(sql);
            stmt.setInt(1, professorId);
            stmt.setInt(2, alunoId);
            rs = stmt.executeQuery();

            if (rs.next()) {
                return rs.getInt(1) > 0;
            }
            return false;
        } catch (SQLException e) {
            e.printStackTrace();
            throw new SQLException("Erro ao verificar existência da avaliação.");
        } finally {
            if (rs != null) {
                rs.close();
            }
            if (stmt != null) {
                stmt.close();
            }
            if (connection != null) {
                connection.close();
            }
        }
    }

    public ArrayList<Integer> obterAvaliacoesPorProfessor(int idProfessor) throws SQLException, ClassNotFoundException {
        ArrayList<Integer> avaliacoes = new ArrayList<>();
        
        String sql = "SELECT nota FROM plataformaonline.avaliacao WHERE professor_id = ?";
        try (Connection conn = ConnectionFactory.getConnection();
             PreparedStatement stmt = conn.prepareStatement(sql)) {
            
            stmt.setInt(1, idProfessor);
            ResultSet rs = stmt.executeQuery();
            
            while (rs.next()) {
                avaliacoes.add(rs.getInt("nota"));
            }
        }        
        return avaliacoes;
    }

    @Override
    public void alterar(Avaliacao avaliacao) throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "UPDATE plataformaonline.avaliacao SET professor_id = ?, aluno_id = ?, nota = ? WHERE id = ?;";
        PreparedStatement pst = c.prepareStatement(sql);
        pst.setInt(1, avaliacao.getProfessor().getId());
        pst.setInt(2, avaliacao.getAluno().getId());
        pst.setInt(3, avaliacao.getNota());
        pst.setInt(4, avaliacao.getId());

        pst.execute();
    }

    @Override
    public void apagar(Avaliacao avaliacao) throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "DELETE FROM plataformaonline.avaliacao WHERE id = ?;";
        PreparedStatement pst = c.prepareStatement(sql);
        pst.setInt(1, avaliacao.getId());

        pst.execute();
    }

    @Override
    public Avaliacao buscarUm(Integer id) throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "SELECT * FROM plataformaonline.avaliacao WHERE id = ?;";
        PreparedStatement pst = c.prepareStatement(sql);
        pst.setInt(1, id);

        ResultSet rs = pst.executeQuery();
        Avaliacao avaliacao = null;
        if (rs.next()) {
            Professor professor = new ProfessorDAO().buscarUm(rs.getInt("professor_id"));
            Aluno aluno = new AlunoDAO().buscarUm(rs.getInt("aluno_id"));
            avaliacao = new Avaliacao(rs.getInt("id"), professor, aluno, rs.getInt("nota"));
        }
        return avaliacao;
    }

    @Override
    public ArrayList<Avaliacao> buscarTodos() throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "SELECT * FROM plataformaonline.avaliacao;";
        PreparedStatement pst = c.prepareStatement(sql);

        ResultSet rs = pst.executeQuery();
        ArrayList<Avaliacao> avaliacoes = new ArrayList<>();
        while (rs.next()) {
            Professor professor = new ProfessorDAO().buscarUm(rs.getInt("professor_id"));
            Aluno aluno = new AlunoDAO().buscarUm(rs.getInt("aluno_id"));
            Avaliacao avaliacao = new Avaliacao(rs.getInt("id"), professor, aluno, rs.getInt("nota"));
            avaliacoes.add(avaliacao);
        }
        return avaliacoes;
    }

    @Override
    public int count() throws SQLException, ClassNotFoundException {
        c = ConnectionFactory.getConnection();

        String sql = "SELECT COUNT(*) AS qtde FROM plataformaonline.avaliacao;";
        PreparedStatement pst = c.prepareStatement(sql);

        ResultSet rs = pst.executeQuery();
        rs.next();
        int count = rs.getInt("qtde");

        return count;
    }
}
