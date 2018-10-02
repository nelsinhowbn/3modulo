namespace DS.Project.View
{
    partial class frmCadastroAluno
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
            this.txtNmAluno = new System.Windows.Forms.TextBox();
            this.txtEndAluno = new System.Windows.Forms.TextBox();
            this.txtCepAluno = new System.Windows.Forms.TextBox();
            this.txtEmailAluno = new System.Windows.Forms.TextBox();
            this.txtNmrAluno = new System.Windows.Forms.TextBox();
            this.txtNmrFixoAluno = new System.Windows.Forms.TextBox();
            this.lblNmAluno = new System.Windows.Forms.Label();
            this.lblEndAluno = new System.Windows.Forms.Label();
            this.lblCepAluno = new System.Windows.Forms.Label();
            this.lblEmailAluno = new System.Windows.Forms.Label();
            this.lblNmrAluno = new System.Windows.Forms.Label();
            this.lblNmrFixoAluno = new System.Windows.Forms.Label();
            this.lblDtaNascimento = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.dtpDtaNascimento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNmAluno
            // 
            this.txtNmAluno.Location = new System.Drawing.Point(25, 40);
            this.txtNmAluno.Name = "txtNmAluno";
            this.txtNmAluno.Size = new System.Drawing.Size(262, 20);
            this.txtNmAluno.TabIndex = 0;
            // 
            // txtEndAluno
            // 
            this.txtEndAluno.Location = new System.Drawing.Point(25, 96);
            this.txtEndAluno.Name = "txtEndAluno";
            this.txtEndAluno.Size = new System.Drawing.Size(262, 20);
            this.txtEndAluno.TabIndex = 1;
            // 
            // txtCepAluno
            // 
            this.txtCepAluno.Location = new System.Drawing.Point(25, 154);
            this.txtCepAluno.Name = "txtCepAluno";
            this.txtCepAluno.Size = new System.Drawing.Size(262, 20);
            this.txtCepAluno.TabIndex = 2;
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.Location = new System.Drawing.Point(25, 209);
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.Size = new System.Drawing.Size(262, 20);
            this.txtEmailAluno.TabIndex = 3;
            // 
            // txtNmrAluno
            // 
            this.txtNmrAluno.Location = new System.Drawing.Point(25, 262);
            this.txtNmrAluno.Name = "txtNmrAluno";
            this.txtNmrAluno.Size = new System.Drawing.Size(262, 20);
            this.txtNmrAluno.TabIndex = 4;
            // 
            // txtNmrFixoAluno
            // 
            this.txtNmrFixoAluno.Location = new System.Drawing.Point(25, 317);
            this.txtNmrFixoAluno.Name = "txtNmrFixoAluno";
            this.txtNmrFixoAluno.Size = new System.Drawing.Size(262, 20);
            this.txtNmrFixoAluno.TabIndex = 5;
            // 
            // lblNmAluno
            // 
            this.lblNmAluno.AutoSize = true;
            this.lblNmAluno.Location = new System.Drawing.Point(25, 21);
            this.lblNmAluno.Name = "lblNmAluno";
            this.lblNmAluno.Size = new System.Drawing.Size(38, 13);
            this.lblNmAluno.TabIndex = 7;
            this.lblNmAluno.Text = "Nome:";
            // 
            // lblEndAluno
            // 
            this.lblEndAluno.AutoSize = true;
            this.lblEndAluno.Location = new System.Drawing.Point(25, 80);
            this.lblEndAluno.Name = "lblEndAluno";
            this.lblEndAluno.Size = new System.Drawing.Size(56, 13);
            this.lblEndAluno.TabIndex = 8;
            this.lblEndAluno.Text = "Endereço:";
            // 
            // lblCepAluno
            // 
            this.lblCepAluno.AutoSize = true;
            this.lblCepAluno.Location = new System.Drawing.Point(25, 138);
            this.lblCepAluno.Name = "lblCepAluno";
            this.lblCepAluno.Size = new System.Drawing.Size(29, 13);
            this.lblCepAluno.TabIndex = 9;
            this.lblCepAluno.Text = "Cep:";
            // 
            // lblEmailAluno
            // 
            this.lblEmailAluno.AutoSize = true;
            this.lblEmailAluno.Location = new System.Drawing.Point(25, 193);
            this.lblEmailAluno.Name = "lblEmailAluno";
            this.lblEmailAluno.Size = new System.Drawing.Size(35, 13);
            this.lblEmailAluno.TabIndex = 10;
            this.lblEmailAluno.Text = "Email:";
            // 
            // lblNmrAluno
            // 
            this.lblNmrAluno.AutoSize = true;
            this.lblNmrAluno.Location = new System.Drawing.Point(25, 246);
            this.lblNmrAluno.Name = "lblNmrAluno";
            this.lblNmrAluno.Size = new System.Drawing.Size(47, 13);
            this.lblNmrAluno.TabIndex = 11;
            this.lblNmrAluno.Text = "Número:";
            // 
            // lblNmrFixoAluno
            // 
            this.lblNmrFixoAluno.AutoSize = true;
            this.lblNmrFixoAluno.Location = new System.Drawing.Point(22, 301);
            this.lblNmrFixoAluno.Name = "lblNmrFixoAluno";
            this.lblNmrFixoAluno.Size = new System.Drawing.Size(69, 13);
            this.lblNmrFixoAluno.TabIndex = 12;
            this.lblNmrFixoAluno.Text = "Número Fixo:";
            // 
            // lblDtaNascimento
            // 
            this.lblDtaNascimento.AutoSize = true;
            this.lblDtaNascimento.Location = new System.Drawing.Point(28, 348);
            this.lblDtaNascimento.Name = "lblDtaNascimento";
            this.lblDtaNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDtaNascimento.TabIndex = 13;
            this.lblDtaNascimento.Text = "Data de Nascimento:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(100, 413);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(85, 26);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(333, 40);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(357, 20);
            this.txtPesquisa.TabIndex = 16;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(339, 21);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 17;
            this.lblPesquisar.Text = "Pesquisa:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(706, 40);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(333, 96);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(448, 343);
            this.dgvAluno.TabIndex = 19;
            // 
            // dtpDtaNascimento
            // 
            this.dtpDtaNascimento.Location = new System.Drawing.Point(28, 377);
            this.dtpDtaNascimento.Name = "dtpDtaNascimento";
            this.dtpDtaNascimento.Size = new System.Drawing.Size(259, 20);
            this.dtpDtaNascimento.TabIndex = 20;
            // 
            // frmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 452);
            this.Controls.Add(this.dtpDtaNascimento);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblDtaNascimento);
            this.Controls.Add(this.lblNmrFixoAluno);
            this.Controls.Add(this.lblNmrAluno);
            this.Controls.Add(this.lblEmailAluno);
            this.Controls.Add(this.lblCepAluno);
            this.Controls.Add(this.lblEndAluno);
            this.Controls.Add(this.lblNmAluno);
            this.Controls.Add(this.txtNmrFixoAluno);
            this.Controls.Add(this.txtNmrAluno);
            this.Controls.Add(this.txtEmailAluno);
            this.Controls.Add(this.txtCepAluno);
            this.Controls.Add(this.txtEndAluno);
            this.Controls.Add(this.txtNmAluno);
            this.Name = "frmCadastroAluno";
            this.Text = "Cadastro Aluno:";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNmAluno;
        private System.Windows.Forms.TextBox txtEndAluno;
        private System.Windows.Forms.TextBox txtCepAluno;
        private System.Windows.Forms.TextBox txtEmailAluno;
        private System.Windows.Forms.TextBox txtNmrAluno;
        private System.Windows.Forms.TextBox txtNmrFixoAluno;
        private System.Windows.Forms.Label lblNmAluno;
        private System.Windows.Forms.Label lblEndAluno;
        private System.Windows.Forms.Label lblCepAluno;
        private System.Windows.Forms.Label lblEmailAluno;
        private System.Windows.Forms.Label lblNmrAluno;
        private System.Windows.Forms.Label lblNmrFixoAluno;
        private System.Windows.Forms.Label lblDtaNascimento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.DateTimePicker dtpDtaNascimento;
    }
}

