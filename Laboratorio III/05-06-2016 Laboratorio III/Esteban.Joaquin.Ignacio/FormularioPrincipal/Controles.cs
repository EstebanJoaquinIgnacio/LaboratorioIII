using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FormularioPrincipal
{
    public class SoloNumeros : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar < (char)Keys.D0 || e.KeyChar > (char)Keys.D9) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

            base.OnKeyPress(e);
        }
    }

    public class SoloLetras : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if(!(Char.IsLetter(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
            base.OnKeyPress(e);
        }
    }
}
