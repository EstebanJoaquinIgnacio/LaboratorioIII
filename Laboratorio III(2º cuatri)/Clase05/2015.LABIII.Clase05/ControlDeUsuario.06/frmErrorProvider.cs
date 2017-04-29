using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlDeUsuario._06
{
    public partial class frmErrorProvider : Form
    {
        public frmErrorProvider()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String mensaje = "Su nombre es " + usrTextBoxErrorProvider1.Nombre;
            mensaje += "\nSu apellido es " + usrTextBoxErrorProvider1.Apellido;

            MessageBox.Show(mensaje, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
