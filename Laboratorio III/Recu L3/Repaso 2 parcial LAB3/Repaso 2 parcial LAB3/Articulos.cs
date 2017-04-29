using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPrincipal
{
    public enum Etipo
    {
        Gaseosa,
        Golosina,
        Comestible
    }

    public class Articulo
    {
        private string _marca;
        private double _precioVenta;
        private int _stock;
        private Etipo _tipo;

        public string Marca
        {
            get { return this._marca; }
        }

        public double PrecioVenta
        {
            get { return this._precioVenta; }
        }
        public int Stock
        {
            get { return this._stock; }
        }
        public Etipo Tipo
        {
            get { return this._tipo; }
        }

        public Articulo(Etipo tipo, string marca, double precioVenta, int stock)
        {
            this._marca = marca;
            this._precioVenta = precioVenta;
            this._stock = stock;
            this._tipo = tipo;
        }


        public override string ToString()
        {
            return "Tipo: " + this._tipo + " Marca: " + this._marca + " precio: " + this._precioVenta + " stock: " + this._stock;
        }

    }
}
