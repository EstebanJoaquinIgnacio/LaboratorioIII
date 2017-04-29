using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_ejemplo_01
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
            Form1 miFormulario = new Form1("Mi Primer Formulario"); //Instacio al formulario
            Application.Run(miFormulario); //mando ya con texto en ves de uno vacio
            
        }
    }
}
