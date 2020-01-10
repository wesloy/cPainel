using System;
using System.Data;
using System.Windows.Forms;

namespace cPainel
{
    class Dados
    {
        #region Variaveis Temporarias 
        string sql = "";
        Algar.Utils.Conexao objCon = new Algar.Utils.Conexao(Algar.Utils.Conexao.FLAG_SGBD.SQL, Constants.ALGAR_PWD, Constants.ALGAR_BD, Constants.ALGAR_SERVIDOR, Constants.ALGAR_USER, "");
        Algar.Utils.Helpers hlp = new Algar.Utils.Helpers();
        #endregion

        #region Entidades
        int _id;
        string _aplicativo;
        string _caminho;
        string _obs;
        string _rgb;
        byte _acao;


        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Aplicativo
        {
            get
            {
                return _aplicativo;
            }

            set
            {
                _aplicativo = value;
            }
        }

        public string Caminho
        {
            get
            {
                return _caminho;
            }

            set
            {
                _caminho = value;
            }
        }

        public string Obs
        {
            get
            {
                return _obs;
            }

            set
            {
                _obs = value;
            }
        }

        public string Rgb
        {
            get
            {
                return _rgb;
            }

            set
            {
                _rgb = value;
            }
        }

        public byte Acao
        {
            get
            {
                return _acao;
            }

            set
            {
                _acao = value;
            }
        }
        #endregion

