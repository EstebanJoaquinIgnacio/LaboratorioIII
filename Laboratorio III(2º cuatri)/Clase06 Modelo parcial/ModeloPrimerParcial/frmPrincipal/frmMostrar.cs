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
    public partial class frmMostrar : Form
    {
        

        public frmMostrar()
        {
            InitializeComponent();
            actualizamela = new Actualizar(ActualizarListados);   
        }

        public void ActualizarListados(List<Mascota> listaMascota)
        {
            foreach (Mascota item in listaMascota)
	        {
                this.lbxMostrar.Items.Add(item);
	        }

            this.ShowDialog();
        }

        public delegate void Actualizar(List<Mascota> listaMascota);

        public Actualizar actualizamela;

    }
}
