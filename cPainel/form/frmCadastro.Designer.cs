namespace cPainel.form
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.lblInfoDeUso = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.cbCores = new System.Windows.Forms.ComboBox();
            this.txtInfoAdicional = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.txtAplicativo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.xfechar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.xfechar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoDeUso
            // 
            this.lblInfoDeUso.AutoSize = true;
            this.lblInfoDeUso.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoDeUso.Location = new System.Drawing.Point(242, 152);
            this.lblInfoDeUso.Name = "lblInfoDeUso";
            this.lblInfoDeUso.Size = new System.Drawing.Size(40, 13);
            this.lblInfoDeUso.TabIndex = 61;
            this.lblInfoDeUso.Text = "{INFO}";
            this.lblInfoDeUso.Visible = false;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Location = new System.Drawing.Point(12, 151);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 13);
            this.Label5.TabIndex = 60;
            this.Label5.Text = "BackColor:";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(201, 148);
            this.txtCor.Name = "txtCor";
            this.txtCor.ReadOnly = true;
            this.txtCor.Size = new System.Drawing.Size(35, 20);
            this.txtCor.TabIndex = 54;
            // 
            // cbCores
            // 
            this.cbCores.FormattingEnabled = true;
            this.cbCores.Location = new System.Drawing.Point(83, 147);
            this.cbCores.Name = "cbCores";
            this.cbCores.Size = new System.Drawing.Size(112, 21);
            this.cbCores.TabIndex = 48;
            this.cbCores.SelectedValueChanged += new System.EventHandler(this.cbCores_SelectedValueChanged);
            // 
            // txtInfoAdicional
            // 
            this.txtInfoAdicional.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfoAdicional.Location = new System.Drawing.Point(83, 75);
            this.txtInfoAdicional.Name = "txtInfoAdicional";
            this.txtInfoAdicional.Size = new System.Drawing.Size(435, 20);
            this.txtInfoAdicional.TabIndex = 46;
            this.txtInfoAdicional.Tag = "Obs";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(12, 79);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(73, 13);
            this.Label4.TabIndex = 59;
            this.Label4.Text = "Observações:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlterar.Location = new System.Drawing.Point(188, 174);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 30);
            this.btnAlterar.TabIndex = 50;
            this.btnAlterar.Tag = "Alterar";
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCaminho.Location = new System.Drawing.Point(83, 95);
            this.txtCaminho.Multiline = true;
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(435, 50);
            this.txtCaminho.TabIndex = 47;
            this.txtCaminho.Tag = "Caminho";
            // 
            // txtAplicativo
            // 
            this.txtAplicativo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAplicativo.Location = new System.Drawing.Point(83, 55);
            this.txtAplicativo.Name = "txtAplicativo";
            this.txtAplicativo.Size = new System.Drawing.Size(434, 20);
            this.txtAplicativo.TabIndex = 45;
            this.txtAplicativo.Tag = "Aplicativo";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(83, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(434, 20);
            this.txtID.TabIndex = 44;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(350, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "   Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcluir.Location = new System.Drawing.Point(269, 174);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 30);
            this.btnExcluir.TabIndex = 51;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIncluir.Location = new System.Drawing.Point(107, 174);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 30);
            this.btnIncluir.TabIndex = 49;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // ListView1
            // 
            this.ListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView1.Location = new System.Drawing.Point(4, 222);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(521, 101);
            this.ListView1.TabIndex = 53;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseDoubleClick);
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Location = new System.Drawing.Point(12, 111);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(73, 13);
            this.Label8.TabIndex = 57;
            this.Label8.Text = "Caminho:";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(12, 59);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 13);
            this.Label2.TabIndex = 56;
            this.Label2.Text = "Ferramenta:";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(12, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(73, 13);
            this.Label1.TabIndex = 55;
            this.Label1.Text = "ID:";
            // 
            // xfechar
            // 
            this.xfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xfechar.BackColor = System.Drawing.Color.Transparent;
            this.xfechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xfechar.Image = ((System.Drawing.Image)(resources.GetObject("xfechar.Image")));
            this.xfechar.Location = new System.Drawing.Point(490, 13);
            this.xfechar.Name = "xfechar";
            this.xfechar.Size = new System.Drawing.Size(26, 19);
            this.xfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.xfechar.TabIndex = 108;
            this.xfechar.TabStop = false;
            this.xfechar.Tag = "Fechar";
            this.xfechar.Click += new System.EventHandler(this.xfechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 211);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 326);
            this.Controls.Add(this.xfechar);
            this.Controls.Add(this.lblInfoDeUso);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.cbCores);
            this.Controls.Add(this.txtInfoAdicional);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.txtAplicativo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestão de ferramentas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xfechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblInfoDeUso;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtCor;
        internal System.Windows.Forms.ComboBox cbCores;
        internal System.Windows.Forms.TextBox txtInfoAdicional;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnAlterar;
        internal System.Windows.Forms.TextBox txtCaminho;
        internal System.Windows.Forms.TextBox txtAplicativo;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.Button btnIncluir;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox xfechar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}