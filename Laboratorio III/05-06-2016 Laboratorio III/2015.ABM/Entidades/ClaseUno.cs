using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ClaseUno
    {
        private String _datoString;

        public String DatoString
        {
            get { return _datoString; }
            set { _datoString = value; }
        }

        private Int32 _datoEntero;

        public Int32 DatoEntero
        {
            get { return _datoEntero; }
            set { _datoEntero = value; }
        }

        public ClaseUno(string cadena, int entero)
        {
            this._datoString = cadena;
            this._datoEntero = entero;
        }

        public override string ToString()
        {
            return this._datoString + " -- "+ this._datoEntero.ToString();
        }
    }
}
