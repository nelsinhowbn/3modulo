
package view;



import java.util.List;

import javax.swing.JFrame;


import controller.ClienteJDAO;
import controller.VendedorJDAO;
import model.Cliente;
import model.Vendedor;

public class App
{
    public static void main( String[] args )
    {
    	
    	//UPDATE ----CLIENTE, Caso não tiver ID para Inserir ele cria  
    	/*/ Cliente cliente = new Cliente();
         cliente.setCpf("372.468.423-53");
         cliente.setId(5);
         cliente.setNome("Antonio");
         cliente.setRg("52.573.456-2");
         ClienteJDAO.getInstance().merge(cliente);
         System.out.println("Objetos salvo com sucesso!!!");*/
         
    	//SELECT ------CLIENTE
    	 List<Cliente> clientes = ClienteJDAO.getInstance().findAll();
    	 System.out.println("Nome:");   
    	 System.out.println(clientes.get(0).getNome());
      	 System.out.println("CPF:");
    	 System.out.println(clientes.get(0).getCpf());
      	 System.out.println("RG:");
    	 System.out.println(clientes.get(0).getRg());
    	 
       //UPDATE ----- VENDEDOR  	
    	/*Vendedor vendedor = new Vendedor();
         vendedor.setCpf("1633.313.773-55");
         vendedor.setId(3);
         vendedor.setNome("Almondegass Litrão");
         vendedor.setRg("11.563.456-2");
         VendedorJDAO.getInstance().merge(vendedor);
         System.out.println("Objetos salvo com sucesso!!!");
         */
         
         
         
         
         
    	 
    	 
    	 
    	 
    	 
    	 
    	 
    	 
    	 
    	 
    	 
    	 
    	 
    	 
    	 
    	 
         
         
         
    }
}