using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejarEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(this.ManejadorCentral);

        }

        private void ManejadorCentral(object sender, EventArgs e)
        {
            this.label1.Text = "ESTOY EN EL BOTON " + ((Button)sender).Name;
            MessageBox.Show("Soy el boton: " + ((Button)sender).Name, "ADVERTENCIA");
            switch (((Button)sender).Name)
            {
                     
                case "button1":
                    //MessageBox.Show("Soy el boton: " + ((Button)sender).Name, "ADVERTENCIA");                 
                    this.button1.Click -= new EventHandler(this.ManejadorCentral);
                    this.button2.Click += new EventHandler(this.ManejadorCentral);
                    this.button2.Focus();
                    break;
                case "button2":
                    //MessageBox.Show("Soy el boton: " + ((Button)sender).Name, "ADVERTENCIA");
                    this.button2.Click -= new EventHandler(this.ManejadorCentral);
                    this.button3.Click += new EventHandler(this.ManejadorCentral);
                    this.button3.Focus();
                    break;
                case "button3":
                    //MessageBox.Show("Soy el boton: " + ((Button)sender).Name, "ADVERTENCIA");
                    this.button3.Click -= new EventHandler(this.ManejadorCentral);
                    this.button4.Click += new EventHandler(this.ManejadorCentral);
                    this.button4.Focus();
                    break;
                case "button4":
                    //MessageBox.Show("Soy el boton: " + ((Button)sender).Name, "ADVERTENCIA");
                    this.button4.Click -= new EventHandler(this.ManejadorCentral);
                    this.button1.Click += new EventHandler(this.ManejadorCentral);
                    this.button1.Focus();
                    break;
                default:
                    MessageBox.Show("ENTRO A DEFAULT");
                    break;
            }           


        }



        private void button1_Leave(object sender, EventArgs e)
        {
            Random miNumero = new Random();
            int num = miNumero.Next(1, 10);
            Color miColor = new Color();
            switch (num)
            {
                case 1:
                    miColor = Color.BlueViolet;
                    break;
                case 2:
                    miColor = Color.Red;
                    break;
                case 3:
                    miColor = Color.Purple;
                    break;
                case 4:
                    miColor = Color.Pink;
                    break;
                case 5:
                    miColor = Color.Silver;
                    break;
                case 6:
                    miColor = Color.Gold;
                    break;
                case 7:
                    miColor = Color.Green;
                    break;
                case 8:
                    miColor = Color.Yellow;
                    break;
                case 9:
                    miColor = Color.Tomato;
                    break;
                case 10:
                    miColor = Color.Tan;
                    break;

                default:
                    break;
            }

            this.button1.BackColor = miColor;
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            Random miNumero = new Random();
            int num = miNumero.Next(1, 10);
            Color miColor = new Color();
            switch (num)
            {
                case 1:
                    miColor = Color.BlueViolet;
                    break;
                case 2:
                    miColor = Color.Red;
                    break;
                case 3:
                    miColor = Color.Purple;
                    break;
                case 4:
                    miColor = Color.Pink;
                    break;
                case 5:
                    miColor = Color.Silver;
                    break;
                case 6:
                    miColor = Color.Gold;
                    break;
                case 7:
                    miColor = Color.Green;
                    break;
                case 8:
                    miColor = Color.Yellow;
                    break;
                case 9:
                    miColor = Color.Tomato;
                    break;
                case 10:
                    miColor = Color.Tan;
                    break;

                default:
                    break;
            }

            this.button2.BackColor = miColor;
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            Random miNumero = new Random();
            int num = miNumero.Next(1, 10);
            Color miColor = new Color();
            switch (num)
            {
                case 1:
                    miColor = Color.BlueViolet;
                    break;
                case 2:
                    miColor = Color.Red;
                    break;
                case 3:
                    miColor = Color.Purple;
                    break;
                case 4:
                    miColor = Color.Pink;
                    break;
                case 5:
                    miColor = Color.Silver;
                    break;
                case 6:
                    miColor = Color.Gold;
                    break;
                case 7:
                    miColor = Color.Green;
                    break;
                case 8:
                    miColor = Color.Yellow;
                    break;
                case 9:
                    miColor = Color.Tomato;
                    break;
                case 10:
                    miColor = Color.Tan;
                    break;

                default:
                    break;
            }

            this.button3.BackColor = miColor;
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            Random miNumero = new Random();
            int num = miNumero.Next(1, 10);
            Color miColor = new Color();
            switch (num)
            {
                case 1:
                    miColor = Color.BlueViolet;
                    break;
                case 2:
                    miColor = Color.Red;
                    break;
                case 3:
                    miColor = Color.Purple;
                    break;
                case 4:
                    miColor = Color.Pink;
                    break;
                case 5:
                    miColor = Color.Silver;
                    break;
                case 6:
                    miColor = Color.Gold;
                    break;
                case 7:
                    miColor = Color.Green;
                    break;
                case 8:
                    miColor = Color.Yellow;
                    break;
                case 9:
                    miColor = Color.Tomato;
                    break;
                case 10:
                    miColor = Color.Tan;
                    break;

                default:
                    break;
            }

            this.button4.BackColor = miColor;
        }
    }
}
