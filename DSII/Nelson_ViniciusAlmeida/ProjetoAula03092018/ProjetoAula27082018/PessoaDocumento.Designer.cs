namespace teste
{
    partial class PessoaDocumento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CLT = new System.Windows.Forms.Label();
            this.rSERV = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.RG = new System.Windows.Forms.Label();
            this.CNH = new System.Windows.Forms.Label();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.grvPessoa = new System.Windows.Forms.DataGridView();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtCnh = new System.Windows.Forms.TextBox();
            this.txtReserv = new System.Windows.Forms.TextBox();
            this.txtClt = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // CLT
            // 
            this.CLT.AutoSize = true;
            this.CLT.Location = new System.Drawing.Point(13, 119);
            this.CLT.Name = "CLT";
            this.CLT.Size = new System.Drawing.Size(103, 13);
            this.CLT.TabIndex = 21;
            this.CLT.Text = "Carteira de Trabalho";
            // 
            // rSERV
            // 
            this.rSERV.AutoSize = true;
            this.rSERV.Location = new System.Drawing.Point(27, 90);
            this.rSERV.Name = "rSERV";
            this.rSERV.Size = new System.Drawing.Size(57, 13);
            this.rSERV.TabIndex = 17;
            this.rSERV.Text = "Reservista";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Location = new System.Drawing.Point(27, 64);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(27, 13);
            this.CPF.TabIndex = 18;
            this.CPF.Text = "CPF";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(48, 204);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(122, 36);
            this.txtRg.Multiline = true;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(164, 20);
            this.txtRg.TabIndex = 15;
            // 
            // RG
            // 
            this.RG.AutoSize = true;
            this.RG.Location = new System.Drawing.Point(27, 36);
            this.RG.Name = "RG";
            this.RG.Size = new System.Drawing.Size(23, 13);
            this.RG.TabIndex = 12;
            this.RG.Text = "RG";
            // 
            // CNH
            // 
            this.CNH.AutoSize = true;
            this.CNH.Location = new System.Drawing.Point(24, 142);
            this.CNH.Name = "CNH";
            this.CNH.Size = new System.Drawing.Size(30, 13);
            this.CNH.TabIndex = 24;
            this.CNH.Text = "CNH";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(170, 204);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(75, 23);
            this.btnLimparCampos.TabIndex = 26;
            this.btnLimparCampos.Text = "Limpar";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // grvPessoa
            // 
            this.grvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPessoa.Location = new System.Drawing.Point(46, 277);
            this.grvPessoa.Name = "grvPessoa";
            this.grvPessoa.Size = new System.Drawing.Size(378, 210);
            this.grvPessoa.TabIndex = 27;
            this.grvPessoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPessoa_CellContentClick);
            this.grvPessoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPessoa_CellDoubleClick);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(122, 63);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(164, 20);
            this.txtCpf.TabIndex = 28;
            // 
            // txtCnh
            // 
            this.txtCnh.Location = new System.Drawing.Point(122, 142);
            this.txtCnh.Name = "txtCnh";
            this.txtCnh.Size = new System.Drawing.Size(164, 20);
            this.txtCnh.TabIndex = 29;
            // 
            // txtReserv
            // 
            this.txtReserv.Location = new System.Drawing.Point(122, 90);
            this.txtReserv.Name = "txtReserv";
            this.txtReserv.Size = new System.Drawing.Size(164, 20);
            this.txtReserv.TabIndex = 31;
            // 
            // txtClt
            // 
            this.txtClt.Location = new System.Drawing.Point(123, 117);
            this.txtClt.Name = "txtClt";
            this.txtClt.Size = new System.Drawing.Size(163, 20);
            this.txtClt.TabIndex = 32;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(299, 204);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 33;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // PessoaDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 612);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtClt);
            this.Controls.Add(this.txtReserv);
            this.Controls.Add(this.txtCnh);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.grvPessoa);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.CNH);
            this.Controls.Add(this.CLT);
            this.Controls.Add(this.rSERV);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.RG);
            this.Name = "PessoaDocumento";
            this.Text = "Pessoa Documento";
            this.Load += new System.EventHandler(this.PessoaDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CLT;
        private System.Windows.Forms.Label rSERV;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label RG;
        private System.Windows.Forms.Label CNH;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.DataGridView grvPessoa;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtCnh;
        private System.Windows.Forms.TextBox txtReserv;
        private System.Windows.Forms.TextBox txtClt;
        private System.Windows.Forms.Button btnPesquisar;
    }
}