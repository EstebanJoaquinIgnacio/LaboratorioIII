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
namespace Modelo.SegundoParcial.LabIII
{
    public partial class frmAlumno : Form
    {
        private Alumno _MiAlumno;
        public Alumno MiAlumno { get { return this._MiAlumno; } }

        public frmAlumno()
        {
            InitializeComponent();
            this._MiAlumno = null;
            this.cboxCurso.Items.Add(1000);
            this.cboxCurso.Items.Add(1005);
            this.cboxCurso.Items.Add(1010);
        }

        public frmAlumno(string legajo, string apellido, string codCurso) : this()
        {
            this.txtLegajo.Text = legajo;
            this.txtApellido.Text = apellido;
            this.cboxCurso.Text = codCurso;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._MiAlumno = new Alumno(this.txtApellido.Text, (int)this.cboxCurso.SelectedItem, Int32.Parse(this.txtLegajo.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            if (this.Text == "Modificacion")
                this.txtLegajo.ReadOnly = true;
        }
    }
}
