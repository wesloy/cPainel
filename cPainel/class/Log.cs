using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cPainel
{
    class Log
    {

        #region Variaveis Temporarias 
        string sql = "";
        Algar.Utils.Conexao objCon = new Algar.Utils.Conexao(Algar.Utils.Conexao.FLAG_SGBD.SQL, Constants.ALGAR_PWD, Constants.ALGAR_BD, Constants.ALGAR_SERVIDOR, Constants.ALGAR_USER, "");
        Algar.Utils.Helpers hlp = new Algar.Utils.Helpers();
        #endregion

        #region Entidades
        int _id;
        DateTime _data;
        string _acao;
        string _idUsuario;
        string _funcaoExecutada;
        string _erroNumero;
        string _erroDescricao;
        string _versaoSis;
        string _idiomaPC;
        string _hostname;
        string _ferramenta;

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

        public DateTime Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
            }
        }

        public string Acao
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

        public string IdUsuario
        {
            get
            {
                return _idUsuario;
            }

            set
            {
                _idUsuario = value;
            }
        }

        public string FuncaoExecutada
        {
            get
            {
                return _funcaoExecutada;
            }

            set
            {
                _funcaoExecutada = value;
            }
        }

        public string ErroNumero
        {
            get
            {
                return _erroNumero;
            }

            set
            {
                _erroNumero = value;
            }
        }

        public string ErroDescricao
        {
            get
            {
                return _erroDescricao;
            }

            set
            {
                _erroDescricao = value;
            }
        }

        public string VersaoSis
        {
            get
            {
                return _versaoSis;
            }

            set
            {
                _versaoSis = value;
            }
        }

        public string IdiomaPC
        {
            get
            {
                return _idiomaPC;
            }

            set
            {
                _idiomaPC = value;
            }
        }

        public string Hostname
        {
            get
            {
                return _hostname;
            }

            set
            {
                _hostname = value;
            }
        }

        public string Ferramenta
        {
            get
            {
                return _ferramenta;
            }

            set
            {
                _ferramenta = value;
            }
        }
        #endregion

        #region Dados
        public bool Incluir(Log obj)
        {
            try
            {
                long retorno = 0;
                sql = "insert into syslog ( ";
                sql += "data, ";
                sql += "acao, ";
                sql += "idUsuario, ";
                sql += "funcaoExecutada, ";
                sql += "erroNumero, ";
                sql += "erroDescricao, ";
                sql += "versaoSis, ";
                sql += "idioma, ";
                sql += "hostname, ";
                sql += "ferramenta) ";
                sql += "values ( ";
                sql += objCon.valorSql(obj.Data) + ", ";
                sql += objCon.valorSql(obj.Acao) + ", ";
                sql += objCon.valorSql(obj.IdUsuario) + ", ";
                sql += objCon.valorSql(obj.FuncaoExecutada) + ", ";
                sql += objCon.valorSql(obj.ErroNumero) + ", ";
                sql += objCon.valorSql(obj.ErroDescricao) + ", ";
                sql += objCon.valorSql(obj.VersaoSis) + ", ";
                sql += objCon.valorSql(obj.IdiomaPC) + ", ";
                sql += objCon.valorSql(obj.Hostname) + ", ";
                sql += objCon.valorSql(obj.Ferramenta) + ") ";

                return objCon.executaQuery(sql, ref retorno);
            }
            catch
            {
                return false;
            }
        }
        #endregion


        #region Neogocio
        public void registrarLOG()
        {
         try
            {

            }
            catch
            {

            }
        }



        public void registrarLOG(string erroNumero = "", string erroDescricao = "", string funcaoExecutada = "", string acao = "", string ferramenta = "")
        {
            try
            {
                Log log = new Log();                
                    log.Data = DateTime.Now;
                    log.IdUsuario = hlp.capturaIdRede();
                    log.ErroDescricao = erroDescricao.ToString();
                    log.ErroNumero = erroNumero.ToString();
                    log.FuncaoExecutada = funcaoExecutada.ToString();
                    log.VersaoSis = hlp.versaoSistema();
                    log.IdiomaPC = hlp.retornaIdiomaPC();
                    log.Hostname = System.Environment.MachineName.ToString(); // Interaction.Environ("COMPUTERNAME").ToString();
                    log.Acao = acao.ToString();
                    log.Ferramenta = "PAINEL";
                    log.Incluir(log);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constants.TITULO_ALERTA, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion



    }
}
