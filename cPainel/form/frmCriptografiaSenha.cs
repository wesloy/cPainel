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
    public partial class frmCriptografiaSenha : Form {

        public frmPrincipal referencia_formPrincipal = null; //para referenciar form principal
        Algar.Utils.Helpers hlp = new Algar.Utils.Helpers();

        public frmCriptografiaSenha() {
            InitializeComponent();
        }

        private void frmCriptografiaSenha_Load(object sender, EventArgs e) {

        }

        private void xfechar_Click(object sender, EventArgs e) {
            hlp.fecharForm(this);
            frmListagemFerramentas frmlist = new frmListagemFerramentas();
            hlp.abrirFormInPanelMDI(frmlist, referencia_formPrincipal, referencia_formPrincipal.panel3, FormBorderStyle.None);
            referencia_formPrincipal.btnAcessoCriptografiaSenha.Visible = true; //exibir o botão de acesso restrito
            referencia_formPrincipal.btnAcessoRestrito.Visible = true; //exibir o botão de acesso restrito
        }

        private void btnCriptografar_Click(object sender, EventArgs e) {
            if (txtEntrada.Text != "") {
                txtSaida.Text = hlp.Encrypt(txtEntrada.Text);
            }
        }

        private void btnDecriptografar_Click(object sender, EventArgs e) {
            if (txtEntrada.Text != "") {
                txtSaida.Text = hlp.Decrypt(txtEntrada.Text);
            }
        }
    }
}
