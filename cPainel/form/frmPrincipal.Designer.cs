namespace cPainel.form
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.photoList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.btnAcessoRestrito = new System.Windows.Forms.PictureBox();
            this.lblInfoLogin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblAcessos = new System.Windows.Forms.Label();
            this.lbCreditos = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAcessoCriptografiaSenha = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcessoRestrito)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcessoCriptografiaSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // photoList
            // 
            this.photoList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.photoList.ImageSize = new System.Drawing.Size(16, 16);
            this.photoList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAcessoCriptografiaSenha);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.PictureBox1);
            this.panel1.Controls.Add(this.lblVersao);
            this.panel1.Controls.Add(this.btnAcessoRestrito);
            this.panel1.Controls.Add(this.lblInfoLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 83);
            this.panel1.TabIndex = 40;
            // 
            // lbTitulo
            // 
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lbTitulo.Location = new System.Drawing.Point(341, 13);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(238, 27);
            this.lbTitulo.TabIndex = 41;
            this.lbTitulo.Text = "Painel de Ferramentas";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(584, 58);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 42;
            this.PictureBox1.TabStop = false;
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.lblVersao.ForeColor = System.Drawing.Color.Silver;
            this.lblVersao.Location = new System.Drawing.Point(457, 60);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(56, 21);
            this.lblVersao.TabIndex = 43;
            this.lblVersao.Text = "{Versão}";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAcessoRestrito
            // 
            this.btnAcessoRestrito.BackColor = System.Drawing.Color.Transparent;
            this.btnAcessoRestrito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcessoRestrito.BackgroundImage")));
            this.btnAcessoRestrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAcessoRestrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcessoRestrito.Location = new System.Drawing.Point(519, 60);
            this.btnAcessoRestrito.Name = "btnAcessoRestrito";
            this.btnAcessoRestrito.Size = new System.Drawing.Size(28, 21);
            this.btnAcessoRestrito.TabIndex = 45;
            this.btnAcessoRestrito.TabStop = false;
            this.btnAcessoRestrito.Click += new System.EventHandler(this.btnAcessoRestrito_Click);
            // 
            // lblInfoLogin
            // 
            this.lblInfoLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfoLogin.Image = ((System.Drawing.Image)(resources.GetObject("lblInfoLogin.Image")));
            this.lblInfoLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfoLogin.Location = new System.Drawing.Point(4, 60);
            this.lblInfoLogin.Name = "lblInfoLogin";
            this.lblInfoLogin.Size = new System.Drawing.Size(384, 15);
            this.lblInfoLogin.TabIndex = 40;
            this.lblInfoLogin.Text = "     {Info Login}";
            this.lblInfoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.Label8);
            this.panel2.Controls.Add(this.lblAcessos);
            this.panel2.Controls.Add(this.lbCreditos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 31);
            this.panel2.TabIndex = 41;
            // 
            // Label8
            // 
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(5, 7);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(142, 19);
            this.Label8.TabIndex = 47;
            this.Label8.Text = "Nº de acessos de hoje:";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcessos
            // 
            this.lblAcessos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAcessos.AutoSize = true;
            this.lblAcessos.BackColor = System.Drawing.Color.Transparent;
            this.lblAcessos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAcessos.ForeColor = System.Drawing.Color.Black;
            this.lblAcessos.Location = new System.Drawing.Point(145, 7);
            this.lblAcessos.Name = "lblAcessos";
            this.lblAcessos.Size = new System.Drawing.Size(33, 19);
            this.lblAcessos.TabIndex = 46;
            this.lblAcessos.Text = "250";
            this.lblAcessos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCreditos
            // 
            this.lbCreditos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbCreditos.BackColor = System.Drawing.Color.Transparent;
            this.lbCreditos.Font = new System.Drawing.Font("Segoe UI Light", 9.25F);
            this.lbCreditos.ForeColor = System.Drawing.Color.Black;
            this.lbCreditos.Location = new System.Drawing.Point(325, 7);
            this.lbCreditos.Name = "lbCreditos";
            this.lbCreditos.Size = new System.Drawing.Size(254, 19);
            this.lbCreditos.TabIndex = 44;
            this.lbCreditos.Text = "{Creditos}";
            this.lbCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 394);
            this.panel3.TabIndex = 42;
            // 
            // btnAcessoCriptografiaSenha
            // 
            this.btnAcessoCriptografiaSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnAcessoCriptografiaSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcessoCriptografiaSenha.BackgroundImage")));
            this.btnAcessoCriptografiaSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAcessoCriptografiaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcessoCriptografiaSenha.Location = new System.Drawing.Point(551, 60);
            this.btnAcessoCriptografiaSenha.Name = "btnAcessoCriptografiaSenha";
            this.btnAcessoCriptografiaSenha.Size = new System.Drawing.Size(28, 21);
            this.btnAcessoCriptografiaSenha.TabIndex = 46;
            this.btnAcessoCriptografiaSenha.TabStop = false;
            this.btnAcessoCriptografiaSenha.Click += new System.EventHandler(this.btnAcessoCriptografiaSenha_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 508);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcessoRestrito)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcessoCriptografiaSenha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList photoList;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label lbTitulo;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label lblInfoLogin;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label lblAcessos;
        internal System.Windows.Forms.Label lblVersao;
        internal System.Windows.Forms.PictureBox btnAcessoRestrito;
        internal System.Windows.Forms.Label lbCreditos;
        public System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.PictureBox btnAcessoCriptografiaSenha;
    }
}

