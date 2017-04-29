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

        public string Apelido {
            get { return this._apellido; }
        }
        public int Curso
        {
            get { return this._codCurso; }
        }
        public int Legajo
        {
            get { return this._legajo; }
        }

        public Alumno(int cod, int leg, string ape) {
            this._codCurso = cod;
            this._legajo = leg;
            this._apellido = ape;
        }
    }
}
