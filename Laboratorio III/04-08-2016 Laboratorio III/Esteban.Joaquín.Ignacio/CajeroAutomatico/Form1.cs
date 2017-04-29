using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            int dinero;
            int.TryParse(this.textBox1.Text, out dinero);
            int cant100 = 0;
            int cant50 = 0;
            int cant20 = 0;
            int cant10 = 0;
            int cant5 = 0;
            int cant2 = 0;
            int resto = 0;
            if ((dinero / 100) >= 1)
            {
                cant100 = (int)dinero / 100;
                dinero %= 100;
                resto = dinero % 100;
            }
            if ((dinero / 50) >= 1)
            {
                cant50 = (int)dinero / 50;
                dinero %= 50;
                resto = dinero % 50;
            }
            if ((dinero / 20) >= 1)
            {
                cant20 = (int)dinero / 20;
                dinero %= 20;
                resto = dinero % 20;
            }
            if ((dinero / 10) >= 1)
            {
                cant10 = (int)dinero / 10;
                dinero %= 10;
                resto = dinero % 10;
            }
            if ((dinero / 5) >= 1)
            {
                cant5 = (int)dinero / 5;
                dinero %= 5;
                resto = dinero % 5;
            }
            if ((dinero / 2) >= 1)
            {
                cant2 = (int)dinero / 2;
                dinero %= 2;
                resto = dinero % 2;
            }

            this.textBox2.Text = cant2.ToString();
            this.textBox3.Text = cant5.ToString();
            this.textBox4.Text = cant10.ToString();
            this.textBox5.Text = cant20.ToString();
            this.textBox6.Text = cant50.ToString();
            this.textBox7.Text = cant100.ToString();
            this.btnAceptar.Click -= new EventHandler(Calcular);
            this.btnLimpiar.Click += new EventHandler(Limpiar);
            this.btnAceptar.Click += new EventHandler(Informar);
            MessageBox.Show("El resto es: " + resto, "Vuelto");


        }

        private void Limpiar(object sender, EventArgs e)
        {
            this.textBox1.Text = null;

            foreach (Control queControl in this.groupBox2.Controls)
            {
                if (queControl is TextBox)
                {
                    ((TextBox)queControl).Text = null;                
                }

            }
            this.btnAceptar.Click += new EventHandler(Calcular);
            this.btnLimpiar.Click -= new EventHandler(Limpiar);
            this.btnAceptar.Click -= new EventHandler(Informar);
        }

        private void Informar(object sender, EventArgs e)
        {
            MessageBox.Show("debe limpiar la pantalla antes de seguir operando", "información");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.btnAceptar.Click += new EventHandler(Calcular); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
