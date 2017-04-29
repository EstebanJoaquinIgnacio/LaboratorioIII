using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_ejemplo_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string TextoDelFormulario) : this()
        {
            this.Text = TextoDelFormulario; //Cambio el valor que muestra el formulario
            this.lblNombre.Text = "Ingrese su nombre: ";
            this.btnMostrar.Text = "&Mostrar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.txtNombre.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo");
        }

        private void brnOtroFormulario_Click(object sender, EventArgs e)
        {
            Form otroForm = new Form(); //Creo otro form. Si cierro el principal me cierra los otros form
            otroForm.Show();    //Muestro el nuevo form, lo cual me abre otro.
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ATENCION", "Esta seguro de cerrar la aplicación: ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
