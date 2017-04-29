using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioPrincipal
{
    public partial class frmAnimal : Form
    {
        public frmAnimal()
        {
            InitializeComponent();
            btnAceptar.Click += new EventHandler(ManejadorAceptar);
            btnCancelar.Click += new EventHandler(ManejadorCancelar);
        }

        public virtual void ManejadorAceptar(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public void ManejadorCancelar(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
