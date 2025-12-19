using System;
using System.Globalization;

namespace uri1003 {
    class Program {
        static void Main(string[] args) {

            double int nota1, nota2, notaFinal;

        double = Console.ReadLine(), CultureInfo.InvariantCulture);
        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notaFinal = (nota1 + nota2);

            if (notaFinal < 60.0) {
                Console.WriteLine("REPROVADO");
            }
            else {
                Console.WriteLine("APROVADO");
            }

            
        }
    }
}