using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Nelson_Escola
{
    public partial class CadProfessor : Form
    {
        public CadProfessor()
        {
            InitializeComponent();
        }

        private void retornarProfessor()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Escola;Data Source=LAB-07-11";
            conexao.Open();

            string comandoSQL = "SELECT * FROM professor";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvProfessor.DataSource = dt;

            conexao.Close();

        }


          private void CadastrarProfessor(string nome, string email, string rg, string cpf)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=Escola;Data Source=LAB-07-11";

            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string InsertProfessor = string.Concat("insert into professor values ( '", nome, "','", email, "','", rg, "','", cpf, "')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertProfessor, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }
          private void LimparCampos()
          {
              txtNome.Text = "";
              txtEmail.Text = "";
              txtRg.Text = "";
              txtCpf.Text = "";

          }
        private void CadProfessor_Load(object sender, EventArgs e)
        {
            retornarProfessor();
        }

        private void btnCadrastrar_Click(object sender, EventArgs e)
        {
                         CadastrarProfessor(txtNome.Text ,txtEmail.Text, txtRg.Text, txtCpf.Text);
            LimparCampos();
                         retornarProfessor();
            MessageBox.Show("Registro de Professor", "Etec ZL");
        }

        private void dgvProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }

  
}

