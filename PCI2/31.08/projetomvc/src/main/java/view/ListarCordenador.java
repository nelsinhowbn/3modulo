package view;

import java.awt.Color;
import java.awt.Container;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextArea;

import controller.JdbUtil;
import controller.CordenadorJdbcDAO;

public class ListarCordenador extends JFrame {
	JButton btnListar = new JButton("Listar");
	
	JLabel Mostrando = new JLabel("Mostrando Cordenadores: ");
	JTextArea listando = new JTextArea();
	public ListarCordenador(){
		super("Listar Cordenadores");
		
		Container paine = this.getContentPane();
		
		paine.add(Mostrando);
	
		Mostrando.setBounds(10, 15, 200, 30);
		
		this.setLayout(null);
		this.setVisible(true);
		this.setSize(600, 330);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		
		paine.add(btnListar);
		btnListar.setBounds(20, 250, 130, 30);
		 btnListar.setBackground(Color.BLACK); // cOR DO FUNDO DO BOTÃO
		 btnListar.setForeground(Color.WHITE); //fONTE DO BOTÃO SALVAR  
		 paine.add(listando);
		 listando.setBounds(40, 40, 400, 180);

		btnListar.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e) {
			try {
				Connection connection = JdbUtil.getConnection();
				CordenadorJdbcDAO listarcordenadorJdbcDao = new CordenadorJdbcDAO(connection);
					
				listarcordenadorJdbcDao.listar();
				
			}catch(Exception err) { 
				err.printStackTrace();
			}
	
			}
		});
		

	}
	public static void main(String args[]) {
		ListarCordenador lc = new ListarCordenador();
	}
}

