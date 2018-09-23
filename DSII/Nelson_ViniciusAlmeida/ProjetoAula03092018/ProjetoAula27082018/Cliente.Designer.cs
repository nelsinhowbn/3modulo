namespace teste
{
    partial class Cliente
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
            this.txtDataIn = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodigoPessoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLimparCampos = new System.Windows.Forms.Button();
            this.grvPessoa = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataIn
            // 
            this.txtDataIn.Location = new System.Drawing.Point(108, 90);
            this.txtDataIn.Name = "txtDataIn";
            this.txtDataIn.Size = new System.Drawing.Size(164, 20);
            this.txtDataIn.TabIndex = 19;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 90);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(88, 13);
            this.lblTelefone.TabIndex = 18;
            this.lblTelefone.Text = "Data da Inclusão";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 159);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigoPessoa
            // 
            this.txtCodigoPessoa.Location = new System.Drawing.Point(108, 62);
            this.txtCodigoPessoa.Multiline = true;
            this.txtCodigoPessoa.Name = "txtCodigoPessoa";
            this.txtCodigoPessoa.Size = new System.Drawing.Size(164, 20);
            this.txtCodigoPessoa.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Codigo Pessoa";
            // 
            // BtnLimparCampos
            // 
            this.BtnLimparCampos.Location = new System.Drawing.Point(120, 159);
            this.BtnLimparCampos.Name = "BtnLimparCampos";
            this.BtnLimparCampos.Size = new System.Drawing.Size(75, 23);
            this.BtnLimparCampos.TabIndex = 20;
            this.BtnLimparCampos.Text = "Limpar";
            this.BtnLimparCampos.UseVisualStyleBackColor = true;
            // 
            // grvPessoa
            // 
            this.grvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPessoa.Location = new System.Drawing.Point(32, 228);
            this.grvPessoa.Name = "grvPessoa";
            this.grvPessoa.Size = new System.Drawing.Size(240, 150);
            this.grvPessoa.TabIndex = 21;
            this.grvPessoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPessoa_CellContentClick);
            this.grvPessoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPessoa_CellDoubleClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(211, 159);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 413);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.grvPessoa);
            this.Controls.Add(this.BtnLimparCampos);
            this.Controls.Add(this.txtDataIn);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCodigoPessoa);
            this.Controls.Add(this.label2);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataIn;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodigoPessoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLimparCampos;
        private System.Windows.Forms.DataGridView grvPessoa;
        private System.Windows.Forms.Button btnPesquisar;
    }
}