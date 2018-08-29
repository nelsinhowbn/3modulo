package controller;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import model.Professor;

public class ProfessorJdbcDAO{ 
private Connection conn;
public ProfessorJdbcDAO(Connection conn) {
	this.conn = conn;
}
public void salvar(Professor c) throws SQLException {
String sql = "insert into professor (nome, endereco, cep, bairro) values (' "+c.getNome()+"','"+c.getEndereco()+"','"+c.getCep()+"','"+c.getBairro()+"')";
System.out.println(sql);
PreparedStatement prepareStatement = this.conn.prepareStatement(sql);
prepareStatement.executeUpdate();
prepareStatement.close();
}
public void deletar(int id) throws SQLException {
String sql = "delete from professor where id = " + id;
System.out.println(sql);
PreparedStatement prepareStatement = this.conn.prepareStatement(sql);
prepareStatement.executeUpdate();
prepareStatement.close();
}
public void alterar(Professor c) {
String sql = "update professor set nome='"+c.getNome()+"',endereco='"+c.getEndereco()+"',bairro='"+c.getBairro()+"';";
System.out.println(sql);
PreparedStatement prepareStatement;
try {
	prepareStatement = this.conn.prepareStatement(sql);
	prepareStatement.executeUpdate();
    prepareStatement.close();
} catch (SQLException e) {
	e.printStackTrace();
}		
}public List<Professor> listar() {
String sql = "select * from professor";
System.out.println(sql);		
List<Professor> professor = new ArrayList<Professor>();
try {
	PreparedStatement prepareStatement = this.conn.prepareStatement(sql);
	ResultSet rs = prepareStatement.executeQuery();
	while(rs.next()) {
		int id = rs.getInt("id");
		String nome = rs.getString("nome");
		String endereco = rs.getString("endereco");
		String bairro = rs.getString("bairro");
		int cep = rs.getInt("cep");
		Professor professor1 = new Professor();
		/*aluno.setId(id);
		aluno.setNome(nome);
		aluno.setEndereco(endereco);
		aluno.setBairro(bairro);*/
		
		System.out.println(rs.getInt("id") + " " + rs.getString("nome") + " " + rs.getString("bairro") + " " + rs.getInt("cep"));	
	}
	prepareStatement.close();
} catch (SQLException e) {
	e.printStackTrace();
}
return professor;
}}