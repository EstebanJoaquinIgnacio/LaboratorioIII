using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Estacionamiento
{
    public partial class frmPrincipal : Form
    {
        private List<Vehiculo> listaSalida;
        private List<Vehiculo> listaIngreso;

        public frmPrincipal()
        {
            InitializeComponent();
            this.listaSalida = new List<Vehiculo>();
            this.listaIngreso = new List<Vehiculo>();
            this.cmbOrdenar.DataSource = Enum.GetValues(typeof(ordenar));
            this.btnSalida.Click -= new EventHandler(this.btnSalida_Click);
        }

        public enum ordenar
        { 
            ordenarPorPatente,
            ordenarPorFechaDeIngreso
        }

        public void ordenador()
        {
            int indice = this.cmbOrdenar.SelectedIndex;
            Comparison<Vehiculo> comparador = new Comparison<Vehiculo>(Vehiculo.ordenarPorPatente);

            switch (indice)
            {
                case 0:
                    comparador = new Comparison<Vehiculo>(Vehiculo.ordenarPorPatente);
                    break;
                case 1:
                    comparador = new Comparison<Vehiculo>(Vehiculo.ordenarPorFechaDeIngreso);
                    break;
                default:
                    break;
            }

            this.listaIngreso.Sort(comparador);
            this.listaSalida.Sort(comparador);

            this.mostrar();


        }

        private void btnSalida_Click(object sender, EventArgs e)
        {

            int indice = this.lsbPrincipal.SelectedIndex;
            frmVehiculoHeredado Salida = new frmVehiculoHeredado(this.listaIngreso[indice]);
            Salida.Text = "Salida";
            Salida.ShowDialog();
            if (Salida.DialogResult == DialogResult.OK)
            {
                this.listaSalida.Add(this.listaIngreso[indice]);
                archivoEgreso(this.listaIngreso[indice], Salida.costo);
                this.listaIngreso.Remove(this.listaIngreso[indice]);
                
            }

            this.mostrar();

            this.btnSalida.Click -= new EventHandler(this.btnSalida_Click);
            this.lsbPrincipal.SelectedIndexChanged += new EventHandler(this.lsbPrincipal_SelectedIndexChanged);
        }

        private void lsbPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSalida.Click += new EventHandler(this.btnSalida_Click);
            this.lsbPrincipal.SelectedIndexChanged -= new EventHandler(this.lsbPrincipal_SelectedIndexChanged);
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            frmVehiculo alta = new frmVehiculo();
            alta.ShowDialog();

            if (alta.DialogResult == DialogResult.OK)
            {
                this.listaIngreso.Add(alta.vehiculoIngresado);
                this.archivoIngreso(alta.vehiculoIngresado);
            }

            this.mostrar();
        }

        private void mostrar()
        {
            this.lsbPrincipal.Items.Clear();

            foreach (Vehiculo item in this.listaIngreso)
            {
                this.lsbPrincipal.Items.Add(item);
            }
        }

        private void archivoIngreso(Vehiculo unVehiculo)
        {
            using (StreamWriter escritor = File.CreateText("ingreso.txt"))
            {
                foreach (Vehiculo item in this.listaIngreso)
                {
                    escritor.WriteLine(item.ToString());
                }
            }
        }

        private void archivoEgreso(Vehiculo unVehiculo,double costo)
        {
            string archivoLeido;

            using (StreamReader lector = File.OpenText("egreso.txt"))
            {
                //foreach (Vehiculo item in this.listaIngreso)
                //{
                   archivoLeido=  lector.ReadToEnd();
                //}
            }

            using (StreamWriter escritor = File.CreateText("egreso.txt"))
            {
                //foreach (Vehiculo item in this.listaSalida)
                //{
                escritor.WriteLine(archivoLeido + unVehiculo.ToString() + " " + costo);
                //}
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea Salir de la Aplicacion", "ADVERTENCIA", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
