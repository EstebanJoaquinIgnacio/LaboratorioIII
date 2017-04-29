using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    public class Alumno : persona
    {
        public int legajo;

        public Alumno(string Nombre, int Edad,int Legajo):base(Nombre,Edad)
        {
            this.legajo = Legajo;
        }

        public override string ToString()
        {
            return "Legajo: " + this.legajo + "---" + base.ToString();
        }
    }
}
