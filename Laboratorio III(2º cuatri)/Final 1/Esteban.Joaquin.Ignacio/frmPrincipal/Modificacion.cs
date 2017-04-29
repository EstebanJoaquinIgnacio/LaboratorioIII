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
    public partial class Modificacion : Form
    {


        public Modificacion()
        {
            InitializeComponent();
        }
        public Modificacion(DataRow miFila)
            : this()
        {
            this.txtCodigo.Text = miFila[0].ToString();
            this.txtRazonSocial.Text = miFila[1].ToString();
            this.txtCuid.Text = miFila[2].ToString();
            this.txtIdDomicilio.Text = miFila[3].ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
