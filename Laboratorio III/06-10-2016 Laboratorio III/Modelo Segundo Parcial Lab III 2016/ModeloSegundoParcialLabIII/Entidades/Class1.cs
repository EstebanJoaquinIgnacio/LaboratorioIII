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

        public Alumno(string apellido, int codCurso, int legajo)
        {
            this._apellido = apellido;
            this._codCurso = codCurso;
            this._legajo = legajo;
        }

        public string Apellido
        {
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
    }

    public class Curso
    {
        private int _codigoCurso;
        private int _duracion;
        private string _nombre;

        public Curso(int codigoCurso, int duracion, string nombre)
        {
            this._codigoCurso = codigoCurso;
            this._duracion = duracion;
            this._nombre = nombre;
        }

        public int CodigoCurso
        {
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

    }
}
