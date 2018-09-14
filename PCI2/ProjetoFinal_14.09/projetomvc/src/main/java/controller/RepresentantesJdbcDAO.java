package controller;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import model.Representantes;

public class RepresentantesJdbcDAO{ 
private Connection conn;
public RepresentantesJdbcDAO(Connection conn) {
	this.conn = conn;
}
public void salvar(Representantes c) throws SQLException {
String sql = "insert into representantes (nome, endereco, cep, bairro) values (' "+c.getNome()+"','"+c.getEndereco()+"','"+c.getCep()+"','"+c.getBairro()+"')";
System.out.println(sql);
PreparedStatement prepareStatement = this.conn.prepareStatement(sql);
prepareStatement.executeUpdate();
prepareStatement.close();
}
public void deletar(int id) throws SQLException {
String sql = "delete from representantes where id = " + id;
System.out.println(sql);
PreparedStatement prepareStatement = this.conn.prepareStatement(sql);
prepareStatement.executeUpdate();
prepareStatement.close();
}
public void alterar(Representantes c, int id) {
	String sql = "update representantes set nome='"+c.getNome()+"',endereco='"+c.getEndereco()+"',bairro='"+c.getBairro()+"' where id =" + id;
System.out.println(sql);
PreparedStatement prepareStatement;
try {
	prepareStatement = this.conn.prepareStatement(sql);
	prepareStatement.executeUpdate();
    prepareStatement.close();
} catch (SQLException e) {
	e.printStackTrace();
}		
}public List<Representantes> listar() {
String sql = "select * from representantes";
System.out.println(sql);		
List<Representantes> representante = new ArrayList<Representantes>();
try {
	PreparedStatement prepareStatement = this.conn.prepareStatement(sql);
	ResultSet rs = prepareStatement.executeQuery();
	while(rs.next()) {
		int id = rs.getInt("id");
		String nome = rs.getString("nome");
		String endereco = rs.getString("endereco");
		String bairro = rs.getString("bairro");
		int cep = rs.getInt("cep");
		Representantes representante1 = new Representantes();
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
return representante;
}}