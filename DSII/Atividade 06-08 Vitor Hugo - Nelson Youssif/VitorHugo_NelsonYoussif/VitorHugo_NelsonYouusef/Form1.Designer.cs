namespace eleicoes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroEleitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroEleitorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCandidatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroEleitorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroEleitorToolStripMenuItem
            // 
            this.cadastroEleitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.cadastroEleitorToolStripMenuItem1,
            this.cadastroAlunoToolStripMenuItem,
            this.cadastrarCandidatoToolStripMenuItem,
            this.votarToolStripMenuItem});
            this.cadastroEleitorToolStripMenuItem.Name = "cadastroEleitorToolStripMenuItem";
            this.cadastroEleitorToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.cadastroEleitorToolStripMenuItem.Text = "Funcionalidades";
            this.cadastroEleitorToolStripMenuItem.Click += new System.EventHandler(this.cadastroEleitorToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // cadastroEleitorToolStripMenuItem1
            // 
            this.cadastroEleitorToolStripMenuItem1.Name = "cadastroEleitorToolStripMenuItem1";
            this.cadastroEleitorToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.cadastroEleitorToolStripMenuItem1.Text = "Cadastro Eleitor";
            this.cadastroEleitorToolStripMenuItem1.Click += new System.EventHandler(this.cadastroEleitorToolStripMenuItem1_Click);
            // 
            // cadastroAlunoToolStripMenuItem
            // 
            this.cadastroAlunoToolStripMenuItem.Name = "cadastroAlunoToolStripMenuItem";
            this.cadastroAlunoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cadastroAlunoToolStripMenuItem.Text = "Cadastro Aluno";
            this.cadastroAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastroAlunoToolStripMenuItem_Click);
            // 
            // cadastrarCandidatoToolStripMenuItem
            // 
            this.cadastrarCandidatoToolStripMenuItem.Name = "cadastrarCandidatoToolStripMenuItem";
            this.cadastrarCandidatoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cadastrarCandidatoToolStripMenuItem.Text = "Cadastrar Candidato";
            this.cadastrarCandidatoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCandidatoToolStripMenuItem_Click);
            // 
            // votarToolStripMenuItem
            // 
            this.votarToolStripMenuItem.Name = "votarToolStripMenuItem";
            this.votarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.votarToolStripMenuItem.Text = "Votar";
            this.votarToolStripMenuItem.Click += new System.EventHandler(this.votarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(621, 526);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroEleitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroEleitorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCandidatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votarToolStripMenuItem;
    }
}

