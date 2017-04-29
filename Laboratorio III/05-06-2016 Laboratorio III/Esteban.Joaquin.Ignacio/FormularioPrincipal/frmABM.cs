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
using System.IO;
using FormularioPrincipal;

namespace FormularioPrincipal
{
    public enum eTipoDeOrdenamiento
    { 
        porEdad,
        porNombre,
        porTipo
    }

    public partial class frmABM : Form
    {
        //public delegate void actualizarListadosDelegado(List<Mascota> listaMascotas);
        

        private List<Mascota> _miListaMascotas;
        bool flagAgregarManejador = false;
                

        public frmABM()
        {
            InitializeComponent();
            this._miListaMascotas = new List<Mascota>();

            if(File.Exists("ABM.txt"))
            {
                StreamReader lector = new StreamReader("ABM.txt");
                        
                while (!lector.EndOfStream) 
                {
                    string lecturaArchivo = lector.ReadLine();
                    string[] descomposicion = lecturaArchivo.Split('-');
                    Mascota mascotaLeida = new Mascota(descomposicion[0], (eTipoDeMascota)Enum.Parse(typeof(eTipoDeMascota), descomposicion[1]), Convert.ToInt32(descomposicion[2]));
                    this._miListaMascotas.Add(mascotaLeida);
                }

                this.mostrarLista();
                lector.Close();
            }

            

            //MessageBox.Show(descomposicion[0] + " " + descomposicion[1]);

            foreach (string tipo in Enum.GetNames(typeof(eTipoDeOrdenamiento)))
            {
                this.cmbOrdenamiento.Items.Add(tipo);
            }
            this.cmbOrdenamiento.SelectedIndex = 0;
            

            //this.lbxABM.SelectedIndexChanged += new EventHandler(this.lbxABM_SelectedIndexChanged);
            this.bajaToolStripMenuItem.Click -= this.bajaToolStripMenuItem_Click;
            this.modificarToolStripMenuItem.Click -= this.modificarToolStripMenuItem_Click;
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMascota darAlta = new frmMascota();
            darAlta.ShowDialog();
            if (darAlta.DialogResult == DialogResult.OK)
            {
                this._miListaMascotas.Add(darAlta.miMascota);
                this.mostrarLista();             
                
            }

            if (this.flagAgregarManejador == true)
            {
                this.modificarToolStripMenuItem.Click -= this.modificarToolStripMenuItem_Click;
                this.bajaToolStripMenuItem.Click -= this.bajaToolStripMenuItem_Click;

                this.lbxABM.SelectedIndexChanged += this.lbxABM_SelectedIndexChanged;

                this.flagAgregarManejador = false;
            }
        }

        private void mostrarLista()
        {
            /*frmMostrar formularioMuestra = new frmMostrar();
            frmMostrar.MostrarListaPorDelegado += new (formularioMuestra.actualizarListados);*/
            
            this.lbxABM.Items.Clear();
            foreach (var item in this._miListaMascotas)
            {
                this.lbxABM.Items.Add(item);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Guardar?", "GUARDAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StreamWriter escritor = new StreamWriter("ABM.txt");
                foreach (var item in this._miListaMascotas)
                {
                    escritor.WriteLine(item);
                }                    
                escritor.Close();
                this.Close();
            }
        }

        private void lbxABM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(flagAgregarManejador == false)
            {
                this.modificarToolStripMenuItem.Click += this.modificarToolStripMenuItem_Click;
                this.bajaToolStripMenuItem.Click += this.bajaToolStripMenuItem_Click;
                
                this.lbxABM.SelectedIndexChanged -= this.lbxABM_SelectedIndexChanged;

                this.flagAgregarManejador = true;
            }            
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indice = this.lbxABM.SelectedIndex;            

            frmMascota Baja = new frmMascota(this._miListaMascotas[indice]);
            Baja.Text = "Baja";

            Baja.ShowDialog();
            if (Baja.DialogResult == DialogResult.OK)
                this._miListaMascotas.Remove(this._miListaMascotas[indice]);

            this.mostrarLista();

            this.modificarToolStripMenuItem.Click -= this.modificarToolStripMenuItem_Click;
            this.bajaToolStripMenuItem.Click -= this.bajaToolStripMenuItem_Click;

            this.lbxABM.SelectedIndexChanged += this.lbxABM_SelectedIndexChanged;

            this.flagAgregarManejador = false;            
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indice = this.lbxABM.SelectedIndex;

            frmMascota Modificacion = new frmMascota(this._miListaMascotas[indice]);
            Modificacion.Text = "Modificación";

            Modificacion.ShowDialog();
            if (Modificacion.DialogResult == DialogResult.OK)
            {
                this._miListaMascotas[indice] = Modificacion.miMascota;

                this.mostrarLista();

                this.modificarToolStripMenuItem.Click -= this.modificarToolStripMenuItem_Click;
                this.bajaToolStripMenuItem.Click -= this.bajaToolStripMenuItem_Click;

                this.lbxABM.SelectedIndexChanged += this.lbxABM_SelectedIndexChanged;

                this.flagAgregarManejador = false;
            }
            
        }
        
        private void frmABM_Load(object sender, EventArgs e)
        {

        }

        private void frmABM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "SALIR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StreamWriter escritor = new StreamWriter("ABM.txt");
                foreach (var item in this._miListaMascotas)
                {
                    escritor.WriteLine(item);
                }
                escritor.Close();
            }
            else
                e.Cancel = true;
            
        }
    }
}
