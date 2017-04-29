using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private int _codigoCurso;
        private int _duracion;
        private string _nombre;

        public int CodigoCurso{
            get { return this._codigoCurso; }
        }
        public int Duracion
        {
            get { return this._duracion; }
        }
        public string Nombre
        {
            get { return this._nombre; }
        }

        public Curso(int cod, int dur, string nom) { 
            this._codigoCurso = cod;
            this._duracion = dur;
            this._nombre = nom;
        }


    }
}
