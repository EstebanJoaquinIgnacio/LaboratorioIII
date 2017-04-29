using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.OffShore;

namespace frmPrincipal
{
    public partial class frmPrincipal : Form
    {
        private List<CuentaOffShore> _listaCuentasOffShore;
        private bool FlagBotonesActivos = false;

        public frmPrincipal()
        {
            InitializeComponent();

            this._listaCuentasOffShore = new List<CuentaOffShore>();

            foreach (string tipo in Enum.GetNames(typeof(eTipoOrdenamiento)))
            {
                this.cmbOrdenamiento.Items.Add(tipo);
            }

            this.cmbOrdenamiento.SelectedIndex = 0;

            //Saco el manejador de los botones modificación y baja para que no se pueden usar hasta que seleccione en el ListBox
            this.btnBaja.Click -= this.btnBaja_Click;
            this.btnModificar.Click -= this.btnModificar_Click;
        }

        //ALTA
        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentaOffShore ALTA = new frmCuentaOffShore();
            ALTA.ShowDialog();
            if (ALTA.DialogResult == DialogResult.OK)
            {
                this._listaCuentasOffShore.Add(ALTA.cuentaOffShore);
                this.MostrarLista();
            }

            this.sacarBotenesAgregarSeleccion();
        }

        private void MostrarLista()
        {
            this.lsbABMCuentas.Items.Clear();
            foreach (Cuenta cuenta in this._listaCuentasOffShore)
            {
                this.lsbABMCuentas.Items.Add(cuenta);
            }
        }

        private void lsbABMCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.FlagBotonesActivos == false)
            {
                this.btnBaja.Click += this.btnBaja_Click;
                this.btnModificar.Click += this.btnModificar_Click;
                //Saco el que entra aqui xq no pierdo el foco ya (a menos que reimprima la lista)
                this.lsbABMCuentas.SelectedIndexChanged -= this.lsbABMCuentas_SelectedIndexChanged;

                this.FlagBotonesActivos = true;
                
            }

           
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            int indice = this.lsbABMCuentas.SelectedIndex;
            frmCuentaOffShore BAJA = new frmCuentaOffShore(this._listaCuentasOffShore[indice]);
            BAJA.Text = "BAJA";

            BAJA.ShowDialog();
            if (BAJA.DialogResult == DialogResult.OK)
            {
                this._listaCuentasOffShore.RemoveAt(indice);
                this.MostrarLista();
            }

            this.sacarBotenesAgregarSeleccion();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.lsbABMCuentas.SelectedIndex;
            frmCuentaOffShore MODIFICACION = new frmCuentaOffShore(this._listaCuentasOffShore[indice]);
            MODIFICACION.Text = "MODIFICACION";

            MODIFICACION.ShowDialog();
            if (MODIFICACION.DialogResult == DialogResult.OK)
            {
                this._listaCuentasOffShore[indice] = MODIFICACION.cuentaOffShore;
                this.MostrarLista();
            }

            this.sacarBotenesAgregarSeleccion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.quiereSalir();
        }

        private void sacarBotenesAgregarSeleccion()
        {
            this.btnBaja.Click -= this.btnBaja_Click;
            this.btnModificar.Click -= this.btnModificar_Click;
            //Saco el que entra aqui xq no pierdo el foco ya (a menos que reimprima la lista)
            this.lsbABMCuentas.SelectedIndexChanged += this.lsbABMCuentas_SelectedIndexChanged;

            this.FlagBotonesActivos = false;
        }

        private void quiereSalir()
        { 
            if(MessageBox.Show("Desea cerrar la aplicación???","Salir?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();                
            }
            
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.quiereSalir();
            e.Cancel = true;
        }
        
    }
}
