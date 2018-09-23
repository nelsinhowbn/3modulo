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
    public partial class PessoaDocumento : Form
    {
        public PessoaDocumento()
        {
            InitializeComponent();
        }

        private void carregarPessoaDoc()
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

                SqlCommand cmd = new SqlCommand("sp_pessoadoc", conexao);

                cmd.CommandType = CommandType.StoredProcedure;

                if (txtRg.Text != "")
                {
                    cmd.Parameters.AddWithValue("@rg", txtRg.Text);
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

        private void retornarPessoas()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Agenda;Data Source=LAB-08-15";
            conexao.Open();

            string comandoSQL = "SELECT * FROM pessoa_documento";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            grvPessoa.DataSource = dt;

            conexao.Close();

        }

        private void CadastrarPessoaDocumento(string rg, string cpf, string reservista, string carteira_trabalho, string cnh)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=Agenda;Data Source=LAB-08-15";


            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string InsertPessoa_documento = string.Concat("insert into Pessoa_documento values ( '", rg, "','", cpf, "','", reservista, "', '", carteira_trabalho, "','", cnh, "')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertPessoa_documento, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }

        private void LimparCampos()
        {
           
            txtRg.Text = "";
            txtCpf.Text = "";
            txtCnh.Text = "";
            txtClt.Text = "";
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
           
            CadastrarPessoaDocumento( txtRg.Text, txtCpf.Text, txtCnh.Text, txtClt.Text, txtCnh.Text);
            LimparCampos();
            MessageBox.Show("Pessoa Documento", "Etec ZL");
        }

        
        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void PessoaDocumento_Load(object sender, EventArgs e)
        {
            retornarPessoas();

        }

        private void grvPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRg.Text = grvPessoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCpf.Text = grvPessoa.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtReserv.Text = grvPessoa.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtClt.Text = grvPessoa.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCnh.Text = grvPessoa.Rows[e.RowIndex].Cells[5].Value.ToString();
            
            
            MessageBox.Show(grvPessoa.Rows[e.RowIndex].Cells[0].Value.ToString());
            //MessageBox.Show("Olá Mundo, Etec ZL");
        }

        private void grvPessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarPessoaDoc();
        }

    }
}
