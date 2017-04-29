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
    public partial class FrmMascota : FrmAnimal
    {
        private Mascota _miMascota;
        public Mascota miMascota
        {
            get { return this._miMascota; }
        }


        public FrmMascota()
        {
            InitializeComponent();
            this.cmbTipoMascota.DataSource = Enum.GetValues(typeof(eTipoDeMascota));
            
        }

        public FrmMascota(Mascota mascota):this()
        {
            this.txbEdad.Text = mascota.edad.ToString();
            this.txbNombre.Text = mascota.nombre;
            this.cmbTipoMascota.SelectedItem = mascota.TipoDeMascota;
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            this._miMascota = new Mascota(this.txbNombre.Text, (eTipoDeMascota)this.cmbTipoMascota.SelectedItem, Convert.ToInt32(this.txbEdad.Text));
        }

        private void FrmMascota_Load(object sender, EventArgs e)
        {
            if (this.Text == "Baja")
            {
                this.txbEdad.ReadOnly = true;
                this.txbNombre.ReadOnly = true;
                this.cmbTipoMascota.Enabled = false;
            }
        }
    }
}
