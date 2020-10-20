using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor {
    class UnknownCurrencyException : Exception{
        public override string Message { get; } = "Una de las divisas no se encuentra en el diccionario";
    }
}
