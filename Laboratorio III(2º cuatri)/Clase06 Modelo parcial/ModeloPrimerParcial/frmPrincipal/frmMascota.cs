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

namespace frmPrincipal
{
    public partial class frmMascota : frmAnimal
    {
        private Mascota _miMascota;
        public Mascota miMascota
        {
            get { return this._miMascota; }
        }

        public frmMascota()
        {
            InitializeComponent();

            this.cmbTipoMascota.DataSource = Enum.GetValues(typeof(eTipoDeMascota));

        }
        public frmMascota(Mascota unaMascota):this()
        {
            this._miMascota = unaMascota;
            this.txbEdad.Text = this._miMascota.edad.ToString();
            this.txtNombre.Text = this._miMascota.nombre;
            this.cmbTipoMascota.SelectedItem = this._miMascota.tipoDeMascota;
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            this._miMascota = new Mascota(this.txtNombre.Text,(eTipoDeMascota)this.cmbTipoMascota.SelectedItem/*(eTipoDeMascota)Enum.Parse(typeof(eTipoDeMascota),this.cmbTipoMascota.Text)*/,Convert.ToInt32(this.txbEdad.Text));
             //(Etipo) Enum.Parse(typeof(Etipo), StringETipo
        }

        private void frmMascota_Load(object sender, EventArgs e)
        {
            if (this.Text == "Baja")
            {
                this.txtNombre.ReadOnly = true;
                this.txbEdad.ReadOnly = true;
                this.cmbTipoMascota.Enabled = false;
            }          
        }
    }
}
