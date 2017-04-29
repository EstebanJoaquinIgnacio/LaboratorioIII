using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
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
            return Convert.ToString(this._edad);
        }


    }

    public enum eTipoDeMascota
    { 
        exotica,
        hogareña
    }

    public class Mascota : Animal
    {
        protected string _nombre;
        protected eTipoDeMascota _tipoDeMascota;

        public string nombre
        {
            get { return this._nombre; }
        }

        public eTipoDeMascota tipoDeMascota
        {
            get { return this._tipoDeMascota; }
        }

        public Mascota(string nombre, eTipoDeMascota tipo, int edad)
            : base(edad)
        {
            this._nombre = nombre;
            this._tipoDeMascota = tipo;
        }

        public static int OrdenarPorEdad(Mascota mascotaUno,Mascota mascotaDos)
        {
            return mascotaUno.edad - mascotaDos.edad;
        }

        public static int OrdenarPorNombre(Mascota mascotaUno, Mascota mascotaDos)
        {
            return String.Compare(mascotaUno.nombre,mascotaDos.nombre);
        }

        public static int OrdenarPorTipo(Mascota mascotaUno, Mascota mascotaDos)
        {
            return mascotaUno.tipoDeMascota - mascotaDos.tipoDeMascota;
        }

        public override string ToString()
        {
            return this._nombre + " " + this._tipoDeMascota + " " + base.ToString();
        }
    }

    public enum tipoTextoPermitido
    { 
        letras,
        numeros
    }

    public class miTextBox : TextBox
    {

        //private tipoTextoPermitido _PermisoDeIngreso;
        public tipoTextoPermitido letraNumero { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (letraNumero)
            {
                case tipoTextoPermitido.letras:
                    if ((e.KeyChar < 'a' || e.KeyChar > 'z') && e.KeyChar != (Char)Keys.Back && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
                    {
                        e.Handled = true;
                    }
                    break;
                case tipoTextoPermitido.numeros:
                    if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (Char)Keys.Back)
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
