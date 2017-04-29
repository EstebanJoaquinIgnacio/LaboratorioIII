using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase12_JOA
{
    public partial class frmUpdate : Form
    {
        private Persona _miPersona;
        public Persona miPersona { get { return this._miPersona; } }


        public frmUpdate()
        {
            InitializeComponent();
        }

        public frmUpdate(Persona unaPersona) :this()
        {
            this.txtApellido.Text = unaPersona.apellido;
            this.txtNombre.Text = unaPersona.nombre;
            this.txtEdad.Text = unaPersona.edad.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._miPersona = new Persona(this.txtNombre.Text, this.txtApellido.Text, Convert.ToInt32(this.txtEdad.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            if (this.Text == "Baja")
            {
                this.txtApellido.ReadOnly = true;
                this.txtNombre.ReadOnly = true;
                this.txtEdad.ReadOnly = true;

            }
        }
    }
}
