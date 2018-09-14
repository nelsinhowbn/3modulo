
package view;

import java.sql.Connection;

import controller.AlunosJdbcDAO;
import controller.JdbUtil;
import model.Alunos;

public class AlunosExec {
public static void main(String args[]) {
	Alunos alunos = new Alunos();
	try {
		alunos.setNome("Vinicius Alves");
		alunos.setEndereco("Av Lopes, 2700");
		alunos.setBairro("Penha");
		alunos.setCep(10514557);
		
		
		Connection connection = JdbUtil.getConnection();
		AlunosJdbcDAO alunosJdbcDAO = new AlunosJdbcDAO(connection);
		//alunosJdbcDAO.salvar(alunos); // este é para inserir na tabela
		//alunosJdbcDAO.deletar(3); //este é para apagar da tabela, puxa o metodo
		//alunosJdbcDAO.listar(); //chama o metodo que altera
		//alunosJdbcDAO.listar(); //lista os registros
	}catch (Exception e) {
		e.printStackTrace();
	
	}
	
	
}
}
