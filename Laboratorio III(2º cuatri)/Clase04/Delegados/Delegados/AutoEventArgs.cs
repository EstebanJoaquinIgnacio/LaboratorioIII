using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class AutoEventArgs: EventArgs
    {
        private double _combustibleEnElTanque;

        public double CombustibleTanque {
            get { return this._combustibleEnElTanque; }
            set { this._combustibleEnElTanque = value; }
        }
    }
}
