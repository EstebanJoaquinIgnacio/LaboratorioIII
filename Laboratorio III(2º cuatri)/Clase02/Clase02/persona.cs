using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    public class persona
    {
        public string nombre;
        public int edad;

        public persona(string Nombre,int Edad)
        {
            this.edad = Edad;
            this.nombre = Nombre;
        }

        public override string ToString()
        {
            return "Nombre: " + this.nombre + "--- Edad: " + this.edad;
        }

    }
}
