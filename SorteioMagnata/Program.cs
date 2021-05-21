using System;
using System.Windows.Forms;

namespace SorteioMagnata
{
    static class Program
    {
        //DECLARAÇÃO DE VARIÁVEIS GLOBAIS DO SISTEMA
        public static string nomeUsuario;
        public static string cargoUsuario;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
