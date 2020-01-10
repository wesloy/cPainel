using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cPainel.form {
    public partial class frmAutenticar : Form {
        Algar.Utils.Helpers hlp = new Algar.Utils.Helpers();
        public frmPrincipal referencia_formPrincipal = null; //para referenciar o formulario principal
        public frmAutenticar() {
            InitializeComponent();
        }
        private void frmAutenticar_Load(object sender, EventArgs e) {
            TextBox1.Text = "";
        }
        private void Button1_Click(object sender, EventArgs e) {
            string pwd = TextBox1.Text;

            if ((pwd != string.Empty) && (pwd == Constants.SENHA_ACESSO) && (cbFerramentas.Text != "")) {
                if (cbFerramentas.Text == "Configuração Painel") {
                    frmCadastro frm = new frmCadastro();
                    hlp.abrirFormInPanelMDI(frm, referencia_formPrincipal, referencia_formPrincipal.panel3, FormBorderStyle.None);
                    frm.referencia_formPrincipal = referencia_formPrincipal;
                    frm.referencia_formPrincipal.btnAcessoRestrito.Visible = false; 
                    frm.referencia_formPrincipal.btnAcessoCriptografiaSenha.Visible = true; 
                } else {
                    frmCriptografiaSenha frm = new frmCriptografiaSenha();
                    hlp.abrirFormInPanelMDI(frm, referencia_formPrincipal, referencia_formPrincipal.panel3, FormBorderStyle.None);
                    frm.referencia_formPrincipal = referencia_formPrincipal;
                    frm.referencia_formPrincipal.btnAcessoCriptografiaSenha.Visible = false; 
                    frm.referencia_formPrincipal.btnAcessoRestrito.Visible = true;
                }

                Close();
            } else {
                MessageBox.Show("Acesso não autorizado.", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAutenticar_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Enter:
                    Button1_Click(sender, e);
                    break;
            }
        }

        public void preencherCombobox(bool confPainel) {
            if (confPainel) {
                cbFerramentas.Text = "Configuração Painel";
            } else {
                cbFerramentas.Text = "Criptografia Senha";
            }
        }
    }
}
