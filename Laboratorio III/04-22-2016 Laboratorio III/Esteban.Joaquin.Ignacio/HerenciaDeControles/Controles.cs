using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace HerenciaDeControles
{
    static class Globales
    {
        public static bool flagPunto;

        public static void Inicializar()
        {
            flagPunto = false;
 
        }
    }

    public class txtSoloNumeros : System.Windows.Forms.TextBox
    {
        
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar < (Char)System.Windows.Forms.Keys.D0 || e.KeyChar > (Char)System.Windows.Forms.Keys.D9) && e.KeyChar != (Char)System.Windows.Forms.Keys.Back && e.KeyChar != 46)
                e.Handled = true;
            if (Globales.flagPunto == true && e.KeyChar == 46)
                e.Handled = true;
            if (Globales.flagPunto == false && e.KeyChar == 46)
                Globales.flagPunto = true;   

 	        base.OnKeyPress(e);
        }
        
    }

    public enum ETipoDato
    { 
        Entero,
        Doble,
        Binario,
        Octal,
        Hexadecimal
    }

    public class txtNumerosMejorados : System.Windows.Forms.TextBox
    {
        
        public ETipoDato queTipoDatos { set; get; }
        
        
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            
            
          
            switch (this.queTipoDatos)
            {
                case ETipoDato.Entero:
                    if ((e.KeyChar < (Char)System.Windows.Forms.Keys.D0 || e.KeyChar > (Char)System.Windows.Forms.Keys.D9) && e.KeyChar != (Char)System.Windows.Forms.Keys.Back)
                        e.Handled = true;             
                        break;
                case ETipoDato.Doble:
                    if ((e.KeyChar < (Char)System.Windows.Forms.Keys.D0 || e.KeyChar > (Char)System.Windows.Forms.Keys.D9) && e.KeyChar != (Char)System.Windows.Forms.Keys.Back && e.KeyChar != 46)
                        e.Handled = true;             
                    if (Globales.flagPunto == true && e.KeyChar == 46)
                        e.Handled = true;
                    if (Globales.flagPunto == false && e.KeyChar == 46)
                        Globales.flagPunto = true;  
                    break;
                case ETipoDato.Binario:
                    if(e.KeyChar != (Char)System.Windows.Forms.Keys.D0 && e.KeyChar != (Char)System.Windows.Forms.Keys.D1 && e.KeyChar != (Char)System.Windows.Forms.Keys.Back && e.KeyChar != 46)
                        e.Handled = true;
                    if (Globales.flagPunto == true && e.KeyChar == 46)
                        e.Handled = true;
                    if (Globales.flagPunto == false && e.KeyChar == 46)
                        Globales.flagPunto = true;  
                        break;
                case ETipoDato.Octal:
                        if ((e.KeyChar < (Char)System.Windows.Forms.Keys.D0 || e.KeyChar > (Char)System.Windows.Forms.Keys.D7) && e.KeyChar != (Char)System.Windows.Forms.Keys.Back && e.KeyChar != 46)
                            e.Handled = true;
                        if (Globales.flagPunto == true && e.KeyChar == 46)
                            e.Handled = true;
                        if (Globales.flagPunto == false && e.KeyChar == 46)
                            Globales.flagPunto = true;  
                        break;
                case ETipoDato.Hexadecimal:
                    if((e.KeyChar < (Char)System.Windows.Forms.Keys.A || e.KeyChar > (Char)System.Windows.Forms.Keys.F) && (e.KeyChar < (Char)System.Windows.Forms.Keys.D0 || e.KeyChar > (Char)System.Windows.Forms.Keys.D9) && e.KeyChar != (Char)System.Windows.Forms.Keys.Back && e.KeyChar != 46)
                        e.Handled = true;
                    if (Globales.flagPunto == true && e.KeyChar == 46)
                        e.Handled = true;
                    if (Globales.flagPunto == false && e.KeyChar == 46)
                        Globales.flagPunto = true;  
                        break;
                default:
                    break;
            }

            base.OnKeyPress(e);
        }
    }

    

    public class txtTextoOculto : System.Windows.Forms.TextBox
    {
       public System.Windows.Forms.Keys caracterOculto{get; set;}
       protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
       {
            if (e.KeyChar == (Char)this.caracterOculto)
                e.Handled = true;
            base.OnKeyPress(e);
       }
    }

    public delegate void TeclaPrecionada();    

    public class TxtBoxLogin : System.Windows.Forms.TextBox
    {
        private event TeclaPrecionada AvisarCapsLock;
        ErrorProvider error = new ErrorProvider();
        
        private void avisarCapLock()
        {
            
            error.SetError(this, "MAYUSCULA ACTIVADA!!!");

        }

        private bool flagAñadirEvento = false;
        

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (flagAñadirEvento == false)
            {
                this.AvisarCapsLock += new TeclaPrecionada(avisarCapLock);
                flagAñadirEvento = true;
            }
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                this.AvisarCapsLock();
            }
            else
            {
                this.AvisarCapsLock -= new TeclaPrecionada(avisarCapLock);
                flagAñadirEvento = false;
                error.Clear();
            
            }
            base.OnKeyPress(e);
        }
    }

    public class TextBoxColor : System.Windows.Forms.TextBox
    {
        public System.Drawing.Color ControlColorEnfocado { set; get; }
        public System.Drawing.Color ControlColorDesenfocado { set; get; }
        public bool AplicarColorFoco { set; get; }

        protected override void OnEnter(EventArgs e)
        {
            if (AplicarColorFoco == true)
            {
                this.BackColor = ControlColorEnfocado;
            }
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            if (AplicarColorFoco == true)
            {
                this.BackColor = ControlColorDesenfocado;
            }
            base.OnLeave(e);
        }
        
    }

    public enum EFormato
    { 
        formatoIngles,
        formatoLatino
    }

    public class txtFechaValida : TextBox
    {
        public EFormato queFormato { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (this.queFormato)
            {
                case EFormato.formatoIngles:
                    if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
                        e.Handled = true;
                    break;
                case EFormato.formatoLatino:
                    if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != '/' && e.KeyChar != (char)Keys.Back)
                        e.Handled = true;
                    break;
                default:
                    break;
            }

            base.OnKeyPress(e);
        }
    }

    public class txtBoxInfoNumero : txtSoloNumeros
    {

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter && this.Text != "0")
            {
                //System.Convert.ToInt32(this.Text)
                StreamReader archivoLectura = new StreamReader("Datos_numero.txt");
                StringBuilder cadenaLectura = new StringBuilder(); 
                cadenaLectura.AppendLine(archivoLectura.ReadToEnd());
                archivoLectura.Close();
                StreamWriter archivo = new StreamWriter("Datos_numero.txt");
                StringBuilder cadena = new StringBuilder();
                DateTime horaActual = DateTime.Now;
                cadena.AppendLine("Guardado: " + horaActual);

                int numero = 0;
                cadena.AppendLine("Cantidad de cifras: " + this.Text.Length);

                for(int i = 0; i< this.Text.Length;i++)
                {
                    if (((this.Text[i] -48) % 2) == 1)
                    {
                        numero += this.Text[i] - 48;
                    }
                }
                cadena.AppendLine("Suma impares: " + numero);

                numero = 0;
                for (int i = 0; i < this.Text.Length; i++)
                {
                    if (((this.Text[i] - 48) % 2) == 0)
                    {
                        numero += this.Text[i] - 48;
                    }
                }
                cadena.AppendLine("Suma pares: " + numero);

                numero = 0;
                for (int i = 0; i < this.Text.Length; i++)
                    numero += this.Text[i] - 48;
                cadena.AppendLine("Suma total: " + numero);

                bool flagMayor = false;
                int miMayor = 0;
                for (int i = 0; i < this.Text.Length; i++)
                {
                    if (flagMayor == false)
                    {
                        miMayor = this.Text[0] - 48;
                        flagMayor = true;
                    }
                    if (miMayor < (this.Text[i] - 48))
                        miMayor = this.Text[i] - 48;

                }
                cadena.AppendLine("Mi mayor es: " + miMayor);

                bool flagMenor = false;
                int miMenor = 0;
                for (int i = 0; i < this.Text.Length; i++)
                {
                    if (flagMenor == false)
                    {
                        miMenor = this.Text[0] - 48;
                        flagMenor = true;
                    }
                    if (miMenor > (this.Text[i] - 48))
                        miMenor = this.Text[i] - 48;

                }
                cadena.AppendLine("Mi menor es: " + miMenor);

                String divisores = "Los divisores son: ";
                for (int i = 1; i <= System.Convert.ToInt32(this.Text); i++)
                {
                    if((System.Convert.ToInt32(this.Text) % i) == 0)
                        divisores += "-" + i + "-";
                }
                cadena.AppendLine(divisores);

                cadenaLectura.Append(cadena);
                archivo.Write(cadenaLectura);
                
                archivo.Close();
            }
            base.OnKeyPress(e);
        }
    }

    public class txtFechaValidaExt : txtFechaValida
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar != ':')
                e.Handled = true;
            base.OnKeyPress(e);
        }
    }

   
}
