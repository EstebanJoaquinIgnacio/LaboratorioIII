using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MisControles
{
    public enum TipoTexto
    {
        Mayúscula,
        Minúscula,
        Ninguno
    }

    public class TextBoxMayusculaMinuscula : System.Windows.Forms.TextBox
    {
        public TipoTexto TipoDeTexto { get; set; }

        public TextBoxMayusculaMinuscula()
        {
            this.TipoDeTexto = TipoTexto.Ninguno;
        }

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            e.KeyChar = CambiarTipoDeTexo(e.KeyChar);

            base.OnKeyPress(e);
        }

        private Char CambiarTipoDeTexo(Char letra)
        {
            switch (this.TipoDeTexto)
            {
                case TipoTexto.Mayúscula:
                    letra = Char.ToUpper(letra);
                    break;
                case TipoTexto.Minúscula:
                    letra = Char.ToLower(letra);
                    break;
                case TipoTexto.Ninguno:
                    break;
                default:
                    break;
            }

            return letra;
        }
    }
}
