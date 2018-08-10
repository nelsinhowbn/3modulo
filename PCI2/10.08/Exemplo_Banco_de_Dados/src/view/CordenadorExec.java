package view;

import java.sql.Connection;

import controller.JdbUtil;
import controller.CordenadorJdbcDAO;
import model.Cordenador;

public class CordenadorExec {public static void main(String args[]) {
	Cordenador cordenador = new Cordenador();
	try {
	     cordenador.setNome("Vinicius Michelin");
		cordenador.setEndereco("Rua da Aguia, 3040");
		cordenador.setBairro("Itanhaem");
		cordenador.setCep(746345677);
		
		
		Connection connection = JdbUtil.getConnection();
	 CordenadorJdbcDAO cordenadorJdbcDAO = new CordenadorJdbcDAO(connection);
		cordenadorJdbcDAO.salvar(cordenador); // este é para inserir na tabela
		//cordenadorJdbcDAO.deletar(1); //este é para apagar da tabela, puxa o metodo
		//cordenadorJdbcDAO.listar(); //chama o metodo que altera
		//cordenadorJdbcDAO.listar(); //lista os registros
	}catch (Exception e) {
		e.printStackTrace();
	
	}
	
	
}
}
