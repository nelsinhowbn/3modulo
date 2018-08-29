package controller;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import model.Cordenador;

public class CordenadorJdbcDAO {private Connection conn;
public CordenadorJdbcDAO(Connection conn) {
	this.conn = conn;
}
public void salvar(Cordenador c) throws SQLException {
String sql = "insert into cordenador (nome, endereco, cep, bairro) values (' "+c.getNome()+"','"+c.getEndereco()+"','"+c.getCep()+"','"+c.getBairro()+"')";
System.out.println(sql);
PreparedStatement prepareStatement = this.conn.prepareStatement(sql);
prepareStatement.executeUpdate();
prepareStatement.close();
}
public void deletar(int id) throws SQLException {
String sql = "delete from cordenador where id = " + id;
System.out.println(sql);
PreparedStatement prepareStatement = this.conn.prepareStatement(sql);
prepareStatement.executeUpdate();
prepareStatement.close();
}
public void alterar(Cordenador c) {
String sql = "update cordenador set nome='"+c.getNome()+"',endereco='"+c.getEndereco()+"',bairro='"+c.getBairro()+"';";
System.out.println(sql);
PreparedStatement prepareStatement;
try {
	prepareStatement = this.conn.prepareStatement(sql);
	prepareStatement.executeUpdate();
    prepareStatement.close();
} catch (SQLException e) {
	e.printStackTrace();
}		
}public List<Cordenador> listar() {
String sql = "select * from cordenador";
System.out.println(sql);		
List<Cordenador> cordenador = new ArrayList<Cordenador>();
try {
	PreparedStatement prepareStatement = this.conn.prepareStatement(sql);
	ResultSet rs = prepareStatement.executeQuery();
	while(rs.next()) {
		int id = rs.getInt("id");
		String nome = rs.getString("nome");
		String endereco = rs.getString("endereco");
		String bairro = rs.getString("bairro");
		int cep = rs.getInt("cep");
       Cordenador cordenador1 = new Cordenador();
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
return cordenador;
}}


