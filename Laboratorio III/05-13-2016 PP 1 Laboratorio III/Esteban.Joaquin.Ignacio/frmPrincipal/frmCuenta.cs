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
    public partial class frmCuenta : Form
    {
        public frmCuenta()
        {
            InitializeComponent();
            this.btnAceptar.Click += new EventHandler(ManejadorAceptar);
            this.btnCancelar.Click += new EventHandler(ManejadorCancelar);
        }

        public virtual void ManejadorAceptar(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public void ManejadorCancelar(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmCuenta_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void txtTitular1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNroCuenta1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
