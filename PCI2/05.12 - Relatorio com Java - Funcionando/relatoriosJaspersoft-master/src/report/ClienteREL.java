package report;

import net.sf.jasperreports.engine.JasperCompileManager;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.data.JRBeanCollectionDataSource;

import java.util.List;

import model.Cliente;

public class ClienteREL {
	private String path; // Caminho base

	private String pathToReportPackage; // Caminho para o package onde est�o armazenados os relatorios Jarper

	// Recupera os caminhos para que a classe possa encontrar os relat�rios
	public ClienteREL() {
		this.path = this.getClass().getClassLoader().getResource("").getPath();
		this.pathToReportPackage = this.path + "report/";
		System.out.println(path);
		System.out.println(pathToReportPackage);
	}

	// Imprime/gera uma lista de Clientes
	public void imprimir(List<Cliente> clientes) throws Exception {
		JasperReport report = JasperCompileManager.compileReport(this.getPathToReportPackage() + "Clientes.jrxml");

		JasperPrint print = JasperFillManager.fillReport(report, null, new JRBeanCollectionDataSource(clientes));

		JasperExportManager.exportReportToPdfFile(print, "c:/Users/Aluno/Desktop/Relatorio_de_Clientes.pdf");
	}

	public String getPathToReportPackage() {
		return this.pathToReportPackage;
	}

	public String getPath() {
		return this.path;
	}
}
