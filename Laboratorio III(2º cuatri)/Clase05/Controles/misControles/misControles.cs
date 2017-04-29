using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace misControles
{
    public class txtSoloNumeros:TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
    }

    public enum ETipoDato { 
        Entero,
        Doble,
        Binario,
        Octal,
        Hexadecimal
    }

    public class txtSoloNumerosMejorado : TextBox
    {
        public ETipoDato TipoDeDato { get;set;}
        

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (TipoDeDato)
            {
                case ETipoDato.Entero:
                    if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                    break;
                case ETipoDato.Doble:
                    if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back && e.KeyChar != ',')
                    {
                        e.Handled = true;
                    }

                    break;
                case ETipoDato.Binario:
                    if (e.KeyChar != (Char)Keys.Back && e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != ',')
                    {
                        e.Handled = true;
                    }
                    break;
                case ETipoDato.Octal:
                    if (e.KeyChar != (Char)Keys.Back && ((Char)Keys.D0 > e.KeyChar || (Char)Keys.D7 < e.KeyChar) && e.KeyChar != ',')
                    {
                        e.Handled = true;
                    }
                    break;
                case ETipoDato.Hexadecimal:
                    if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back && e.KeyChar != ',' && ((Char)Keys.A > e.KeyChar || (Char)Keys.F < e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
                default:
                    break;
            }

            base.OnKeyPress(e);
        }
    }
}
