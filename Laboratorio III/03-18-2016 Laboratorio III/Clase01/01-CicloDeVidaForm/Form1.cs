using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _01_CicloDeVidaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Se crea la instancia del formulario...");
            MessageBox.Show("En el CONSTRUCTOR");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sale con DISPOSE...");
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario está en memoria, pero invisible...");
            MessageBox.Show("En el evento LOAD");

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
//            MessageBox.Show("El formulario recibe el foco...");
//            MessageBox.Show("en el evento ACTIVATED");

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
//            MessageBox.Show("Se 'pinta' el formulario y sus controles.");
//            MessageBox.Show("En el evento Paint");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Permite cancelar el cierre...");
            MessageBox.Show("En el evento CLOSING");

            if (MessageBox.Show("Esta seguro de salir pulsando la 'X'??", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                e.Cancel = false;
            else
            {
                e.Cancel = true;
                MessageBox.Show("Sigue en la aplicación");
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("El formulario se cerrará...");
            MessageBox.Show("En el evento CLOSED");
            
        }
    }
}
