using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace cPainel.form
{
    public partial class frmPrincipal : Form
    {
        //Variaveis Uteis
        private Dados oDados = new Dados();
        Algar.Utils.Helpers hlp = new Algar.Utils.Helpers();

        //Tempo para sessão expirar
        private DateTime dt = DateTime.Now;
        private DateTime dtFim = DateTime.Now.AddMinutes(Convert.ToInt32(Constants.TIMEOUT));

        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lbTitulo.Parent = PictureBox1;            
            lblAcessos.Text = oDados.QtdAcessosHoje().ToString();
            lblVersao.Text = "v " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lbCreditos.Text = "Desenvolvido por: " + Constants.CREDITOS.ToString();
            lblInfoLogin.Text = "     " + hlp.exibeMensagemDoDia() + ", " + Environment.UserName.ToString();

            frmListagemFerramentas listaFerramentas = new frmListagemFerramentas();
            hlp.abrirFormInPanelMDI(listaFerramentas, this, panel3, FormBorderStyle.None);
        }
        private void btnAcessoRestrito_Click(object sender, EventArgs e)
        {

            frmAutenticar frm = new frmAutenticar();
            this.TopMost = false;
            frm.referencia_formPrincipal = this; //referenciar formulario principal
            frm.preencherCombobox(true);
            hlp.abrirForm(frm, true);
        }

        private void btnAcessoCriptografiaSenha_Click(object sender, EventArgs e) {
            frmAutenticar frm = new frmAutenticar();
            this.TopMost = false;
            frm.referencia_formPrincipal = this; //referenciar formulario principal
            frm.preencherCombobox(false);
            hlp.abrirForm(frm, true);
        }
    }
}

