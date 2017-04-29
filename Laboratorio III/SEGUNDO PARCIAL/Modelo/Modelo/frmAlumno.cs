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

namespace Modelo
{
    public partial class frmAlumno : Form
    {
        private Alumno _miAlumno;
        public Alumno miAlumno {
            get { return this._miAlumno; }
        }
        public frmAlumno()
        {
            InitializeComponent();
            //Agrego el evento del dialog para usar el modal de los formularios para el ABM
            this.button1.Click += new EventHandler(Aceptar);
            this.button2.Click += new EventHandler(Cancelar);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Aceptar(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "" && this.textBox2.Text != "") //Verifo 
            {
                this._miAlumno = new Alumno(Convert.ToInt32(this.comboBox1.Text), Convert.ToInt32(this.textBox2.Text), this.textBox1.Text);
                this.DialogResult = DialogResult.OK; 
            }
        }
        private void Cancelar(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
