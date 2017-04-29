using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Curso
    {
        private int _codigoCurso;
        private int _duracion;
        private string _nombre;

        public int codigoCurso { get { return this._codigoCurso; } }
        public int duracion { get { return this._duracion; } }
        public string nombre { get { return this._nombre; } }

        public Curso(int codigoCurso, int duracion, string nombre)
        {
            this._codigoCurso = codigoCurso;
            this._duracion = duracion;
            this._nombre = nombre;
        }

    }
}
