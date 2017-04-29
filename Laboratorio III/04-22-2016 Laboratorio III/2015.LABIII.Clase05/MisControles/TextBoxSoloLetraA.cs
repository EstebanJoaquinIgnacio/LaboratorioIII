using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MisControles
{
    public class TextBoxSoloLetraA : TextBoxColores
    {

       protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)System.Windows.Forms.Keys.A)
            {
                //CON HANDLED = TRUE, EL O.S. NO ESCRIBE EL CARACTER.
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }
    }
}
