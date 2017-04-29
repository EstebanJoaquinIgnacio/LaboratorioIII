using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento
{
    public class textBoxMejorado : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (this.Text.Length == 0 || this.Text.Length == 1 || this.Text.Length == 2)
            {
                if (((e.KeyChar < 'A' || e.KeyChar > 'Z') && e.KeyChar != (Char)Keys.Back))
                    e.Handled = true;
            }
            else if (this.Text.Length == 3 || this.Text.Length == 4 || this.Text.Length == 5)
            {
                if (((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (Char)Keys.Back))
                    e.Handled = true;
            }
            else if(e.KeyChar != (Char)Keys.Back)
                e.Handled = true;
            
            
            base.OnKeyPress(e);
        }
    }
}
