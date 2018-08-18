namespace Array
{
    partial class CadastrarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvClienteCadastrado = new System.Windows.Forms.DataGridView();
            this.Endereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteCadastrado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Cliente";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(108, 31);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(69, 20);
            this.txtCodigoCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(108, 68);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(137, 20);
            this.txtNomeCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Nascimento";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(108, 102);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(137, 20);
            this.txtDataNascimento.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(449, 275);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvClienteCadastrado
            // 
            this.dgvClienteCadastrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteCadastrado.Location = new System.Drawing.Point(16, 205);
            this.dgvClienteCadastrado.Name = "dgvClienteCadastrado";
            this.dgvClienteCadastrado.Size = new System.Drawing.Size(366, 150);
            this.dgvClienteCadastrado.TabIndex = 7;
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.Location = new System.Drawing.Point(16, 130);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(53, 13);
            this.Endereco.TabIndex = 8;
            this.Endereco.Text = "Endereco";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(108, 129);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(137, 20);
            this.txtEndereco.TabIndex = 9;
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 367);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.dgvClienteCadastrado);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarCliente";
            this.Text = "CadastrarCliente";
            this.Load += new System.EventHandler(this.CadastrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteCadastrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvClienteCadastrado;
        private System.Windows.Forms.Label Endereco;
        private System.Windows.Forms.TextBox txtEndereco;
    }
}