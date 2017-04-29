using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlDeUsuario._05
{
    public partial class usrConvertidorCF : UserControl
    {
        public usrConvertidorCF()
        {
            InitializeComponent();
        }

        private void txtCelcius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)System.Windows.Forms.Keys.Enter)
            {
                this.txtFahrenheit.Text = ConvertirCelciusFahrenheit(double.Parse(this.txtCelcius.Text)).ToString();   
            }
        }

        private double ConvertirCelciusFahrenheit(double grados)
        {
            return grados * 1.8 + 32;
        }
    }
}
