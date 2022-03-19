using Mediatek86.controleur;
using System;
using System.Windows.Forms;


namespace Mediatek86
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmMediatek());
            new Controle();
        }
    }
}
