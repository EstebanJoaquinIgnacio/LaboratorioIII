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
    public partial class frmVehiculoHeredado : frmVehiculo
    {
        public double costo;

        public frmVehiculoHeredado()
        {
            InitializeComponent();
        }

        public frmVehiculoHeredado(Vehiculo unVehiculo):this()
        {
            this.txbPatente.Text = unVehiculo.patente;
            this.txtColor.Text = unVehiculo.color;

            TimeSpan delta = DateTime.Now - unVehiculo.fechaDeIngreso;
            double segundos = delta.TotalMilliseconds;
            this.txbCosto.Text = (segundos * 0.05).ToString();
            this.costo = segundos * 0.05;
        }

        private void frmVehiculoHeredado_Load(object sender, EventArgs e)
        {
            if (this.Text == "Salida")
            {
                this.txbPatente.ReadOnly = true;
                this.txtColor.ReadOnly = true;
                this.txbCosto.ReadOnly = true;
            }
        }


    }
}
