using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace NelsonAtividadeMedico
{
    public partial class Consulta_Cadastro : Form
    {
        public Consulta_Cadastro()
        {
            InitializeComponent();
        }
        private void retornarPacientes()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AtividadePaciente;Data Source=LAB-07-11";
            conexao.Open();

            string comandoSQL = "SELECT * FROM paciente";
            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);
            
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvPaciente.DataSource = dt;

            conexao.Close();


        }
        private void CadastrarPaciente(int id_paciente, string nm_paciente,  string cpf_paciente, string rg_paciente, string endereco_paciente,  string cep_paciente, string bairro_paciente)
        {
           
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=AtividadePaciente;Data Source=LAB-07-11";

            conexao.Open();

           
            string InsertPaciente = string.Concat("insert into paciente values ( '", id_paciente, "','",nm_paciente,"','", cpf_paciente, "', '" ,rg_paciente, "','", endereco_paciente, "','", cep_paciente, "','", bairro_paciente,"' )");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertPaciente, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Consulta_Cadastro_Load(object sender, EventArgs e)
        {
           
          
            retornarPacientes();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            int id_paciente = Convert.ToInt32(txtCodigo.Text);
            CadastrarPaciente(id_paciente, txtNome.Text,txtCPF.Text, txtRG.Text, txtEndereco.Text, txtCEP.Text, txtBairro.Text );
            //LimparCampos();
            retornarPacientes();
            MessageBox.Show("Registro Paciente", "Etec ZL");
        }

        private void dgvPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // txtCodigo.Text = dgvPaciente.Rows[e.RowIndex].Cells[1].Value.ToString();
           //txtNome.Text = dgvPaciente.Rows[e.RowIndex].Cells[2].Value.ToString();




        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConsutar_Click(object sender, EventArgs e)
        {
            retornarPacientes();

        }
    }
}
