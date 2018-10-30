using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Funcionario.cs
{
    public partial class Form1 : Form
    {   
        private List<ClasseFuncionario> listaMemoria = new List<ClasseFuncionario>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarComboFuncionario();

        }

        private void carregarComboFuncionario() {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoBD;
            conexao.Open();


            string comandoSQL = "SELECT * FROM tbFuncionario";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);

            DataTable dtFuncionariosBD = new DataTable();

            sda.Fill(dtFuncionariosBD);

            comboSelect.DataSource = dtFuncionariosBD;

            comboSelect.DisplayMember = "nmFunc";




            conexao.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClasseFuncionario funcionario = new ClasseFuncionario();
            funcionario.nmFunc = txtNome.Text;
            funcionario.cargo = txtCargo.Text;
            funcionario.endFunc = txtEnd.Text;
            funcionario.dtNasc = txtData.Text;

            listaMemoria.Add(funcionario);

            dgvFuncionarioMemoria.DataSource=null;
            dgvFuncionarioMemoria.DataSource = listaMemoria;
        }

        private void btnPendencias_Click(object sender, EventArgs e)
        {

            foreach (ClasseFuncionario item in listaMemoria)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = Program.conexaoBD;
                conexao.Open();

                string comandoSQL = "insert into tbFuncionario (nmFunc, cargo, endFunc, dtNasc  ) values ('" + item.nmFunc+ "','" + item.cargo +"','" + item.endFunc + "','" + item.dtNasc + "') ";

                SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

                sqlCommand.ExecuteNonQuery();

                conexao.Close();

                listaMemoria = new List<ClasseFuncionario>();
                dgvFuncionarioMemoria.DataSource = null;
                MessageBox.Show("ADICIONADO COM SUCESSO!");
            }

            carregarComboFuncionario();




        }

        private void comboSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
