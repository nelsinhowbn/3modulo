using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;

namespace EtecMetodoGenerics
{
    public partial class CadastrarCliente : Form
    {
        int idcliente = 0;
        
        List<Cliente> listaClientesCadastrados = new List<Cliente>();

        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente clienteCadastro = new Cliente();
            //clienteCadastro.codigoCliente = Convert.ToInt32(txtCodigoCliente.Text);
            clienteCadastro.nmCliente = txtNomeCliente.Text;

            listaClientesCadastrados.Add(clienteCadastro);

        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            InserirCliente();
            
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            gdvPedidos.DataSource = null;
            gdvPedidos.DataSource = listaClientesCadastrados;
        }

        private void InserirCliente()
        {
            //int id = 0 ;
            Cliente cad1 = new Cliente();
            cad1.codigoCliente = idcliente++;
            cad1.nmCliente = txtNomeCliente.Text;

            cad1.dtNascimento = Convert.ToDateTime(txtDtNascimento.Text);
            listaClientesCadastrados.Add(cad1);
        
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           
            List<Cliente> listaPesquisa = new List<Cliente>();
            listaPesquisa = listaClientesCadastrados;

            listaPesquisa = listaPesquisa.Where(i => i.nmCliente.Contains(txtNomeCliente.Text)).ToList();

            gdvPedidos.DataSource = null;
            gdvPedidos.DataSource = listaPesquisa;
        }

        private void gdvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InserirCliente();
            CarregarGrid();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            //txtCodigoCliente.Text = string.Empty;
            txtNomeCliente.Text = "";
            txtDtNascimento.Text = "";
            gdvPedidos.DataSource = null;
            gdvPedidos.DataSource = "";

           // CarregarGrid();
        }
    }
}
