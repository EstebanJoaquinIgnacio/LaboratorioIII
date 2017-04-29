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
    public partial class frmArticulo : Form
    {
        private Articulo _miArticulo;
        public Articulo miArticulo        
        {
            get { return this._miArticulo; }
        }


        public frmArticulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.tbxMarca.Text != "" && this.tbxPrecioVenta.Text != "" && this.tbxStock.Text != "" && this.cbxTipo.Text != "")
            {
                

                this._miArticulo = new Articulo((Etipo)Enum.Parse(typeof(Etipo), this.cbxTipo.SelectedItem.ToString()), this.tbxMarca.Text, Convert.ToDouble(this.tbxPrecioVenta.Text), Convert.ToInt32(this.tbxStock.Text));
                this.DialogResult = DialogResult.OK;
            }
                
            else { MessageBox.Show("DEBE RELLENAR todos LostFocus campos"); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
