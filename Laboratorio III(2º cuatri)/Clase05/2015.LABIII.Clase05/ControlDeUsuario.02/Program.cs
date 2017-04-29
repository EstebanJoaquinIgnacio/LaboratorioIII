using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControlDeUsuario._02
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
            
            frmControlUsuarioEventos frm = new frmControlUsuarioEventos();
            frm.StartPosition = FormStartPosition.CenterScreen;

            Application.Run(frm);
        }
    }
}
