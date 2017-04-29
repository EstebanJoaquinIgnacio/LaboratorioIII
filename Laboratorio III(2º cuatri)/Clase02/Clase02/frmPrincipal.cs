using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase02
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lstListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersona Alta = new frmPersona();
            
            Alta.Text = "ALTA";
            Alta.ShowDialog();

            if(Alta.DialogResult == DialogResult.OK)
                this.lstListado.Items.Add(Alta.miPersona.ToString());
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumno Alta = new FrmAlumno();
            Alta.Text = "ALTA";
            Alta.ShowDialog();

            if (Alta.DialogResult == DialogResult.OK)
                this.lstListado.Items.Add(Alta.miAlumno.ToString());
        }
    }
}
