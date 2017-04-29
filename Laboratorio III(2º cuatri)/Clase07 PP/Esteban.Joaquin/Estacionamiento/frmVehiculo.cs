using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento
{
    public partial class frmVehiculo : Form
    {
        private Vehiculo _vehiculoIngresado;
        public Vehiculo vehiculoIngresado
        {
            get { return this._vehiculoIngresado; }
        }

        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._vehiculoIngresado = new Vehiculo(this.txbPatente.Text, this.txtColor.Text,DateTime.Now);
            this.DialogResult = DialogResult.OK;
        }


    }
}
