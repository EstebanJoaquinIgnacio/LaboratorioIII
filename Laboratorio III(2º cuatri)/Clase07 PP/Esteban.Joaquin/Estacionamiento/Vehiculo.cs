using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    public class Vehiculo
    {
        private string _patente;
        private string _color;
        private DateTime _fechaDeIngreso;
        //public double costo;

        public string patente
        {
            get { return this._patente; }
        }
        public string color
        {
            get { return this._color; }
        }
        public DateTime fechaDeIngreso
        {
            get { return this._fechaDeIngreso; }
        }

        public override string ToString()
        {
            return this._patente + " " + this._color + " " + this._fechaDeIngreso;
        }

        public static int ordenarPorFechaDeIngreso(Vehiculo unoVehiculo,Vehiculo dosVehiculo)
        {

            return DateTime.Compare(unoVehiculo.fechaDeIngreso,dosVehiculo.fechaDeIngreso);
            
        }

        public static int ordenarPorPatente(Vehiculo unoVehiculo, Vehiculo dosVehiculo)
        {
            return unoVehiculo._patente.CompareTo(dosVehiculo._patente);
        }

        public Vehiculo(string patente)
        {
            this._patente = patente;
        }

        public Vehiculo(string patente, string color):this(patente)
        {
            this._color = color;
        }

        public Vehiculo(string patente, string color,DateTime ingreso):this(patente,color)
        {           
            
            this._fechaDeIngreso = ingreso;
        }


    }
}
