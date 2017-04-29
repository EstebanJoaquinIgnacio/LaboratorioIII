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
    public partial class FrmAlumno : frmPersona
    {
        private Alumno _miAlumno;

        public Alumno miAlumno
        {
            get { return this._miAlumno; }
        }

        public FrmAlumno()
        {
            InitializeComponent();
        }



        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtEdad.Text != "" && this.txtNombre.Text != "" && this.txtLegajo.Text != "")
            {
                this._miAlumno = new Alumno(this.txtNombre.Text, Convert.ToInt32(this.txtEdad.Text), Convert.ToInt32(this.txtLegajo.Text));
                this.DialogResult = DialogResult.OK;
            }
        }
        

       
    }
}
