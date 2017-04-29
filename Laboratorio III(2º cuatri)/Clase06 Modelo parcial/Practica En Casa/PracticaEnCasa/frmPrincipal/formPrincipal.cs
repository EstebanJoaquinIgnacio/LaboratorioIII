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

namespace frmPrincipal
{
    enum EtipoDeOrdenamiento
    { 
        porEdad,
        porNombre,
        porTipo
    }

    public partial class formPrincipal : Form
    {        

        private List<Mascota> _miListaDeMascotas;

        public formPrincipal()
        {
            InitializeComponent();
            this._miListaDeMascotas = new List<Mascota>();
            this.cmbOrdenar.DataSource = Enum.GetValues(typeof(EtipoDeOrdenamiento));
            this.abrirArchivo();
            //this.bajaToolStripMenuItem.Click -= new EventHandler(this.bajaToolStripMenuItem_Click);
            //this.modificacionToolStripMenuItem.Click -= new EventHandler(this.modificacionToolStripMenuItem_Click);           
                        
        }

        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.cmbOrdenar.SelectedIndex;
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

            this._miListaDeMascotas.Sort(comparar);
            this.Mostrar();

        }

        private void Mostrar()
        {
            this.lsbPrincipal.Items.Clear();
            foreach (Mascota item in this._miListaDeMascotas)
            {
                this.lsbPrincipal.Items.Add(item);
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMascota alta = new FrmMascota();
            alta.ShowDialog();

            if (alta.DialogResult == DialogResult.OK)
            {
                this._miListaDeMascotas.Add(alta.miMascota);
                this.Mostrar();
            }
        }
        
        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //this.bajaToolStripMenuItem.Click -= new EventHandler(this.bajaToolStripMenuItem_Click);            
            //this.lsbPrincipal.SelectedIndexChanged += new EventHandler(this.lsbPrincipal_SelectedIndexChanged);
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            //this.modificacionToolStripMenuItem.Click -= new EventHandler(this.modificacionToolStripMenuItem_Click);
            //this.lsbPrincipal.SelectedIndexChanged += new EventHandler(this.lsbPrincipal_SelectedIndexChanged);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.deseaSalir())
            {
                this.guardarEnArchivo();
                this.Dispose();
            }

        }

        private void lsbPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bajaToolStripMenuItem.Click += new EventHandler(this.ManejadorCentral);
            this.modificacionToolStripMenuItem.Click += new EventHandler(this.ManejadorCentral);
            this.lsbPrincipal.SelectedIndexChanged -= new EventHandler(this.lsbPrincipal_SelectedIndexChanged);
        }

        private void ManejadorCentral(object sender, EventArgs e)
        {
            int indice = this.lsbPrincipal.SelectedIndex;
            FrmMascota form = new FrmMascota(this._miListaDeMascotas[indice]);

            switch (((ToolStripMenuItem)sender).Text)
	        {
                case "Baja":
                    form.Text = "Baja";
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.OK)
                    {
                        this._miListaDeMascotas.Remove(this._miListaDeMascotas[indice]);
                    }

                    //MessageBox.Show("Baja");
                    break;
                case "Modificacion":
                    form.Text = "Modificacion";
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.OK)
                    {
                        this._miListaDeMascotas[indice] = form.miMascota;
                    }
                    //MessageBox.Show("Modificacion");
                    break;
		        default:
                    break;
	        }

            this.Mostrar();
            this.bajaToolStripMenuItem.Click -= new EventHandler(this.ManejadorCentral);
            this.modificacionToolStripMenuItem.Click -= new EventHandler(this.ManejadorCentral);
            this.lsbPrincipal.SelectedIndexChanged += new EventHandler(this.lsbPrincipal_SelectedIndexChanged);
        }

        private bool deseaSalir()
        { 
            if((MessageBox.Show("Quiere salir","ADVERTENCIA",MessageBoxButtons.OKCancel))==DialogResult.OK)            
                return true;
            
            return false;
        }

        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.deseaSalir())
                e.Cancel = true;
            this.guardarEnArchivo();
        }

        private void guardarEnArchivo()
        {
            string path = "Datos.txt";

            using (StreamWriter escritor = File.CreateText(path))
            {
                foreach (Mascota item in this._miListaDeMascotas)
                {
                    escritor.WriteLine(item.ToString());
                }
            }
        }

        private void abrirArchivo()
        {
            string path = "Datos.txt";
            string cadena;
            string[] array;
            Mascota unaMascota;

            if (File.Exists(path))
            {
                using (StreamReader lector = File.OpenText(path))
                {
                    while (!lector.EndOfStream)
                    {
                        cadena = lector.ReadLine();
                        array = cadena.Split(' ');
                        unaMascota = new Mascota(array[0], (eTipoDeMascota)Enum.Parse(typeof(eTipoDeMascota),array[1]), Convert.ToInt32(array[2]));
                        this._miListaDeMascotas.Add(unaMascota);
                    }
                    this.Mostrar();
                    
                }
            }
        }
    }
}
