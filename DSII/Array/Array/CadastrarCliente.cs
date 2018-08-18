    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Classes;

namespace Array
{
    public partial class CadastrarCliente : Form
    {
        List<Cliente> listaClientesCadastrados = new List<Cliente>();
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente clientesCadastrados = new Cliente();
            clientesCadastrados.codigoCliente = Convert.ToInt32(txtCodigoCliente.Text);
            clientesCadastrados.nmCliente = txtNomeCliente.Text;
            clientesCadastrados.DT_NASCIMENTO = Convert.ToDateTime(txtDataNascimento.Text);
            clientesCadastrados.enderecoCliente = txtEndereco.Text;
            listaClientesCadastrados.Add(clientesCadastrados);

            //dgvClienteCadastrado = null;
            dgvClienteCadastrado.DataSource = listaClientesCadastrados;
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }


    }
}
