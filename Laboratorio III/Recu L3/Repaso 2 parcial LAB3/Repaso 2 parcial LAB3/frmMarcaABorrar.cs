using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmMarcaABorrar : Form
    {
        private string marca_a_borrar;

        public string MarcaABorrar
        {
            get { return this.marca_a_borrar; }
        }

        public frmMarcaABorrar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.marca_a_borrar = this.tbxMarcaABorrar.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
