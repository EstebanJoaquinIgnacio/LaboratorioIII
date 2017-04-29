using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora
{   
    public partial class Form1 : Form
    {
        int flag = 0;
        float primerNumero;
        float segundoNumero;
        char operacion;
        public Form1()
        {
            InitializeComponent();
                        
        }

        private void AgregarColor(object sender, EventArgs e)
        {
            if ((Button)sender == this.btnReiniciar)
                this.btnReiniciar.BackColor = System.Drawing.Color.Red;
            if ((Button)sender == this.btnUno)
                this.btnUno.BackColor = System.Drawing.Color.LightBlue;
            if ((Button)sender == this.btnDos)
                this.btnDos.BackColor = System.Drawing.Color.LightBlue;
            if ((Button)sender == this.btnTres)
                this.btnTres.BackColor = System.Drawing.Color.LightBlue;
            if ((Button)sender == this.btnCuatro)
                this.btnCuatro.BackColor = System.Drawing.Color.LightBlue;
            if ((Button)sender == this.btnCinco)
                this.btnCinco.BackColor = System.Drawing.Color.LightBlue;
            if ((Button)sender == this.btnSeis)
                this.btnSeis.BackColor = System.Drawing.Color.LightBlue;
            if ((Button)sender == this.btnSiete)
                this.btnSiete.BackColor = System.Drawing.Color.LightBlue;
            if ((Button)sender == this.btnOcho)
                this.btnOcho.BackColor = System.Drawing.Color.LightBlue;
            if ((Button)sender == this.btnNueve)
                this.btnNueve.BackColor = System.Drawing.Color.LightBlue;
            if ((Button)sender == this.btnCero)
                this.btnCero.BackColor = System.Drawing.Color.LightBlue;
            if ((Button)sender == this.btnClear)
                this.btnClear.BackColor = System.Drawing.Color.Yellow;

            if ((Button)sender == this.btnSumar)
                this.btnSumar.BackColor = System.Drawing.Color.Chartreuse;
            if ((Button)sender == this.btnRestar)
                this.btnRestar.BackColor = System.Drawing.Color.Chartreuse;
            if ((Button)sender == this.btnMultiplicar)
                this.btnMultiplicar.BackColor = System.Drawing.Color.Chartreuse;
            if ((Button)sender == this.btnDividir)
                this.btnDividir.BackColor = System.Drawing.Color.Chartreuse;
            if ((Button)sender == this.btnIgual)
                this.btnIgual.BackColor = System.Drawing.Color.Violet;
        }

        private void QuitarColor(object sender, EventArgs e)
        {
            if ((Button)sender == this.btnReiniciar)
                this.btnReiniciar.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnUno)
                this.btnUno.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnDos)
                this.btnDos.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnTres)
                this.btnTres.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnCuatro)
                this.btnCuatro.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnCinco)
                this.btnCinco.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnSeis)
                this.btnSeis.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnSiete)
                this.btnSiete.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnOcho)
                this.btnOcho.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnNueve)
                this.btnNueve.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnCero)
                this.btnCero.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnClear)
                this.btnClear.BackColor = Form1.DefaultBackColor;

            if ((Button)sender == this.btnSumar)
                this.btnSumar.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnRestar)
                this.btnRestar.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnMultiplicar)
                this.btnMultiplicar.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnDividir)
                this.btnDividir.BackColor = Form1.DefaultBackColor;
            if ((Button)sender == this.btnIgual)
                this.btnIgual.BackColor = Form1.DefaultBackColor;
        }

        private void ManejadorCentral(object sender, EventArgs e)
        {
            #region //Numeros
            if ((Button)sender == this.btnUno)
            {
                this.txtDisplay.Text += "1";
            }

            if ((Button)sender == this.btnDos)
            {
                this.txtDisplay.Text += "2";
            }

            if ((Button)sender == this.btnTres)
            {
                this.txtDisplay.Text += "3";
            }

            if ((Button)sender == this.btnCuatro)
            {
                this.txtDisplay.Text += "4";
            }

            if ((Button)sender == this.btnCinco)
            {
                this.txtDisplay.Text += "5";
            }

            if ((Button)sender == this.btnSeis)
            {
                this.txtDisplay.Text += "6";
            }

            if ((Button)sender == this.btnSiete)
            {
                this.txtDisplay.Text += "7";
            }

            if ((Button)sender == this.btnOcho)
            {
                this.txtDisplay.Text += "8";
            }

            if ((Button)sender == this.btnNueve)
            {
                this.txtDisplay.Text += "9";
            }

            if ((Button)sender == this.btnCero)
            {
                this.txtDisplay.Text += "0";
            }
            #endregion
            #region //Agrego el operador
            if (this.txtDisplay.Text != "" && flag == 1 && ((Button)sender == this.btnSumar || (Button)sender == this.btnRestar || (Button)sender == this.btnMultiplicar || (Button)sender == this.btnDividir))
            {
                float.TryParse(this.txtDisplay.Text, out primerNumero);
                this.txtDisplay.Text = null;
                this.txtDisplay.Focus();
                

                if ((Button)sender == this.btnSumar)
                {
                    this.operacion = '+';
                }

                if ((Button)sender == this.btnRestar)
                {
                    this.operacion = '-';
                }

                if ((Button)sender == this.btnMultiplicar)
                {
                    this.operacion = 'x';
                }

                if ((Button)sender == this.btnDividir)
                {
                    this.operacion = '/';
                }

                this.btnSumar.Click -= new EventHandler(ManejadorCentral);
                this.btnRestar.Click -= new EventHandler(ManejadorCentral);
                this.btnMultiplicar.Click -= new EventHandler(ManejadorCentral);
                this.btnDividir.Click -= new EventHandler(ManejadorCentral);
                this.btnIgual.Click += new EventHandler(ManejadorCentral);

                flag = 2;
            }
            #endregion
            #region //Realizacion e imprecion de la operacion
            if (flag == 2 && ((Button)sender == this.btnIgual))
            {
                if(this.txtDisplay.Text != null)
                {
                    switch (this.operacion)
                    {
                        case '+':
                            float.TryParse(this.txtDisplay.Text, out this.segundoNumero);
                            this.txtDisplay.Text = Convert.ToString(this.primerNumero + this.segundoNumero);
                            break;
                        case '-':
                            float.TryParse(this.txtDisplay.Text, out this.segundoNumero);
                            this.txtDisplay.Text = Convert.ToString(this.primerNumero - this.segundoNumero);
                            break;
                        case 'x':
                            float.TryParse(this.txtDisplay.Text, out this.segundoNumero);
                            this.txtDisplay.Text = Convert.ToString(this.primerNumero * this.segundoNumero);
                            break;
                        case '/':
                            float.TryParse(this.txtDisplay.Text, out this.segundoNumero);
                            if (this.segundoNumero != 0)
                                this.txtDisplay.Text = Convert.ToString(this.primerNumero / this.segundoNumero);
                            else
                            {
                                MessageBox.Show("NO SE PUEDE DIVIDIR POR 0");
                                this.txtDisplay.Text = null;
                            }
                            break;
                        default:
                            break;
                    }
                    if (this.segundoNumero != 0)
                    {
                        this.btnIgual.Click -= new EventHandler(ManejadorCentral);
                        flag = 0;
                    }
                }

            }
            #endregion
            #region //Agregado de operadores
            if (flag == 0)
            {
                this.btnSumar.Click += new EventHandler(ManejadorCentral);
                this.btnRestar.Click += new EventHandler(ManejadorCentral);
                this.btnMultiplicar.Click += new EventHandler(ManejadorCentral);
                this.btnDividir.Click += new EventHandler(ManejadorCentral);

                this.txtDisplay.Focus();
                flag = 1;
            }
            #endregion
            #region //Limpiado de un caracter
            if (this.txtDisplay.Text.Length > 0 && flag > 0 && (Button)sender == this.btnClear)
            {
                string cadena = "";
                for (int i = 0; this.txtDisplay.Text.Length > (i + 1); i++)
                {
                    cadena += this.txtDisplay.Text[i];
                }
                this.txtDisplay.Text = cadena;
            }
            #endregion
            #region //REINICIAR
            if ((Button)sender == this.btnReiniciar)
            {
                flag = 0;
                this.txtDisplay.Text = null;
                this.btnSumar.Click -= new EventHandler(ManejadorCentral);
                this.btnRestar.Click -= new EventHandler(ManejadorCentral);
                this.btnMultiplicar.Click -= new EventHandler(ManejadorCentral);
                this.btnDividir.Click -= new EventHandler(ManejadorCentral);
                this.btnIgual.Click -= new EventHandler(ManejadorCentral);
            }
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnUno.Click += new EventHandler(ManejadorCentral);
            this.btnDos.Click += new EventHandler(ManejadorCentral);
            this.btnTres.Click += new EventHandler(ManejadorCentral);
            this.btnCuatro.Click += new EventHandler(ManejadorCentral);
            this.btnCinco.Click += new EventHandler(ManejadorCentral);
            this.btnSeis.Click += new EventHandler(ManejadorCentral);
            this.btnSiete.Click += new EventHandler(ManejadorCentral);
            this.btnOcho.Click += new EventHandler(ManejadorCentral);
            this.btnNueve.Click += new EventHandler(ManejadorCentral);
            this.btnCero.Click += new EventHandler(ManejadorCentral);
            this.btnReiniciar.Click += new EventHandler(ManejadorCentral);
            this.btnClear.Click += new EventHandler(ManejadorCentral);
            #region //agregar manejador de color
            this.btnReiniciar.MouseHover += new EventHandler(AgregarColor);
            this.btnReiniciar.MouseLeave += new EventHandler(QuitarColor);
            this.btnUno.MouseHover += new EventHandler(AgregarColor);
            this.btnUno.MouseLeave += new EventHandler(QuitarColor);
            this.btnDos.MouseHover += new EventHandler(AgregarColor);
            this.btnDos.MouseLeave += new EventHandler(QuitarColor);
            this.btnTres.MouseHover += new EventHandler(AgregarColor);
            this.btnTres.MouseLeave += new EventHandler(QuitarColor);
            this.btnCuatro.MouseHover += new EventHandler(AgregarColor);
            this.btnCuatro.MouseLeave += new EventHandler(QuitarColor);
            this.btnCinco.MouseHover += new EventHandler(AgregarColor);
            this.btnCinco.MouseLeave += new EventHandler(QuitarColor);
            this.btnSeis.MouseHover += new EventHandler(AgregarColor);
            this.btnSeis.MouseLeave += new EventHandler(QuitarColor);
            this.btnSiete.MouseHover += new EventHandler(AgregarColor);
            this.btnSiete.MouseLeave += new EventHandler(QuitarColor);
            this.btnOcho.MouseHover += new EventHandler(AgregarColor);
            this.btnOcho.MouseLeave += new EventHandler(QuitarColor);
            this.btnNueve.MouseHover += new EventHandler(AgregarColor);
            this.btnNueve.MouseLeave += new EventHandler(QuitarColor);
            this.btnCero.MouseHover += new EventHandler(AgregarColor);
            this.btnCero.MouseLeave += new EventHandler(QuitarColor);
            this.btnClear.MouseHover += new EventHandler(AgregarColor);
            this.btnClear.MouseLeave += new EventHandler(QuitarColor);

            this.btnSumar.MouseHover += new EventHandler(AgregarColor);
            this.btnSumar.MouseLeave += new EventHandler(QuitarColor);
            this.btnRestar.MouseHover += new EventHandler(AgregarColor);
            this.btnRestar.MouseLeave += new EventHandler(QuitarColor);
            this.btnMultiplicar.MouseHover += new EventHandler(AgregarColor);
            this.btnMultiplicar.MouseLeave += new EventHandler(QuitarColor);
            this.btnDividir.MouseHover += new EventHandler(AgregarColor);
            this.btnDividir.MouseLeave += new EventHandler(QuitarColor);
            this.btnIgual.MouseHover += new EventHandler(AgregarColor);
            this.btnIgual.MouseLeave += new EventHandler(QuitarColor);

            #endregion
        }

        private void btnUno_Click(object sender, EventArgs e)
        {

        }

        private void btnDos_Click(object sender, EventArgs e)
        {

        }

        private void btnTres_Click(object sender, EventArgs e)
        {

        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {

        }

        private void btnSiete_Click(object sender, EventArgs e)
        {

        }

        private void btnOcho_Click(object sender, EventArgs e)
        {

        }

        private void btnNueve_Click(object sender, EventArgs e)
        {

        }

        private void btnCero_Click(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
