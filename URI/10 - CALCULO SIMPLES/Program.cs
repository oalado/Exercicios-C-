using System;
using System.Globalization;
namespace uri1003 {
    class Program {
        static void Main(string[] args) {
           
         int peca1, numPeca1, peca2, numPeca2;
            double valPeca1, valPeca2, total;

            string[] vet = Console.ReadLine().Split(' ');
         peca1 = int.Parse(vet[0]);
         numPeca1 = int.Parse(vet[1]);
         valPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

         string[] vet2 = Console.ReadLine().Split(' ');
         peca2 = int.Parse(vet2[0]);
         numPeca2 = int.Parse(vet2[1]);
            valPeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            total = (numPeca1 * valPeca1) + (numPeca2 * valPeca2);
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        

            
        }
    }
}