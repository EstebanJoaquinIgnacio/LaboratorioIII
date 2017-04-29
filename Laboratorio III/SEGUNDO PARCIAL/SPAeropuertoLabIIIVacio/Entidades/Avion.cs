using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion
    {
        private int _matricula;
        private string _marca;        
        private string _modelo;
        private int _capacidad;

        public int Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }            

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }        

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }        

        public int Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }

        private int _codVuelo;

        public int CodVuelo
        {
            get { return _codVuelo; }
            set { _codVuelo = value; }
        }

        public Avion(int matricula, string marca, string modelo, int capacidad, int codVuelo)
        {
            this._matricula = matricula;
            this._marca = marca;
            this._modelo = modelo;
            this._capacidad = capacidad;
            this._codVuelo = codVuelo;
            
        }
        
        
        
        

    }
}
