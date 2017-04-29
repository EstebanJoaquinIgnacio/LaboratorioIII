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
using System.IO;

namespace frmPrincipal
{
    public enum eTipoDeOrdenamiento
    { 
        porEdad,
        PorNombre,
        porTipo
    }

    public partial class frmPrincipal : Form
    {
        private List<Mascota> _miListaMascotas;

        public frmPrincipal()
        {
            InitializeComponent();
            this._miListaMascotas = new List<Mascota>();
            this.cbmOrdenar.DataSource = Enum.GetValues(typeof(eTipoDeOrdenamiento));
            this.cbmOrdenar.SelectedIndexChanged += new EventHandler(this.ordenar);
            this.bAJAToolStripMenuItem.Click -= new EventHandler(this.ManejadorCentral);
            this.modificacionToolStripMenuItem.Click -= new EventHandler(this.ManejadorCentral);

            this.abrirArchivo();

        }

        private void ordenar(object sender, EventArgs e)
        {
            int indice = this.cbmOrdenar.SelectedIndex;
            Comparison<Mascota> comparar = new Comparison<Mascota>(Mascota.OrdenarPorEdad);
            switch (indice)
            {
                case 0:
                    comparar = new Comparison<Mascota>(Mascota.OrdenarPorEdad);
                    break;
                case 1:
                    comparar = new Comparison<Mascota>(Mascota.OrdenarPorNombre);
                    break;
                case 2:
                    comparar = new Comparison<Mascota>(Mascota.OrdenarPorTipo);
                    break;
                default:
                    break;
            }

            this._miListaMascotas.Sort(comparar);
            this.Mostrar();
        }

        private void aLTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMascota alta = new frmMascota();
            alta.ShowDialog();

            if (alta.DialogResult == DialogResult.OK)
            {
                this._miListaMascotas.Add(alta.miMascota);
                this.Mostrar();
            }
        }

        private void Mostrar()
        {
            this.lsbMascota.Items.Clear();

            foreach (Mascota item in this._miListaMascotas)
            {
                this.lsbMascota.Items.Add(item.ToString());
            }
        }

        private void bAJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*int indiceSeleccionado = this.lsbMascota.SelectedIndex;
            frmMascota baja = new frmMascota(this._miListaMascotas[indiceSeleccionado]);
            baja.Text = "Baja";
            baja.ShowDialog();

            if(baja.DialogResult == DialogResult.OK)
            {
                this._miListaMascotas.Remove(this._miListaMascotas[indiceSeleccionado]);              
                Mostrar();
            }

            this.bAJAToolStripMenuItem.Click -= new EventHandler(this.bAJAToolStripMenuItem_Click);
            this.lsbMascota.SelectedIndexChanged += new EventHandler(this.lsbMascota_SelectedIndexChanged);*/


        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lsbMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bAJAToolStripMenuItem.Click += new EventHandler(this.ManejadorCentral);
            this.modificacionToolStripMenuItem.Click += new EventHandler(this.ManejadorCentral);
            this.lsbMascota.SelectedIndexChanged -= new EventHandler(this.lsbMascota_SelectedIndexChanged);
        }

        private void ManejadorCentral(object sender, EventArgs e)
        {
            int indiceSeleccionado = this.lsbMascota.SelectedIndex;
            frmMascota frm = new frmMascota(this._miListaMascotas[indiceSeleccionado]);
            
            if (((ToolStripMenuItem)sender).Text == this.bAJAToolStripMenuItem.Text)
            {

                frm.Text = "Baja";
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    this._miListaMascotas.Remove(this._miListaMascotas[indiceSeleccionado]);
                    Mostrar();
                }

                this.bAJAToolStripMenuItem.Click -= new EventHandler(this.ManejadorCentral);
                this.modificacionToolStripMenuItem.Click -= new EventHandler(this.ManejadorCentral);
                this.lsbMascota.SelectedIndexChanged += new EventHandler(this.lsbMascota_SelectedIndexChanged);
            }

            if (((ToolStripMenuItem)sender).Text == this.modificacionToolStripMenuItem.Text)
            {
                frm.Text = "Modificacion";
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    this._miListaMascotas[indiceSeleccionado] = frm.miMascota;
                    Mostrar();
                }

                this.bAJAToolStripMenuItem.Click -= new EventHandler(this.ManejadorCentral);
                this.modificacionToolStripMenuItem.Click -= new EventHandler(this.ManejadorCentral);
                this.lsbMascota.SelectedIndexChanged += new EventHandler(this.lsbMascota_SelectedIndexChanged);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int i = 0;
            //while (MessageBox.Show("Exit application?", "",
            //MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    i++;
            //    this.label1.Text = i.ToString();
            //}

            //Application.Exit();


            if (this.cerrarElFormulario())
            {
                guardarArchivo();
                this.Dispose();

            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.cerrarElFormulario())
            {               
                e.Cancel = true;
            }

            guardarArchivo();
                
        }

        private bool cerrarElFormulario()
        {
            if (MessageBox.Show("Desea salir de la aplicacion", "ATENCION", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                return true;
            }
            return false;
            
        }

        private void guardarArchivo()
        {
            string path = "datos.txt";
            
            using (StreamWriter escritor = File.CreateText(path))
            {
                foreach (Mascota item in this._miListaMascotas)
                {
                    escritor.WriteLine(item.ToString());
                  
                }
                
            }
            
        }

        private void abrirArchivo()
        {
            if (File.Exists("datos.txt"))
            {
                using (StreamReader lector = File.OpenText("datos.txt"))
                {
                    string s = "";
                    string[] array;
                    while ((s = lector.ReadLine()) != null)
                    {
                        array = s.Split(' ');
                        Mascota unMascota = new Mascota(array[0], (eTipoDeMascota)Enum.Parse(typeof(eTipoDeMascota), array[1]), Convert.ToInt32(array[2]));
                        this._miListaMascotas.Add(unMascota);
                        
                    }
                    this.Mostrar();
                }
            }
        }
 
    }
}
