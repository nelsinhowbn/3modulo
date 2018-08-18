using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eleicoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroEleitorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroEleitorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarEleitor tst1 = new CadastrarEleitor();
            tst1.MdiParent = this;
            tst1.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login tst2 = new login();
            tst2.MdiParent = this;
            tst2.Show();
        }

        private void cadastroAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarAluno tst3 = new CadastrarAluno();
            tst3.MdiParent = this;
            tst3.Show();
        }

        private void cadastrarCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCandidato tst4 = new CadastrarCandidato();
            tst4.MdiParent = this;
            tst4.Show();
        }

        private void votarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           votacao tst5 = new votacao();
            tst5.MdiParent = this;
            tst5.Show();
        }
    }
}
