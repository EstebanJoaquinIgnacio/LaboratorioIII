using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delegado;


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

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos formularioDatos = new frmDatos();
            frmTestDelegados.cambiarNombreDelLabel += new CambiarNombreDel(formularioDatos.cambiarNombre);
            frmTestDelegados.actualizarFotoPorDelegado += new CambiarNombreDel(formularioDatos.ActualizarFoto);
            formularioDatos.MdiParent = this;
            formularioDatos.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAlumno formularioAlumno = new frmAltaAlumno();
            formularioAlumno.MdiParent = this;
            formularioAlumno.Show();
            
        }

        

        private void alumnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDatosAlumno datosAlumno = new frmDatosAlumno();
            frmAltaAlumno.mostrarAlumnoCargado += new MostrarAlumnoPorDelegado(datosAlumno.actualizarAlumno);
            datosAlumno.MdiParent = this;
            datosAlumno.Show();
        }

    }
}
