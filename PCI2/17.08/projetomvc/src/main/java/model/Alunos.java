package model;

public class Alunos {
	private String nome;
	 private String endereco;
	 private String Bairro;
	 private int cep=0;
	 private Integer id;

	 
	 
	 
	 
	 public Integer getId() {
	return id;
}
public void setId(Integer id) {
	this.id = id;
}
 
 
 
 public String getBairro() {
	return Bairro;
}
public void setBairro(String bairro) {
	Bairro = bairro;
}

public String getNome() {
	return nome;
}
public void setNome(String nome) {
	this.nome = nome;
}
public String getEndereco() {
	return endereco;
}
public void setEndereco(String endereco) {
	this.endereco = endereco;
}
public int getCep() {
	return cep;
}
public void setCep(int cep) {
	this.cep = cep;
}
}
