using System;
using System.Collections.Generic;

namespace Conversor {
    public static class Conversor {
        private static Dictionary<string, Divisa> _diccionarioDivisas = new Dictionary<string, Divisa>();

        //
        //Añade una divisa al diccionario con el codigo como key
        //
        public static void AddDivisa(Divisa divisa) {
            if(!_diccionarioDivisas.ContainsKey(divisa.Codigo)) {
                _diccionarioDivisas.Add(divisa.Codigo, divisa);
            }
        }

        //
        //Convierte el valor de una divisa a otra
        //
        public static double Convertir(string divInicial, string divFinal, double cantidad) {
            if(_diccionarioDivisas.ContainsKey(divFinal) && _diccionarioDivisas.ContainsKey(divFinal)) {
                return Math.Round(Math.Round(cantidad * _diccionarioDivisas[divInicial].Cambio, 2) / _diccionarioDivisas[divFinal].Cambio, 2);
            }
            throw new UnknownCurrencyException();
        }

        //
        //Devuelve una coleccion de los codigos de divisa en el diccionario
        //
        public static Dictionary<string, Divisa>.KeyCollection getKeys() {
            return _diccionarioDivisas.Keys;
        }
    }
}
