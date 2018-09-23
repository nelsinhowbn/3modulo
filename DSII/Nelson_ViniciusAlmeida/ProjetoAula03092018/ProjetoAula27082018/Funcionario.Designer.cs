namespace teste
{
    partial class Funcionario
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.txtRamal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.grvPessoa = new System.Windows.Forms.DataGridView();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtCodigoPessoa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 184);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(118, 184);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(75, 23);
            this.btnLimparCampos.TabIndex = 21;
            this.btnLimparCampos.Text = "Limpar";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Codigo Pessoa";
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.Location = new System.Drawing.Point(23, 63);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(35, 13);
            this.Cargo.TabIndex = 18;
            this.Cargo.Text = "Cargo";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(23, 89);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(96, 13);
            this.lblSal.TabIndex = 17;
            this.lblSal.Text = "Ramal da Empresa";
            // 
            // txtRamal
            // 
            this.txtRamal.Location = new System.Drawing.Point(137, 89);
            this.txtRamal.Multiline = true;
            this.txtRamal.Name = "txtRamal";
            this.txtRamal.Size = new System.Drawing.Size(164, 20);
            this.txtRamal.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(137, 116);
            this.txtSalario.Multiline = true;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(164, 20);
            this.txtSalario.TabIndex = 23;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // grvPessoa
            // 
            this.grvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPessoa.Location = new System.Drawing.Point(29, 274);
            this.grvPessoa.Name = "grvPessoa";
            this.grvPessoa.Size = new System.Drawing.Size(249, 150);
            this.grvPessoa.TabIndex = 24;
            this.grvPessoa.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPessoa_CellContentDoubleClick);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(137, 63);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(164, 20);
            this.txtCargo.TabIndex = 19;
            // 
            // txtCodigoPessoa
            // 
            this.txtCodigoPessoa.Location = new System.Drawing.Point(137, 35);
            this.txtCodigoPessoa.Name = "txtCodigoPessoa";
            this.txtCodigoPessoa.Size = new System.Drawing.Size(164, 20);
            this.txtCodigoPessoa.TabIndex = 25;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(226, 184);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 26;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 481);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtCodigoPessoa);
            this.Controls.Add(this.grvPessoa);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.txtRamal);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Name = "Funcionario";
            this.ShowIcon = false;
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.TextBox txtRamal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.DataGridView grvPessoa;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtCodigoPessoa;
        private System.Windows.Forms.Button btnPesquisar;
    }
}