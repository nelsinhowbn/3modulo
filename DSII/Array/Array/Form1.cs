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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           List<Cliente> lista = new List<Cliente>();
          Cliente cliente1 = new Cliente();
          cliente1.codigoCliente = 1;
          cliente1.nmCliente = "Zé";
          cliente1.DT_NASCIMENTO = Convert.ToDateTime("02/07/2018");
          cliente1.enderecoCliente = "Avenida São Miguel";
          cliente1.telefoneCliente = "98477447";

          lista.Add(cliente1);
             
          Cliente cliente2 = new Cliente();
          cliente2.codigoCliente = 2;
          cliente2.nmCliente = "Epaminhondas";
          cliente2.DT_NASCIMENTO = Convert.ToDateTime ("13/08/2018");
          cliente2.enderecoCliente = "Aguia de Haia";
          cliente2.telefoneCliente = "98227477";

          lista.Add(cliente2);

          dgvClientes.DataSource = lista.Where( i => i.codigoCliente ==1).ToList();
           


          List<ClienteDocumento> listaDoc = new List<ClienteDocumento>();
          ClienteDocumento clientedoc1 = new ClienteDocumento();
          clientedoc1.RG = "03231212351";
          clientedoc1.CPF = "542421221";
          clientedoc1.CLT = "01214212";

          listaDoc.Add(clientedoc1);


          ClienteDocumento clientedoc2 = new ClienteDocumento();
          clientedoc2.RG = "03235512123";
          clientedoc2.CPF = "542444221";
          clientedoc2.CLT = "0129797212";

          listaDoc.Add(clientedoc2);

          dgvDocumento.DataSource = listaDoc;


          List<ClientePedido> listaPedido = new List<ClientePedido>();
          ClientePedido clienteped1 = new ClientePedido();
          clienteped1.codPedido = 1;
          clienteped1.descricaoPedido = "Cor Vermelha";

          listaPedido.Add(clienteped1);

          ClientePedido clienteped2 = new ClientePedido();
          clienteped2.codPedido = 2;
          clienteped2.descricaoPedido = "Cor Branca";

          listaPedido.Add(clienteped2);

          dgvPedido.DataSource = listaPedido;

        }

    }
}
