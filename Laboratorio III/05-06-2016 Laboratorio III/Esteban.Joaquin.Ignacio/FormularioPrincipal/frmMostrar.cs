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
    public partial class frmMostrar : Form
    {
        /*public delegate void actualizarListadosDelegado(List<Mascota> listaMascotas);
        public static event actualizarListadosDelegado MostrarListaPorDelegado;*/

        public frmMostrar()
        {
            InitializeComponent();

        }

        public void actualizarListados(List<Mascota> listaMascotas)
        {
            this.ltbMostrar.Items.Clear();
            foreach (var item in listaMascotas)
            {
                this.ltbMostrar.Items.Add(item);
            }
        }

        
    }
}
