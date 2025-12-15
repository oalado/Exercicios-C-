using System;
using System.Globalization;

namespace uri1003 {
    class Program {
        static void Main(string[] args) {

            int Km;
            double litros, consumo;

            Km = int.Parse(Console.ReadLine());           
            litros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumo = (Km / litros);

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}