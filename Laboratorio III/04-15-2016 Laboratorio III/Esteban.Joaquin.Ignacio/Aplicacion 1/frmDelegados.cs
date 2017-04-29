using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delegado;
using System.IO;

namespace Aplicacion_1
{
    public partial class frmTestDelegados : Form
    {

        public static event CambiarNombreDel cambiarNombreDelLabel;
        public static event CambiarNombreDel actualizarFotoPorDelegado;
        private string miPath = null;

        public frmTestDelegados()
        {
            InitializeComponent();
            this.ConfigurarOpenSaveFileDialog();
        }

        private void ConfigurarOpenSaveFileDialog()
        {
            this.ofdBuscarFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);            
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {

            cambiarNombreDelLabel(this.txtTextDelegados.Text);
            if (this.miPath != null)
            {
                if(Path.GetExtension(miPath) == ".jpg" )
                    actualizarFotoPorDelegado(miPath);
            }

        }

        private void frmTestDelegados_Load(object sender, EventArgs e)
        {

        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog miFile = new OpenFileDialog();
            if (ofdBuscarFoto.ShowDialog() == DialogResult.OK)
            {
                miPath = this.ofdBuscarFoto.FileName;
                // pictureBox1.Image = Image.FromFile(Path);
                
            }

        }

        private void ofdBuscarFoto_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
