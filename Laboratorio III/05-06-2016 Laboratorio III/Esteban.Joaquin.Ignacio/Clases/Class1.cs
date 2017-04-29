using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public enum eTipoDeMascota
    { 
        exotica,
        hogareña
    }
    public class Animal
    {
        private int _edad;

        public int edad
        {
            get { return this._edad; }
            set { this._edad = value; }
        }

        public Animal(int edad)
        {
            this._edad = edad;
        }

        public override string ToString()
        {
            return Convert.ToString(edad);
        }
    }

    public class Mascota : Animal
    {
        private string _nombre;
        private eTipoDeMascota _tipoDeMascota;

        public string nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }

        }

        public eTipoDeMascota tipoDeMascota
        {
            get { return this._tipoDeMascota; }
            set { this._tipoDeMascota = value; }
        }

        public Mascota(string nombre, eTipoDeMascota tipo, int edad)
            : base(edad)
        {
            this._nombre = nombre;
            this._tipoDeMascota = tipo;
        }

        public static int ordenarPorEdad(Mascota mascotaUno, Mascota mascotaDos)
        { 
            return mascotaUno.edad - mascotaDos.edad;
        }

        public static int ordenarPorNombre(Mascota mascotaUno, Mascota mascotaDos)
        {
            return String.Compare(mascotaUno.nombre, mascotaDos.nombre);
        }

        public static int ordenarPorTipo(Mascota mascotaUno, Mascota mascotaDos)
        {
            return String.Compare(Convert.ToString(mascotaUno.tipoDeMascota), Convert.ToString(mascotaDos.tipoDeMascota)); 
        }

        public override string ToString()
        {
            return this.nombre + "-" + this.tipoDeMascota + "-" + this.edad; 
        }

        
    }
}
