using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string _apellido;
        private int _codCurso;
        private int _legajo;


        public string apellido { get { return this._apellido; } }
        public int codCurso { get { return this._codCurso; } }
        public int legajo { get { return this.legajo; } }

        public Alumno(string apellido, int codCurso, int legajo)
        {
            this._apellido = apellido;
            this._codCurso = codCurso;
            this._legajo = legajo;
        }

    }
}
