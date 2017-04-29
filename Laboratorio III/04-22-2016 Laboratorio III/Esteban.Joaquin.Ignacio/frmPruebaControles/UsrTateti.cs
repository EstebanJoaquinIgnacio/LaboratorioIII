using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace frmPruebaControles
{
    public partial class UsrTateti : UserControl
    {
        bool activo = true;
             
        public UsrTateti()
        {
            InitializeComponent();
                     
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                    c.Click += new EventHandler(EscribirValor);
                    c.Click += new EventHandler(quienGano);
                   
                }
            }
        }

        public void EscribirValor(Object sender, EventArgs e)
        {
            if (activo)
            {
                ((Button)sender).Text = "X";
                activo = false;
            }
            else
            {
                ((Button)sender).Text = "O";
                activo = true;
            }
        }

        public void quienGano(object sender, EventArgs e)
        { 
            //filas
            if(this.button1.Text == "X" && this.button2.Text == "X" && this.button3.Text == "X")
                MensajeGanador("X GANO!!!");
            if (this.button4.Text == "X" && this.button5.Text == "X" && this.button6.Text == "X")
                MensajeGanador("X GANO!!!");
            if (this.button7.Text == "X" && this.button8.Text == "X" && this.button9.Text == "X")
                MensajeGanador("X GANO!!!");
            if(this.button1.Text == "O" && this.button2.Text == "O" && this.button3.Text == "O")
                MensajeGanador("O GANO!!!");
            if (this.button4.Text == "O" && this.button5.Text == "O" && this.button6.Text == "O")
                MensajeGanador("O GANO!!!");
            if (this.button7.Text == "O" && this.button8.Text == "O" && this.button9.Text == "O")
                MensajeGanador("O GANO!!!");

            //Columnas
            if (this.button1.Text == "X" && this.button4.Text == "X" && this.button7.Text == "X")
                MensajeGanador("X GANO!!!");
            if (this.button2.Text == "X" && this.button5.Text == "X" && this.button8.Text == "X")
                MensajeGanador("X GANO!!!");
            if (this.button3.Text == "X" && this.button6.Text == "X" && this.button9.Text == "X")
                MensajeGanador("X GANO!!!");
            if (this.button1.Text == "O" && this.button4.Text == "O" && this.button7.Text == "O")
                MensajeGanador("O GANO!!!");
            if (this.button2.Text == "O" && this.button5.Text == "O" && this.button8.Text == "O")
                MensajeGanador("O GANO!!!");
            if (this.button3.Text == "O" && this.button6.Text == "O" && this.button9.Text == "O")
                MensajeGanador("O GANO!!!");

            //diagonal
            if (this.button1.Text == "X" && this.button5.Text == "X" && this.button9.Text == "X")
                MensajeGanador("X GANO!!!");
            if (this.button3.Text == "X" && this.button5.Text == "X" && this.button7.Text == "X")
                MensajeGanador("X GANO!!!");
            if (this.button1.Text == "O" && this.button5.Text == "O" && this.button9.Text == "O")
                MensajeGanador("O GANO!!!");
            if (this.button3.Text == "O" && this.button5.Text == "O" && this.button7.Text == "O")
                MensajeGanador("O GANO!!!");

            //Empate
            if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "")
                MensajeGanador("EMPATE!!!");

        }

        public void MensajeGanador(string elGanador)
        {

            if (File.Exists("ResultadoTateti.txt"))
            {
                StreamReader Lectura = new StreamReader("ResultadoTateti.txt");
                string leido = Lectura.ReadToEnd();
                Lectura.Close();
                StreamWriter Escritura = new StreamWriter("ResultadoTateti.txt");
                Escritura.WriteLine(leido + "Fecha: " + DateTime.Now + " " + elGanador);
                Escritura.Close();
            }
            else
            {
                StreamWriter Escritura = new StreamWriter("ResultadoTateti.txt");
                Escritura.WriteLine("Fecha: " + DateTime.Now + " " + elGanador);
                Escritura.Close();
            }


            MessageBox.Show("El resultado es: " +  " " + elGanador);

            reset();
        }

        private void reset()
        {
            this.activo = true;

            foreach (Button C in this.Controls)
            { 
                ((Button)C).Text = "";
            }
        }

        private void UsrTateti_Load(object sender, EventArgs e)
        {
            
        }
    }
}
