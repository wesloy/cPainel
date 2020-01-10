using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace cPainel.form
{
    public partial class frmListagemFerramentas : Form
    {
        //Variaveis Uteis
        private Font fBold = new Font("Segoe UI", 8, FontStyle.Bold | FontStyle.Regular);
        private Font fNormal = new Font("Segoe UI", 8, FontStyle.Regular);
        private Font fNormalSublinhado = new Font("Segoe UI", 8, FontStyle.Bold | FontStyle.Regular); // FontStyle.Bold Or FontStyle.Regular
        private Dados oDados = new Dados();
        Algar.Utils.Helpers hlp = new Algar.Utils.Helpers();
        private Log log = new Log();

        public frmListagemFerramentas()
        {
            InitializeComponent();
        }
        private void frmListagemFerramentas_Load(object sender, EventArgs e)
        {
            criaItensMenu(this);
        }
        #region Menu hover
        public void hover_on(object sender, EventArgs e)
        {
            (sender as Label).Font = fNormalSublinhado;
            (sender as Label).BorderStyle = BorderStyle.None;

            (sender as Label).Image = Image.FromFile(Constants.PATH_ICONS.ToString() + Path.DirectorySeparatorChar + "bgItem1.png");
            (sender as Label).ImageAlign = ContentAlignment.TopCenter;
        }
        public void hover_off(object sender, EventArgs e)
        {
            (sender as Label).Font = fNormal;
            (sender as Label).BorderStyle = BorderStyle.None;

            (sender as Label).Image = null;
            (sender as Label).ImageAlign = ContentAlignment.TopCenter;
        }
        #endregion

        #region Funcoes
        public void criaItensMenu(Form frm)
        {
            DataTable dt = new DataTable();
            long i = 1;
            long posicaoInicial_x = 10;
            long posicaoInicial_y = 10; //87
            long largura = 90;
            long altura = 90;
            long margin = 5;
            long qtdMenuPorLinha = 1;
            long limiteMenuporLinha = 6;
            long totalItens = 0;
            Label lbMenu = null;
            ToolTip toolTip1;

            // Busca as ferramentas cadastradas
            dt = oDados.ListarApp();
            totalItens = dt.Rows.Count;

            // ***********************************************************************************
            // Percorrendo todas as labels, caso existam
            // para recriar os menus em runtime
            frm.Refresh();
            if (panel3.Controls.Count > 0)
            {
                foreach (Control c in panel3.Controls)
                {
                    //Remove todas as labels dentro do panel3
                    c.Dispose();
                }
            }
            frm.Refresh();
            // ***********************************************************************************

            if (dt.Rows.Count > 0)
            {

                foreach (DataRow drRow in dt.Rows) // efetua o loop até o fim
                {
                    string valor = drRow["rgb"].ToString();
                    // Captura a cor RGB cadastrada 
                    string[] ArrayRGB = valor.Split(',');
                    // Cria dinamicamente os itens
                    lbMenu = new Label();
                    // Configuração do Tooltip
                    toolTip1 = new ToolTip();
                    toolTip1.IsBalloon = true;
                    toolTip1.UseAnimation = true;
                    toolTip1.UseFading = true;

                    lbMenu.BringToFront(); // .SendToBack()
                    lbMenu.Name = i.ToString();
                    lbMenu.Visible = true;
                    // .Text = Strings.StrConv(drRow("aplicativo"), VbStrConv.ProperCase) ' VbStrConv.ProperCase
                    lbMenu.Text = drRow["aplicativo"].ToString();
                    lbMenu.Cursor = Cursors.Hand;

                    if (ArrayRGB.Length == 0)
                    {
                        lbMenu.BackColor = Color.Aquamarine;
                    }
                    else
                    {
                        lbMenu.BackColor = Color.FromArgb(int.Parse(ArrayRGB[0].ToString()), int.Parse(ArrayRGB[1].ToString()), int.Parse(ArrayRGB[2].ToString()));// Color.FromArgb(0, 112, 192)

                        lbMenu.BorderStyle = BorderStyle.None;

                        //imagem background
                        //lbMenu.Image = Image.FromFile(@"C:\Users\a058572\Documents\svn_root\cPainel\cPainel\imagens\bgItem1.png"); 
                        //lbMenu.ImageAlign = ContentAlignment.TopCenter;                       
                        //fim imagens

                        lbMenu.Location = new System.Drawing.Point(int.Parse(posicaoInicial_x.ToString()), int.Parse(posicaoInicial_y.ToString()));
                        lbMenu.Size = new System.Drawing.Size(int.Parse(largura.ToString()), int.Parse(altura.ToString()));
                        lbMenu.TextAlign = ContentAlignment.MiddleCenter;
                        lbMenu.Font = fNormal;
                        lbMenu.ForeColor = Color.White;

                        panel3.Controls.Add(lbMenu);
                        //configuração do Tootip para cada item de menu
                        //toolTip1.ToolTipTitle = drRow["aplicativo"].ToString();// 'titulo
                        toolTip1.SetToolTip(lbMenu, drRow["aplicativo"].ToString());
                        //toolTip1.SetToolTip(lbMenu, drRow["obs"].ToString() + " ");// 'info adicional
                        //toolTip1.SetToolTip(lbMenu, drRow["aplicativo"].ToString() + " "); // info adicional

                        // adiciona as funções dinamicamente
                        lbMenu.Click += abrirApp;
                        // funções de hover/Leave
                        lbMenu.MouseHover += new System.EventHandler(hover_on);
                        lbMenu.MouseLeave += new System.EventHandler(hover_off);
                        // Cria um novo posicionamento para o item label a cada limite de itens por linha

                        if (qtdMenuPorLinha >= limiteMenuporLinha)
                        {
                            posicaoInicial_y = posicaoInicial_y + altura + margin;
                            qtdMenuPorLinha = 1; // set o contador de itens por linha em 1 (recomeçando em uma nova linha)
                            posicaoInicial_x = 10; // retorna o valor original
                        }
                        else
                        {
                            posicaoInicial_x = posicaoInicial_x + largura + margin;
                            qtdMenuPorLinha += 1; // adiciona ao contador de menu por linha
                        }
                        // adiciona ao contador de itens
                        i += 1;
                    }
                }
            }
        }
        public void abrirApp(object sender, EventArgs e)
        {
            string app = (sender as Label).Text;
            acessarFerramenta(app);
        }
        private void acessarFerramenta(string nomeFerramenta)
        {
            hlp.CursorPointer(true);
            Dados obj = new Dados();
            obj = oDados.DadosPorAplicativo(nomeFerramenta);
            if (!string.IsNullOrEmpty(obj.Caminho.ToString()))
            {
                //Registrar log de acesso a ferramenta x
                log.registrarLOG("","" , hlp.getCurrentMethodName().ToString(), obj.Aplicativo,"");
                hlp.abrirArquivo(obj.Caminho.ToString());
                hlp.CursorPointer(false);
                Application.Exit();
            }
            else
            {
                hlp.CursorPointer(false);
                MessageBox.Show("Ferramenta não encontrada.", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

   }
}
