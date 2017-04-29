using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public delegate void AutoDel(Object sender, AutoEventArgs e);

    public class Auto
    {
        public AutoDel EventoReserva;
        public AutoDel TanqueVacio;

        private string _marca;
        private double _combustible;
        private double _reserva;

        //PROPIEDADES
        public double Combustible
        {
            get { return this._combustible; }
            set { this._combustible = value; }
        }
        public double Reserva
        {
            get { return this._reserva; }
            set { this._reserva = value; }
        }
        public string Marca
        {
            get { return this._marca; }
        }

        //METODOS
        public void LlenarElTanque() {
            this._combustible = 60;
            this._reserva = 60;
        }
        public void Conducir(int kilometros) { 
            //CONSUMO DE 1 Lt CADA 10Km
            //CUANDO EL COMBUSTIBLE SEA > 0 Y < 10 DISPARAR EVENTO RESERVA
            //CUANDO LLEGUE A 0 DISPARAR TanqueVacio
            while(kilometros > 0){
                this._combustible -= 0.1;
                kilometros -= 1;

                AutoEventArgs evento = new AutoEventArgs();
                evento.CombustibleTanque = this._combustible;

                //RESERVA
                if (this._combustible > 0 && this._combustible < 10)
                {
                    EventoReserva(this, evento);
                }
                //TANQUE VACIO
                if (this._combustible == 0)
                {
                    TanqueVacio(this, evento);
                    break;
                }
            }

        }
        public Auto(string marca) {
            this._marca = marca;
            LlenarElTanque();
        }
        public override string ToString()
        {
            return "Marca: " + this._marca + " - Combustible: " + this._combustible + " - Reserva: " + this._reserva;
        }

        //EVENTOS
    }
}
