using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            

        }

        private void testDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados miForm2 = new frmTestDelegados();
            miForm2.MdiParent = this;
            miForm2.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos formularioDatos = new Datos();
            formularioDatos.MdiParent = this;
            formularioDatos.Show();
        }

    }
}