        #region Dados
        /// <summary>
        /// TESTE DE CONTEUDO
        /// </summary>
        /// <param name="obj"> TESTE MSG PARAMETRO</param>
        /// <returns></returns>
        public bool Incluir(Dados obj)
        {
            try
            {
                long retorno = 0;
                sql += "insert into PAINEL_sysDados ";
                sql += "(aplicativo, ";
                sql += "caminho, ";
                sql += "obs, ";
                sql += "rgb) ";
                sql += "values ( ";
                sql += objCon.valorSql(obj.Aplicativo.Trim()) + ", ";
                sql += objCon.valorSql(obj.Caminho.Trim()) + ", ";
                sql += objCon.valorSql(obj.Obs.Trim()) + ", ";
                sql += objCon.valorSql(obj.Rgb.Trim()) + ") ";
                return objCon.executaQuery(sql, ref retorno);
            }
            catch
            {
                return false;
            }
        }
        public bool Editar(Dados obj)
        {
            try
            {
                long retorno = 0;
                sql = "update PAINEL_sysDados ";
                sql += "set aplicativo = " + objCon.valorSql(obj.Aplicativo.Trim()) + ", ";
                sql += "caminho = " + objCon.valorSql(obj.Caminho.Trim()) + ", ";
                sql += "obs = " + objCon.valorSql(obj.Obs.Trim()) + ", ";
                sql += "rgb = " + objCon.valorSql(obj.Rgb.Trim()) + " ";
                sql += "Where id = " + obj.Id + " ";
                return objCon.executaQuery(sql, ref retorno);
            }
            catch
            {
                return false;
            }
        }
        public bool Excluir(int id)
        {
            try
            {
                long retorno = 0;
                sql = "delete from PAINEL_sysDados Where id  = " + objCon.valorSql(id);
                return objCon.executaQuery(sql, ref retorno);
            }
            catch
            {
                return false;
            }
        }
        public bool ValidaDuplicidade(Dados obj)
        {
            try
            {
                DataTable dt = new DataTable();
                sql = "select * from PAINEL_sysDados ";
                sql += "Where 1=1 ";
                sql += "and aplicativo like " + objCon.valorSql(obj.Aplicativo.Trim()) + " ";
                dt = objCon.retornaDataTable(sql);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow linha in dt.Rows)
                    {
                        if (obj.Id.ToString() == linha["id"].ToString())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString(), Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        public Dados DadosPorAplicativo(string descricaoApp)
        {
            try
            {
                Dados oDados = new Dados();
                string sql = "";
                DataTable dt = new DataTable();
                sql = "Select * from PAINEL_sysDados where aplicativo = " + objCon.valorSql(descricaoApp.ToString());
                dt = objCon.retornaDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow linha in dt.Rows)
                    {
                        oDados.Id = int.Parse(objCon.retornaVazioParaValorNulo(linha["id"]).ToString());
                        oDados.Aplicativo = objCon.retornaVazioParaValorNulo(linha["aplicativo"]).ToString();
                        oDados.Caminho = objCon.retornaVazioParaValorNulo(linha["caminho"]).ToString();
                        oDados.Obs = objCon.retornaVazioParaValorNulo(linha["obs"]).ToString();
                        oDados.Rgb = objCon.retornaVazioParaValorNulo(linha["rgb"]).ToString();
                        oDados.Acao = Convert.ToByte(Constants.FlagAcao.NoAction);
                    }
                }
                return oDados;
            }
            catch
            {
                return null;
            }
        }
        public Dados DadosPorID(int id)
        {
            try
            {
                Dados oDados = new Dados();
                string sql = "";
                DataTable dt = new DataTable();
                sql = "Select * from PAINEL_sysDados where id = " + objCon.valorSql(id.ToString());
                dt = objCon.retornaDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow linha in dt.Rows)
                    {
                        oDados.Id = int.Parse(objCon.retornaVazioParaValorNulo(linha["id"]).ToString());
                        oDados.Aplicativo = objCon.retornaVazioParaValorNulo(linha["aplicativo"]).ToString();
                        oDados.Caminho = objCon.retornaVazioParaValorNulo(linha["caminho"]).ToString();
                        oDados.Obs = objCon.retornaVazioParaValorNulo(linha["obs"]).ToString();
                        oDados.Rgb = objCon.retornaVazioParaValorNulo(linha["rgb"]).ToString();
                        oDados.Acao = Convert.ToByte(Constants.FlagAcao.NoAction);
                    }
                }
                return oDados;
            }
            catch
            {
                return null;
            }
        }
        public DataTable ListarApp()
        {
            try
            {
                sql = "Select * from PAINEL_sysDados order by aplicativo asc ";
                return objCon.retornaDataTable(sql);
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Negocio
        public bool Salvar(Dados obj)
        {
            try
            {
                bool ok = false;
                //INSERT
                if (obj.Acao == Convert.ToByte(Constants.FlagAcao.Insert))
                {
                    if (ValidaDuplicidade(obj))
                    {
                        ok = Incluir(obj);
                        if (ok)
                        {
                            MessageBox.Show("Registro salvo com sucesso.", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Falha ao salvar o registro.", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(obj.Aplicativo.ToString().ToUpper() + " já existe.", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                //UPDATE
                if (obj.Acao == Convert.ToByte(Constants.FlagAcao.Update))
                {
                    if (ValidaDuplicidade(obj))
                    {
                        ok = Editar(obj);
                        if (ok)
                        {
                            MessageBox.Show("Registro alterado com sucesso.", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Falha ao editar o registro.", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(obj.Aplicativo.ToString().ToUpper() + " já existe.", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }

                //DELETE
                if (obj.Acao == Convert.ToByte(Constants.FlagAcao.Delete))
                {
                    ok = Excluir(obj.Id);
                    if (ok)
                    {
                        MessageBox.Show("Registro excluido com sucesso.", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir o registro.", Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }

                return false;
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString(), Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        public long QtdAcessosHoje()
        {
            try
            {
                long valor = 0;
                DataTable dt = new DataTable();
                sql = "select Format(D.data, 'yyyy-MM-dd') AS PERIODO, ";
                sql += "COUNT(DISTINCT D.IDUSUARIO) AS QTD ";
                sql += "from syslog D ";
                sql += "where ferramenta = 'PAINEL' ";
                sql += "AND Format(D.data, 'yyyy-MM-dd') = '2018-09-06' ";
                sql += "GROUP BY Format(D.data, 'yyyy-MM-dd') ";

                dt = objCon.retornaDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow linha in dt.Rows)
                    {
                        valor = long.Parse(linha["QTD"].ToString());
                    }
                }
                return valor;
            }
            catch
            {
                return 0;
            }
        }
        public ListView CarregaListView(ListView lst)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ListarApp();
                lst.Clear();
                lst.View = View.Details;
                lst.LabelEdit = false;
                lst.CheckBoxes = false;
                lst.SmallImageList = Constants.imglist();
                lst.GridLines = true;
                lst.FullRowSelect = true;
                lst.HideSelection = false;
                lst.MultiSelect = false;
                lst.Columns.Add("ID", 50, HorizontalAlignment.Left);
                lst.Columns.Add("FERRAMENTA", 490, HorizontalAlignment.Left);
                //lst.Columns.Add("CAMINHO", 150, HorizontalAlignment.Left);
                //lst.Columns.Add("FILA", 315, HorizontalAlignment.Left);
                //lst.Columns.Add("ÁREA", 210, HorizontalAlignment.Left);
                //lst.Columns.Add("GRUPO", 150, HorizontalAlignment.Left);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow linha in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = linha["id"].ToString();
                        item.SubItems.Add(linha["aplicativo"].ToString());
                        //item.SubItems.Add(linha["caminho"].ToString());
                        //item.SubItems.Add(linha["obs"].ToString());
                        //item.SubItems.Add(linha["rgb"].ToString());
                        lst.Items.Add(item);
                    }
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }
        public void ListarCores(Form frm, ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                sql = "Select PAINEL_sysCoresRgb.id, PAINEL_sysCoresRgb.rgb from PAINEL_sysCoresRgb ";
                sql += "order by PAINEL_sysCoresRgb.nome asc";
                dt = objCon.retornaDataTable(sql);
                hlp.carregaComboBox(dt, frm, cb, true, "rgb", "id");
            }
            catch
            {

            }
        }
        public bool ValidaCorEmUso(string rgb)
        {
            try
            {
                long valor = 0;
                bool bln = false;
                DataTable dt = new DataTable();
                sql = "Select COUNT(PAINEL_sysDados.id) AS QTD from PAINEL_sysDados where rgb = " + objCon.valorSql(rgb);
                dt = objCon.retornaDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow linha in dt.Rows)
                    {
                        valor = long.Parse(linha["QTD"].ToString());
                        if (valor > 0)
                        {
                            bln = true;
                        }
                        else
                        {
                            bln = false;
                        }
                    }
                }
                return bln;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}