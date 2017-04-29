using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12_JOA
{
    public class Persona
    {
        public string _Nombre;
        public string _Apellido;
        public int _Edad;

        public Persona(string nombre,string apellido,int edad)
        {
            this._Apellido = apellido;
            this._Edad = edad;
            this._Nombre = nombre;
        }

        public string nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }

        public string apellido
        {
            get { return this._Apellido; }
            set { this._Apellido = value; }
        }

        public int edad
        {
            get { return this._Edad; }
            set { this._Edad = value; }
        }

    }
}
