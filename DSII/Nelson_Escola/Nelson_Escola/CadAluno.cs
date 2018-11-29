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
    public partial class CadAluno : Form
    {
        public CadAluno()
        {
            InitializeComponent();
        }
        private void retornarAluno()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Escola;Data Source=LAB-07-11";
            conexao.Open();

            string comandoSQL = "SELECT * FROM aluno";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvAluno.DataSource = dt;

            conexao.Close();

        }
        private void CadastrarAluno(string nome, string email, string rg, string cpf, string estado)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=Escola;Data Source=LAB-07-11";

            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string InsertFuncionario = string.Concat("insert into aluno values ( '", nome, "','", email, "','", rg, "','", cpf, "','",estado,"')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertFuncionario, conexao);

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
            comboEstado.Text = "";


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarAluno(txtNome.Text, txtEmail.Text, txtRg.Text, txtCpf.Text, comboEstado.Text);
            LimparCampos();
            retornarAluno();
            MessageBox.Show("Registro de Aluno", "Etec ZL");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void CadAluno_Load(object sender, EventArgs e)
        {
            retornarAluno();
        }

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
