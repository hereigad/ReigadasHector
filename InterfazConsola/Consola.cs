using System;
using System.Collections.Generic;

namespace InterfazConsola {
    public class Consola {
        public static void menu() {
            Conversor.Conversor.AddDivisa(new Conversor.Divisa("EUR", 1));
            Conversor.Conversor.AddDivisa(new Conversor.Divisa("USD", 0.85));
            Conversor.Conversor.AddDivisa(new Conversor.Divisa("GBP", 1.10));
            Conversor.Conversor.AddDivisa(new Conversor.Divisa("JPY", 0.0081));
            Dictionary<string, Conversor.Divisa>.KeyCollection codigos = Conversor.Conversor.getKeys();
            string divInicial = null;
            string divFinal = null;
            double cantidad = 0;
            Console.WriteLine("Convertir de ...");
            foreach(string c in codigos) {
                Console.WriteLine(c);
            }
            Console.WriteLine("Introduce opcion:");
            divInicial = Console.ReadLine().ToUpper();

            Console.WriteLine("A ...");
            foreach (string c in codigos) {
                Console.WriteLine(c);
            }
            Console.WriteLine("Introduce opcion:");
            divFinal = Console.ReadLine().ToUpper();

            Console.WriteLine("Cantidad a convertir:");
            cantidad = Double.Parse(Console.ReadLine());


            Console.WriteLine("Resultado de la conversion:");
            Console.WriteLine(Conversor.Conversor.Convertir(divInicial, divFinal, cantidad));
        }
    }
}
