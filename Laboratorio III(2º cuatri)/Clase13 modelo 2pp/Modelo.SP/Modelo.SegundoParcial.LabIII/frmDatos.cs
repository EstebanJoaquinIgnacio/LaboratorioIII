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
    public partial class frmDatos : Form
    {
        private Alumno _miAlumno;
        public Alumno MiAlumno { get { return this._miAlumno; } }

        public frmDatos()       {
            
            InitializeComponent();
            this.cbxCursos.Items.Add(1000);
            this.cbxCursos.Items.Add(1005);
            this.cbxCursos.Items.Add(1010);
            this.cbxCursos.SelectedIndex = 0;
            
        }

        public frmDatos(DataRow unAlumno)
            : this()
        {
            this.txtLegajo.Text = unAlumno[0].ToString();
            this.txtApellido.Text = unAlumno[1].ToString();
            switch (unAlumno[2].ToString())
            { 
                case "1000":
                    this.cbxCursos.SelectedIndex = 0;
                    break;
                case "1005":
                    this.cbxCursos.SelectedIndex = 1;
                    break;
                case "1010":
                    this.cbxCursos.SelectedIndex = 2;
                    break;

            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._miAlumno = new Alumno(this.txtApellido.Text, Convert.ToInt32(this.cbxCursos.SelectedItem.ToString()), Convert.ToInt32(this.txtLegajo.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            if (this.Text == "Baja")
            {
                this.txtApellido.ReadOnly = true;
                this.txtLegajo.ReadOnly = true;
                this.cbxCursos.Enabled = false;
            }

            if (this.Text == "Modificacion")
            {
                this.txtLegajo.ReadOnly = true;
            }

        }
    }
}
