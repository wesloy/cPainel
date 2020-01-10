using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cPainel.form
{
    public partial class frmCadastro : Form
    {
        //Variavies
        Algar.Utils.Helpers hlp = new Algar.Utils.Helpers();
        Dados oDados = new Dados();
        string camposObrigatorios = "txtAplicativo;txtCaminho;txtInfoAdicional;cbCores";
        public frmPrincipal referencia_formPrincipal = null; //para referenciar form principal

        public frmCadastro()
        {
            InitializeComponent();
        }
        private void frmCadastro_Load(object sender, EventArgs e)
        {
            hlp.limparCampos(this);
            bloqueiaBotoes();
            atualizaListagem();
            ListaCores();            
        } 

        #region Funcoes
        private void liberaBotoes()
        {
            this.btnAlterar.Enabled = true;
            this.btnExcluir.Enabled = true;
            this.btnIncluir.Enabled = false;
            this.btnCancelar.Enabled = true;
        }
        private void bloqueiaBotoes()
        {
            this.btnIncluir.Enabled = true;
            this.btnAlterar.Enabled = false;
            this.btnExcluir.Enabled = false;
        }
        private void ListaCores()
        {
            txtCor.BackColor = Color.White;
            oDados.ListarCores(this, cbCores);
        }
        private void atualizaListagem()
        {
            oDados.CarregaListView(ListView1);
        }
        #endregion

        #region Acoes dos botões        
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (hlp.validaCamposObrigatorios(this, camposObrigatorios))
            {
                //Cria um novo objeto
                oDados = new Dados();
                oDados.Aplicativo = txtAplicativo.Text.Trim();
                oDados.Caminho = txtCaminho.Text.Trim();
                oDados.Obs = txtInfoAdicional.Text.Trim();
                oDados.Rgb = cbCores.Text;
                oDados.Acao = Convert.ToByte(Constants.FlagAcao.Insert);
                //Salva o novo objeto
                if (oDados.Salvar(oDados))
                {
                    hlp.limparCampos(this);
                    atualizaListagem();
                    //MessageBox.Show("Registro salvo com sucesso!", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (hlp.validaCamposObrigatorios(this, camposObrigatorios))
            {
                //Cria um novo objeto
                oDados = new Dados();
                oDados.Id = int.Parse(txtID.Text.ToString());
                oDados.Aplicativo = txtAplicativo.Text.Trim();
                oDados.Caminho = txtCaminho.Text.Trim();
                oDados.Obs = txtInfoAdicional.Text.Trim();
                oDados.Rgb = cbCores.Text;
                oDados.Acao = Convert.ToByte(Constants.FlagAcao.Update);
                //Salva o novo objeto
                if (oDados.Salvar(oDados))
                {
                    hlp.limparCampos(this);
                    atualizaListagem();
                    bloqueiaBotoes();
                    //MessageBox.Show("Registro alterado com sucesso!", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Nenhum registro foi selecionado!", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Tem certeza que deseja remover " + txtAplicativo.Text.Trim() + " do sistema?", Constants.TITULO_ALERTA, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                oDados.Excluir(Convert.ToInt32(txtID.Text.ToString()));
                atualizaListagem();
                hlp.limparCampos(this);
                bloqueiaBotoes();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            hlp.limparCampos(this);
            bloqueiaBotoes();
            lblInfoDeUso.Text = string.Empty;
        }
        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string id = ListView1.SelectedItems[0].SubItems[0].Text;
            if ((string.IsNullOrEmpty(id)) || (id.ToString() == "0"))
            {
                MessageBox.Show("Nenhum registro foi selecionado!", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            oDados = new Dados();
            oDados = oDados.DadosPorID(int.Parse(id.ToString()));
            txtID.Text = oDados.Id.ToString();
            txtAplicativo.Text = oDados.Aplicativo.ToString();
            txtInfoAdicional.Text = oDados.Obs.ToString();
            txtCaminho.Text = oDados.Caminho.ToString();
            cbCores.Text = oDados.Rgb.ToString();
            liberaBotoes();
        }
        private void cbCores_SelectedValueChanged(object sender, EventArgs e)
        {
            string cor = cbCores.Text;
            if ((cor.ToString() != string.Empty) && (cor.ToString() != "System.Data.DataRowView"))
            {
                string valor = cor.ToString();
                char delimiter = ',';
                // Captura a cor RGB cadastrada 
                string[] ArrayRGB = valor.Split(delimiter);
                txtCor.BackColor = Color.FromArgb(int.Parse(ArrayRGB[0].ToString()), int.Parse(ArrayRGB[1].ToString()), int.Parse(ArrayRGB[2].ToString()));

                if (oDados.ValidaCorEmUso(cor.ToString()))
                {
                    lblInfoDeUso.Visible = true;
                    lblInfoDeUso.Text = "em uso!";
                }
                else
                {
                    lblInfoDeUso.Visible = false;
                    lblInfoDeUso.Text = "";
                }
            }
            else
            {
                txtCor.BackColor = Color.White;
            }
        }
        private void xfechar_Click(object sender, EventArgs e)
        {
            hlp.fecharForm(this);
            frmListagemFerramentas frmlist = new frmListagemFerramentas();
            hlp.abrirFormInPanelMDI(frmlist, referencia_formPrincipal, referencia_formPrincipal.panel3, FormBorderStyle.None);
            referencia_formPrincipal.btnAcessoRestrito.Visible = true; //exibir o botão de acesso restrito
            referencia_formPrincipal.btnAcessoCriptografiaSenha.Visible = true; //exibir o botão de acesso restrito
        }
        #endregion
    }
}
