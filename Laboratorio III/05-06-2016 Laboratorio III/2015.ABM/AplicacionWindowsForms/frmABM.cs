using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplicacionWindowsForms
{
    public partial class frmABM : Form
    {
        private Entidades.ClaseUno _miObjeto;

        public Entidades.ClaseUno MiObjeto 
        {
            get { return this._miObjeto; }
        }
        
        public frmABM()
        {
            InitializeComponent();
        }

        public frmABM(Entidades.ClaseUno miObj)
            : this()
        {
            this._miObjeto = miObj;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._miObjeto = new Entidades.ClaseUno(this.txtDatoString.Text, Int32.Parse(this.txtDatoInteger.Text));

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmABM_Load(object sender, EventArgs e)
        {
            if (this._miObjeto != null)
            {
                this.txtDatoString.Text = this._miObjeto.DatoString;
                this.txtDatoInteger.Text = this._miObjeto.DatoEntero.ToString();
            }
        }
    }
}
