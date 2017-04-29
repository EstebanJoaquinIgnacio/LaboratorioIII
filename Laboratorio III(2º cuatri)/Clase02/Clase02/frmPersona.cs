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
    public partial class frmPersona : Form
    {
        private persona _miPersona;

        public persona miPersona
        {
            get { return this._miPersona; }
        }

        public frmPersona()
        {
            InitializeComponent();
            
           
        }

        public virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtEdad.Text != "" && this.txtNombre.Text != "")
            {
                this._miPersona = new persona(this.txtNombre.Text, Convert.ToInt32(this.txtEdad.Text));
                this.DialogResult = DialogResult.OK;            
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
