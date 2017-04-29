using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _01_DataTable
{
    public partial class frmABM : Form
    {
        private Producto _producto;

        public Producto ProductoDelFormulario 
        {
            get { return this._producto; }
        }
        
        public frmABM()
        {
            InitializeComponent();
        }
        public frmABM(Producto p)
            : this()
        {
            this.txtIdProducto.Text = p.idProducto.ToString();
            this.txtDescripcion.Text = p.descripcion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this._producto == null)
                this._producto = new Producto(int.Parse(this.txtIdProducto.Text), this.txtDescripcion.Text);
            else
            {
                this._producto.idProducto = int.Parse(this.txtIdProducto.Text);
                this._producto.descripcion = this.txtDescripcion.Text; 
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


    }
}
