package view;

import java.awt.Color;
import java.awt.Container;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.SQLException;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

import controller.JdbUtil;
import controller.RepresentantesJdbcDAO;

public class DeletarRepresentantes extends JFrame {
	JButton btnDeletar = new JButton("Deletar");
	JTextField id = new JTextField();
	JLabel deletarid = new JLabel("Digite o ID que será Deletado: ");
	
	public DeletarRepresentantes(){
		super("Apagar");
		
		Container paine = this.getContentPane();
		
		paine.add(deletarid);
		paine.add(id);	
		deletarid.setBounds(10, 15, 200, 30);
		id.setBounds(300, 15, 225, 30);
		this.setLayout(null);
		this.setVisible(true);
		this.setSize(600, 330);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		
		paine.add(btnDeletar);
		btnDeletar.setBounds(20, 250, 130, 30);
		 btnDeletar.setBackground(Color.BLACK); // cOR DO FUNDO DO BOTÃO
		 btnDeletar.setForeground(Color.WHITE); //fONTE DO BOTÃO SALVAR  
		
		btnDeletar.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e) {
			try {
				Connection connection = JdbUtil.getConnection();
				RepresentantesJdbcDAO deletarrepresentantesJdbcDao = new RepresentantesJdbcDAO(connection);
					
				deletarrepresentantesJdbcDao.deletar(Integer.parseInt(id.getText()));
			}catch(Exception err) { 
				err.printStackTrace();
			}
	
			}
		});
			

	}
	public static void main(String args[]) {
		DeletarRepresentantes dr = new DeletarRepresentantes();
	}
}


