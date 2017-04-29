using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public class Animal
    {
        protected int _edad;

        public int edad
        {
            get { return this._edad; }
        }

        public Animal(int edad)
        {
            this._edad = edad;
        }

        public override string ToString()
        {
            return this._edad.ToString();
        }
    }

    public enum eTipoDeMascota
    { 
        exotica,
        hogareña
    }

    public class Mascota:Animal
    {
        protected string _nombre;
        protected eTipoDeMascota _TipoDeMascota;

        public string nombre
        {
            get { return this._nombre; }
        }

        public eTipoDeMascota TipoDeMascota
        {
            get { return this._TipoDeMascota; }
        }

        public Mascota(string nombre, eTipoDeMascota Tipo, int edad) 
            : base(edad) 
        {
            this._nombre = nombre;
            this._TipoDeMascota = Tipo;
        }

        public static int OrdenarPorEdad(Mascota mascotaUno, Mascota mascotaDos)
        {
            return mascotaUno.edad - mascotaDos.edad;
        }

        public static int OrdenarPorNombre(Mascota mascotaUno, Mascota mascotaDos)
        {
            return mascotaUno.nombre.CompareTo(mascotaDos.nombre);
        }

        public static int OrdenarPorTipo(Mascota mascotaUno, Mascota mascotaDos)
        {
            return mascotaUno.TipoDeMascota - mascotaDos.TipoDeMascota;
        }

        public override string ToString()
        {
            return this.nombre + " " + this.TipoDeMascota.ToString() + " " +base.ToString();
        }



        
    }

    public enum letraNumero
    { 
        letra,
        numero
    }

    public class miTextBox : TextBox
    {
        public letraNumero Filtro { set; get; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (Filtro)
            {
                case letraNumero.letra:
                    if((e.KeyChar < 'a' || e.KeyChar > 'z') && e.KeyChar != (char)Keys.Back && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
                        e.Handled = true;
                    break;
                case letraNumero.numero:
                    if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
                        e.Handled = true;
                    break;
                default:
                    break;
            }

            base.OnKeyPress(e);
        }
    }
}
