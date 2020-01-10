using System.Configuration;
using System.Windows.Forms;
using System.Drawing;

namespace cPainel
{
    public static class Constants
    {
        public static string PATH_ICONS = ConfigurationManager.AppSettings["PATH_ICONS"].ToString();
        public static string PATH_PASTA_MIS = ConfigurationManager.AppSettings["PATH_PASTA_MIS"].ToString();
        public static string PATH_PASTA_ANEXO = ConfigurationManager.AppSettings["PATH_PASTA_ANEXO"].ToString();
        public static string PATH_LOG_IMPORT = ConfigurationManager.AppSettings["PATH_LOG_IMPORT"].ToString();
        public static string BD_PWD = GetConfig("BD_PWD");
        public static string BD_NOME = ConfigurationManager.AppSettings["BD_NOME"].ToString();
        public static string BD_PATH = ConfigurationManager.AppSettings["BD_PATH"].ToString();
        public static string DIR_PESSOAL = ConfigurationManager.AppSettings["DIR_PESSOAL"].ToString();

        public static string ALGAR_BD = ConfigurationManager.AppSettings["ALGAR_BD"].ToString();
        public static string ALGAR_SERVIDOR = ConfigurationManager.AppSettings["ALGAR_SERVIDOR"].ToString();
        public static string ALGAR_USER = ConfigurationManager.AppSettings["ALGAR_USER"].ToString();
        public static string ALGAR_PWD = GetConfig("ALGAR_PWD");

        public static string TITULO_ALERTA = "Alerta do Sistema";
        public static string FormatoDataUniversal = "yyyy-MM-dd";
        public static string FormatoDataHoraUniversal = "yyyy-MM-dd HH:mm:ss";
        public static string CREDITOS = "Rafael Alvarenga";
        public static string Copyright = "Copyright © Microsoft";
        public static string SENHA_ACESSO = "frauderw";
        public static string TIMEOUT = ConfigurationManager.AppSettings["TIMEOUT"].ToString();
        public static string MSG_TIMEOUT = ConfigurationManager.AppSettings["MSG_TIMEOUT"].ToString();

        public enum FlagAcao { Insert = 1, Update = 2, Delete = 3,  NoAction=0  }
        public struct FlagSGBD { const string SQL = "SQL"; const string ACESS = "MSACESS"; }

        public static string GetConfig(string key)
        {
            Algar.Utils.Helpers hlp = new Algar.Utils.Helpers();
            return hlp.Decrypt(ConfigurationManager.AppSettings[key].ToString());
        }

        public static ImageList imglist()
        {
            // cria um imagelist se necessario
            ImageList imageListSmall = new ImageList();
            imageListSmall.Images.Add("1", Image.FromFile(PATH_ICONS + "01.ico"));
            imageListSmall.Images.Add("2", Image.FromFile(PATH_ICONS + "02.ico"));
            imageListSmall.Images.Add("3", Image.FromFile(PATH_ICONS + "03.ico"));
            imageListSmall.Images.Add("4", Image.FromFile(PATH_ICONS + "04.ico"));
            imageListSmall.Images.Add("5", Image.FromFile(PATH_ICONS + "05.ico"));
            imageListSmall.Images.Add("6", Image.FromFile(PATH_ICONS + "06.ico"));
            imageListSmall.Images.Add("7", Image.FromFile(PATH_ICONS + "07.ico"));
            imageListSmall.Images.Add("8", Image.FromFile(PATH_ICONS + "08.ico"));
            imageListSmall.Images.Add("9", Image.FromFile(PATH_ICONS + "09.ico"));
            imageListSmall.Images.Add("10", Image.FromFile(PATH_ICONS + "10.ico"));
            imageListSmall.Images.Add("11", Image.FromFile(PATH_ICONS + "11.ico"));
            imageListSmall.Images.Add("12", Image.FromFile(PATH_ICONS + "12.ico"));
            imageListSmall.Images.Add("13", Image.FromFile(PATH_ICONS + "13.ico"));
            imageListSmall.Images.Add("14", Image.FromFile(PATH_ICONS + "14.ico"));
            return imageListSmall;
        }
    }
}