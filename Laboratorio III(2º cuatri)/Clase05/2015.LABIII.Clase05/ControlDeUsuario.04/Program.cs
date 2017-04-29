using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControlDeUsuario._04
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmEnumerados frm = new frmEnumerados();
            frm.StartPosition = FormStartPosition.CenterScreen;

            Application.Run(frm);
        }
    }
}
