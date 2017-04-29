using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MisControles
{
    public class TextBoxElegirLetra:System.Windows.Forms.TextBox
    {
        public Char QueLetra { get; set; }

        public TextBoxElegirLetra()
        {
            this.QueLetra = 'A';
        }

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar != this.QueLetra)
            {
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }
    }
}
