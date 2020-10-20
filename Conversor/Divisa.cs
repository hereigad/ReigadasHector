using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor {
    public class Divisa {
        private string _codigo;
        private double _cambio;

        public Divisa(string codigo, double cambio) {
            this._codigo = codigo.ToUpper();
            this._cambio = cambio;
        }

        public string Codigo {
            get { return _codigo; }
        }

        public double Cambio {
            get { return _cambio; }
        }
    }
}
