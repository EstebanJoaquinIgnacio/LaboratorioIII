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
    public partial class frmDatosAlumno : frmAltaAlumno
    {
        public frmDatosAlumno()
        {
            InitializeComponent();
        }

        public void actualizarAlumno(Entidades.Alumno alumno, EventArgs e)
        {
            this.txtApellido.Text = alumno.apellido;
            this.txtDni.Text = Convert.ToString(alumno.dni);
            this.txtNombre.Text = alumno.nombre;
            this.txtFoto.Text = alumno.fotoAlumno;
            this.pbFoto.Image = Image.FromFile(this.txtFoto.Text);

        }
        
        private void frmDatosAlumno_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
