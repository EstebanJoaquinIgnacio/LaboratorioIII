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

namespace ModeloSegundoParcialLabIII
{
    public partial class frmAlumno : Form
    {
        private Alumno _miAlumno;

        public Alumno MiAlumno
        {
            get { return this._miAlumno; }
        }


        public frmAlumno()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtApellido.Text != "" && this.txtLegajo.Text != "" && this.cbbCurso.Text != "")
            {
                this.DialogResult = DialogResult.OK;
                this._miAlumno = new Alumno(this.txtApellido.Text, Convert.ToInt32(this.cbbCurso.Text), Convert.ToInt32(this.txtLegajo.Text));
            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
