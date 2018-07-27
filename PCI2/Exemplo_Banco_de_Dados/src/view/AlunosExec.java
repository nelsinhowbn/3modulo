package view;

import java.sql.Connection;

import controller.AlunosJdbcDAO;
import controller.JdbUtil;
import model.Alunos;

public class AlunosExec {
public static void main(String args[]) {
	Alunos alunos = new Alunos();
	try {
		alunos.setNome("Nelson Youssif");
		alunos.setEndereco("Av Águia de Haia, 2600");
		alunos.setBairro("Penha");
		
		Connection connection = JdbUtil.getConnection();
		AlunosJdbcDAO alunosJdbcDAO = new AlunosJdbcDAO(connection);
		alunosJdbcDAO.salvar(alunos);
	}catch (Exception e) {
		e.printStackTrace();
	
	}
	
	
}
}
