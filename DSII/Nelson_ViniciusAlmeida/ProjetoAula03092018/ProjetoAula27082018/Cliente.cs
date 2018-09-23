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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        private void carregarClientes()
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

                SqlCommand cmd = new SqlCommand("sp_cliente", conexao);
                cmd.CommandType = CommandType.StoredProcedure;

                if (txtCodigoPessoa.Text != "")
                {
                    cmd.Parameters.AddWithValue("@id_pessoa", txtCodigoPessoa.Text);
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
        private void retornarCliente()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Agenda;Data Source=LAB-08-15";
            conexao.Open();

            string comandoSQL = "SELECT * FROM clientes";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            grvPessoa.DataSource = dt;

            conexao.Close();

        }
        private void CadastrarCliente( int id_pessoa, string data_inclusao)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=Agenda;Data Source=LAB-08-15";

            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string InsertClientes = string.Concat("insert into Clientes values ( '", id_pessoa, "','", data_inclusao, "')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertClientes, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }

        private void LimparCampos()
        {
            
            txtCodigoPessoa.Text = "";
            txtDataIn.Text = "";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        { 
           int id_pessoa = Convert.ToInt32(txtCodigoPessoa.Text);
            CadastrarCliente( int.Parse(txtCodigoPessoa.Text), (txtDataIn.Text));
            LimparCampos();
            MessageBox.Show("Registro Cliente", "Etec ZL");
        }

        private void txtNomeMedico_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            retornarCliente();
        }

        private void grvPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoPessoa.Text = grvPessoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDataIn.Text = grvPessoa.Rows[e.RowIndex].Cells[2].Value.ToString();




            MessageBox.Show(grvPessoa.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void grvPessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarClientes();
        }
    }
}
