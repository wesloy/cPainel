using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cPainel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new cPainel.form.frmPrincipal());

            ////impedir de abrir duas janelas
            //Process aProcess = Process.GetCurrentProcess();
            //string aProcName = aProcess.ProcessName;
            //if (Process.GetProcessesByName(aProcName).Length > 1)
            //{
            //    MessageBox.Show("O painel já está em execução!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }
    }
}
