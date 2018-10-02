using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DS.Project.Controller;
using DS.Project.View;


namespace DS.Project.View
{
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e){

        	Aluno aluno = new Aluno(txtNmAluno.Text, txtEndAluno.Text, txtCepAluno.Text, txtEmailAluno.Text, txtNmrAluno.Text, txtNmrFixoAluno.Text ,dtpDtaNascimento.Value);
			try {
				Connector.execute(aluno.insertString);

			} catch (Exception exp) {

				MessageBox.Show("Houve um erro.\n\n" + exp.Message + "\n" + exp.StackTrace, "Erro!");
			}      
         }

        private void btnPesquisar_Click(object sender, EventArgs e){
            bool nomeNull = txtNmAluno.Text == "";
            bool endNull = txtEndAluno.Text == "";
            bool cepNull = txtCepAluno.Text == "";
            bool emailNull = txtEmailAluno.Text == "";
            bool nmrNull = txtNmrAluno.Text == "";
            bool nmrFixoNull = txtNmrFixoAluno.Text == "";
            bool nscNull = dtpDtaNascimento.Value == null || dtpDtaNascimento.Value.Equals(DateTime.Now);
            
            try{
                
                DataTable searchResults = Connector.executeQuery(string.Format("SELECT * FROM tbPessoa WHERE nmAluno = " + txtPesquisa.Text));
                frmCadastroAluno.windowConsulta = new frmCadastroAluno(searchResults);
                frmCadastroAluno.windowConsulta.Show();
            }catch (Exception exp){
                
                MessageBox.Show("Houve um erro.\n\n" + exp.Message + "\n" + exp.StackTrace, "Erro!");
            }finally{
                
                Connector.close();
            }
        }
    }
}
