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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void carregarFunc()
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

                SqlCommand cmd = new SqlCommand("sp_funcionario", conexao);
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

        private void retornarFunc()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Agenda;Data Source=LAB-06-11";
            conexao.Open();

            string comandoSQL = "SELECT * FROM funcionario";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            grvPessoa.DataSource = dt;

            conexao.Close();

        }
        private void CadastrarFuncionario(int id_pessoa, string cargo, string salario, int ramal_empresa)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=Agenda;Data Source=LAB-08-15";

            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            string InsertFuncionario = string.Concat("insert into Funcionario values ( '", id_pessoa, "','", cargo, "','", salario, "','", ramal_empresa, "')");

            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(InsertFuncionario, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }

        private void LimparCampos()
        {
            
            txtCodigoPessoa.Text = "";
            txtCargo.Text = "";
            txtRamal.Text = "";
            txtSalario.Text = "";
          
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int id_pessoa = Convert.ToInt32(txtCodigoPessoa.Text);

            int ramal_empresa = Convert.ToInt32(txtRamal.Text);


            CadastrarFuncionario(id_pessoa, txtCargo.Text, txtSalario.Text, ramal_empresa);
            LimparCampos();
            MessageBox.Show("Registro Funcionario", "Etec ZL");
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            retornarFunc();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void grvPessoa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoPessoa.Text = grvPessoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCargo.Text = grvPessoa.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRamal.Text =  grvPessoa.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSalario.Text = grvPessoa.Rows[e.RowIndex].Cells[4].Value.ToString();
         


            MessageBox.Show(grvPessoa.Rows[e.RowIndex].Cells[0].Value.ToString());
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarFunc();
        }
    }
}
