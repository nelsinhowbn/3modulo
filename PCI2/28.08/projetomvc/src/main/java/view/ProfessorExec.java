package view;

import java.sql.Connection;

import controller.ProfessorJdbcDAO;
import controller.JdbUtil;
import model.Professor;

public class ProfessorExec {
	public static void main(String args[]) {
		Professor professor = new Professor();
		try {
			professor.setNome("Professor Jefferson");
			professor.setEndereco("Av Aguia de Haia, 2750");
			professor.setBairro("Itaquacetuba");
			professor.setCep(1068444557);
			
			
			Connection connection = JdbUtil.getConnection();
		 ProfessorJdbcDAO professorJdbcDAO = new ProfessorJdbcDAO(connection);
			//professorJdbcDAO.salvar(professor); // este é para inserir na tabela
			//professorJdbcDAO.deletar(1); //este é para apagar da tabela, puxa o metodo
			//professorJdbcDAO.listar(); //chama o metodo que altera
			//professorJdbcDAO.listar(); //lista os registros
		}catch (Exception e) {
			e.printStackTrace();
		
		}
		
		
	}
	}


