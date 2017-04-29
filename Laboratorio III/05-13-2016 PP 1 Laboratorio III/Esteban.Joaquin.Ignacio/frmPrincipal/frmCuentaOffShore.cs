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
    public partial class frmCuentaOffShore : frmCuenta
    {
        private CuentaOffShore _cuentaOffShore;

        public CuentaOffShore cuentaOffShore
        {
            get { return this._cuentaOffShore; }
        }

        public frmCuentaOffShore()
        {
            InitializeComponent();

            foreach (string tipo in Enum.GetNames(typeof(eParaisoFiscal)))
            {
                this.cmbParaisoFiscal.Items.Add(tipo);
            }
            this.cmbParaisoFiscal.SelectedIndex = 0;
        }

        public frmCuentaOffShore(CuentaOffShore cuenta) : this()
        {
            this.txtNroCuenta.Text = Convert.ToString(cuenta.NroCuenta);
            this.txtTitular.Text = cuenta.Titular;
            this.cmbParaisoFiscal.Text = Convert.ToString(cuenta.ParaisoFiscal);//(eParaisoFiscal)Enum.Parse(typeof(eParaisoFiscal),cuenta.ParaisoFiscal.ToString());

        }

        public override void ManejadorAceptar(object sender, EventArgs e)
        {
            if (this.txtNroCuenta.Text != "" && this.txtTitular.Text != "")
                this._cuentaOffShore = new CuentaOffShore(Convert.ToInt32(this.txtNroCuenta.Text), this.txtTitular.Text, (eParaisoFiscal)Enum.Parse(typeof(eParaisoFiscal), this.cmbParaisoFiscal.Text));

            base.ManejadorAceptar(sender, e);
        }

        private void frmCuentaOffShore_Load(object sender, EventArgs e)
        {
            if (this.Text == "BAJA")
            {
                this.txtNroCuenta.ReadOnly = true;
                this.txtTitular.ReadOnly = true;
                this.cmbParaisoFiscal.Enabled = false;
            }
        }


        
    }
}
