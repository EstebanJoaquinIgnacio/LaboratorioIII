using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesMios
{
    public class SoloNumeros : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
            base.OnKeyPress(e);
        }
    }

    public class SoloLetras : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
            base.OnKeyPress(e);
        }
    }
}
