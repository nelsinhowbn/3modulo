using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCC
{
    public partial class Prestador : Form
    {
        public Prestador()
        {
            InitializeComponent();
        }
        private void retornarPestador()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Tcc;Data Source=LAB-07-11";
            conexao.Open();

            string comandoSQL = "SELECT * FROM tb_Prestador";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            grvPrestador.DataSource = dt;

            conexao.Close();

        }
        private void CadastrarPrestador(string nome, string cpf, string endereco, string cep, string celular, string tipo_servico)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=Tcc;Data Source=LAB-07-11";

            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string InsertFuncionario = string.Concat("insert into tb_Prestador values ( '", nome, "','", cpf, "','", endereco, "','", cep, "','",celular,"','",tipo_servico,"')");

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
            txtCEP.Text = "";
            txtEnd.Text = "";
             txtCel.Text = "";
             txtTipo.Text = "";
             txtCPF.Text = "";

        }

        private void Prestador_Load(object sender, EventArgs e)
        {
            retornarPestador();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {

           CadastrarPrestador(txtNome.Text, txtCPF.Text, txtEnd.Text, txtCEP.Text, txtCel.Text, txtTipo.Text);
            LimparCampos();
            MessageBox.Show("Registro Prestador", "Etec ZL");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            LimparCampos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            retornarPestador();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = grvPrestador.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCPF.Text = grvPrestador.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEnd.Text = grvPrestador.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCEP.Text = grvPrestador.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCel.Text = grvPrestador.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTipo.Text =  grvPrestador.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
