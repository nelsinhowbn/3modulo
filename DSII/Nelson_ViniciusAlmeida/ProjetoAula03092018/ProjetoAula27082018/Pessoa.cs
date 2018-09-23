using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace teste
{
    public partial class Pessoa : Form
    {
        public Pessoa()
        {
            InitializeComponent();
        }
        private void carregarPessoa()
        {
            //Validar se o campo estado está preenchido
            // Diferente de vazio

            //if (txtNmEstado.Text == "")
            //{
            //    MessageBox.Show("Digitar o nome do estado");
            //    return;
            //}

            DataSet ds = new DataSet();
            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=Agenda;Data Source=LAB-08-15");

                conexao.Open();

                SqlCommand cmd = new SqlCommand("sp_pessoa", conexao);

                cmd.CommandType = CommandType.StoredProcedure;

                if (txtNomeCliente.Text != "")
                {
                    cmd.Parameters.AddWithValue("@nome_cliente", txtNomeCliente.Text);
                }


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);

                //carregar DataGrid na tela

               grvPessoa.DataSource = ds.Tables[0];

            }

            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro, falar com o administrador.");

            }

            finally
            {
                conexao.Close();
            }

        }

        private void retornarPessoa()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Agenda;Data Source=LAB-08-15";
            conexao.Open();

            string comandoSQL = "SELECT * FROM pessoa";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            grvPessoa.DataSource = dt;

            conexao.Close();

        }
        private void CadastrarPessoa(  string nome_cliente, string endereco, string estado_civil, string data_nascimento)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=Agenda;Data Source=LAB-08-15";

            //abrir conexão
            conexao.Open();
 
            //inseri texto de insert
            string InsertPessoa = string.Concat("insert into pessoa values ( '", nome_cliente, "','", endereco, "','", estado_civil, "','", data_nascimento, "')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertPessoa, carregarPessoa());
        }
    }
}
