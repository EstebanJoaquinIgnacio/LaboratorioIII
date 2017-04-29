using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._fotoAlumno = ruta;
        }

        private string _apellido;
        private int _dni;
        private string _fotoAlumno;
        private string _nombre;

        public string apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public int dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }

        public string fotoAlumno
        {
            get { return this._fotoAlumno; }
            set { this._fotoAlumno = value; }
        }

        public string nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
    }
}
