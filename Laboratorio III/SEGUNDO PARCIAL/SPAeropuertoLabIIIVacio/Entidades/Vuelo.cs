using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vuelo
    {
        private int _codVuelo;
        private string _destino;

        public int CodVuelo
        {
            get { return _codVuelo; }
            set { _codVuelo = value; }
        }       

        public string Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }
    }
}
