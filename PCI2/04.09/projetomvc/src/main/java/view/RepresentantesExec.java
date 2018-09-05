
package view;

import java.sql.Connection;

import controller.RepresentantesJdbcDAO;
import controller.JdbUtil;
import model.Representantes;

public class RepresentantesExec {
public static void main(String args[]) {
	Representantes representantes = new Representantes();
	try {
		representantes.setNome("Vinicius Alves");
		representantes.setEndereco("Av Lopes, 2700");
		representantes.setBairro("Penha");
		representantes.setCep(10514557);
		
		
		Connection connection = JdbUtil.getConnection();
		RepresentantesJdbcDAO representantesJdbcDAO = new RepresentantesJdbcDAO(connection);
		//representantesJdbcDAO.salvar(alunos); // este é para inserir na tabela
		//representantesJdbcDAO(3); //este é para apagar da tabela, puxa o metodo
		//representantesJdbcDAOr(); //chama o metodo que altera
		//representantesJdbcDAO(); //lista os registros
	}catch (Exception e) {
		e.printStackTrace();
	
	}
	
	
}
}
