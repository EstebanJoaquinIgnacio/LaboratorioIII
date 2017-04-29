using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Aeropuerto
{
    public partial class frmAvion : Form
    {


        private Avion _miAvion;

        public Avion miAvion
        {
            get { return this._miAvion; }
        }

        public frmAvion()
        {
            InitializeComponent();                       
           
        }

       

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void aceptar(object sender, EventArgs e)
        { 
            if(this.txtMatricula.Text != "" && this.txtMarca.Text != "" && this.txtModelo.Text != "" && Convert.ToInt32(this.txtCapacidad.Text) < 0 && this.cmbDestino.Text != "")
            {
                this._miAvion = new Avion(Convert.ToInt32(this.txtMatricula.Text), this.txtMarca.Text, this.txtModelo.Text, Convert.ToInt32(this.txtCapacidad.Text), Convert.ToInt32(this.cmbDestino.Text));
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cancelar(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            this.btnAceptar.Click += new EventHandler(this.aceptar);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.btnAceptar.Click += new EventHandler(this.cancelar);
        }
    
    }
}
