using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Delegado;

namespace Aplicacion_1
{
    public partial class frmAltaAlumno : Form
    {
        private string miPath = null;
        public static event MostrarAlumnoPorDelegado mostrarAlumnoCargado;

        public frmAltaAlumno()
        {
            InitializeComponent();
            this.txtFoto.DoubleClick += new EventHandler(txtFoto_DoubleClick);
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            Alumno miAlumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text, Convert.ToInt32(this.txtDni.Text), this.txtFoto.Text);
            mostrarAlumnoCargado(miAlumno,e);


        }

        private void txtFoto_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog miFile = new OpenFileDialog();
            if (this.ofdAltaAlumno.ShowDialog() == DialogResult.OK)
            {
                
                miPath = this.ofdAltaAlumno.FileName;
                this.txtFoto.Text = miPath;
                //pictureBox1.Image = Image.FromFile(miPath);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

       
    }
}
