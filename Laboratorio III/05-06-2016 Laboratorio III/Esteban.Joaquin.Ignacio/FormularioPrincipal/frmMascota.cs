using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace FormularioPrincipal
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
            foreach(string enumerador in Enum.GetNames(typeof(eTipoDeMascota)))
            {
                this.cmbTipoMascota.Items.Add(enumerador);
            }
            cmbTipoMascota.SelectedIndex = 0;

        }

        public frmMascota(Mascota unaMascota) : this()
        {
            this._miMascota = unaMascota;           
            
        }

        public override void ManejadorAceptar(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "" && this.txtEdad.Text != "")
                this._miMascota = new Mascota(this.txtNombre.Text, (eTipoDeMascota)Enum.Parse(typeof(eTipoDeMascota), this.cmbTipoMascota.Text.ToString()), Convert.ToInt32(this.txtEdad.Text)); //se tiene que parciar el enum de la forma mostrada
                       
            
            base.ManejadorAceptar(sender, e);

        }

        private void cmbTipoMascota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMascota_Load(object sender, EventArgs e)
        {
            if (this._miMascota != null)
            {
                this.txtEdad.Text = this._miMascota.edad.ToString();
                this.txtNombre.Text = this._miMascota.nombre;
                this.cmbTipoMascota.Text = this._miMascota.tipoDeMascota.ToString();
                if (this.Text == "Baja")
                {
                    this.txtEdad.ReadOnly = true;
                    this.txtNombre.ReadOnly = true;
                    this.cmbTipoMascota.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
